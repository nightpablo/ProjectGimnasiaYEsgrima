using Microsoft.Reporting.WinForms;
using ProjectGimnasiaYEsgrima.Controlador;
using ProjectGimnasiaYEsgrima.Modelo;
using ProjectGimnasiaYEsgrima.Utils;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using ZXing;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    public partial class InterfazEmitirCarnet : Form
    {

        private ModelSocioPersona MiSocio;
        private InterfazListaSocio MiVentana;
        private InterfazListaEmpleado MiVentana2;
        private ModelEmpleadoPersona MiEmpleado;

        private Bitmap bbb;

        public InterfazEmitirCarnet(InterfazListaEmpleado ventana, ModelEmpleadoPersona emp)
        {
            MiEmpleado = emp;
            MiVentana2 = ventana;
            InitializeComponent();
            
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjectGimnasiaYEsgrima.Utils.Empleado.rdlc";

            CargarInterfazBuena();
        }

        public InterfazEmitirCarnet(InterfazListaSocio ventana, ModelSocioPersona socio)
        {
            MiSocio = socio;
            MiVentana = ventana;
            InitializeComponent();
            
            
            
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjectGimnasiaYEsgrima.Utils.Socio.rdlc";



            CargarInterfazBuena();
        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarBotonPersonalizadoTodos(btnCambiarFoto, btnVolver);
        }




        private void reportViewer1_Load(object sender, EventArgs e)
        {
            if (MiEmpleado != null) {           
                MiEmpleado = new ControladorEmpleado().BuscarEmpleadoPorClavesUnicasPorVista(MiEmpleado.MiPersona.DNI);
                if (MiEmpleado.MiPersona.Foto != null) { 
                    using (var ms = new MemoryStream(MiEmpleado.Foto))
                        bbb = new Bitmap(Image.FromStream(ms));
                }
                else
                {
                    using (var ms = new MemoryStream())
                    {
                        new Bitmap(global::ProjectGimnasiaYEsgrima.Properties.Resources.Perfil).Save(ms, ImageFormat.Png);
                        MiEmpleado.MiPersona.Foto = ms.ToArray();
                        new ControladorPersona().ActualizarFotoPersona(MiEmpleado.MiPersona.DNI, ms.ToArray());
                    }
                }
            }
            else
            {
                MiSocio = new ControladorSocio().BuscarPorClavesUnicasSocio(MiSocio.MiPersona.DNI);
                if (MiSocio.MiPersona.Foto != null)
                {
                    using (var ms = new MemoryStream(MiSocio.MiPersona.Foto))
                        bbb = new Bitmap(Image.FromStream(ms));
                }
                else
                {
                    using (var ms = new MemoryStream())
                    {
                        new Bitmap(global::ProjectGimnasiaYEsgrima.Properties.Resources.Perfil).Save(ms, ImageFormat.Png);
                        MiEmpleado.MiPersona.Foto = ms.ToArray();
                        new ControladorPersona().ActualizarFotoPersona(MiSocio.MiPersona.DNI, ms.ToArray());
                    }
                }
                
            }

        string tipoDoc = MiSocio == null ? "" : MiSocio.MiSocio.TipoDocumento+"";
            int numeroDoc = MiSocio == null ? MiEmpleado.DNI : MiSocio.DNI;
            string nombre = MiSocio == null ? MiEmpleado.Nombre : MiSocio.Nombre;
            string apellido = MiSocio == null ? MiEmpleado.Apellido : MiSocio.Apellido;
            string fechaIngreso = MiSocio == null ? new DateTime(MiEmpleado.MiEmpleado.FechaInicio.Year, MiEmpleado.MiEmpleado.FechaInicio.Month, MiEmpleado.MiEmpleado.FechaInicio.Day).ToString("dd'/'MM'/'yyyy") : new DateTime(MiSocio.MiSocio.FechaInicio.Year, MiSocio.MiSocio.FechaInicio.Month, MiSocio.MiSocio.FechaInicio.Day).ToString("dd'/'MM'/'yyyy");
            string tipoEmpleado = MiSocio == null ? MiEmpleado.TipoEmpleado.ToString() : MiSocio.MiSocio.CategoriaSocio.ToString();
            string tipoDocumentacion = MiSocio == null ? "Empleado" : "Socio"; 
            string barratexto = tipoDocumentacion + "-" + numeroDoc;

            

            BarcodeWriter barcode = new BarcodeWriter();
            barcode.Format = BarcodeFormat.QR_CODE;

            barcode.Options = new ZXing.Common.EncodingOptions
            {
                Height = 400,
                Width = 400,
                Margin = 1
            };


            var b = barcode.Write(barratexto);
            ReportParameter PCodigoBarras;
            using (var ms = new MemoryStream()) { 
                b.Save(ms, ImageFormat.Png);
                PCodigoBarras = new ReportParameter()
                {
                    Name = "ReportParameterCodigoBarras",
                    Values = { Convert.ToBase64String(ms.ToArray()) }
                };
            }
            Bitmap c;
            if (bbb == null)
                c = new Bitmap(global::ProjectGimnasiaYEsgrima.Properties.Resources.Perfil);
            else
                c = bbb;
            ReportParameter PFoto;
            using (var ms = new MemoryStream())
            {
                c.Save(ms, ImageFormat.Png);
                PFoto = new ReportParameter()
                {
                    Name = "ReportParameterFoto",
                    Values = { Convert.ToBase64String(ms.ToArray()) }
                };
            }



            ReportParameter PTipoDocyNumero = new ReportParameter("ReportParameterTipoDocyNumero", tipoDoc + "   " + numeroDoc);
            ReportParameter PNombre = new ReportParameter("ReportParameterNombreYApellido", nombre+" "+apellido);
            ReportParameter PApellido = new ReportParameter("ReportParameterFechaIngreso", fechaIngreso);   
            ReportParameter PTipoEmpleado = new ReportParameter("ReportParameterCategoria", tipoEmpleado);
            
            
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { PTipoDocyNumero, PNombre, PApellido, PTipoEmpleado, PCodigoBarras, PFoto });
            
            this.reportViewer1.RefreshReport();
        }

        private void btnCambiarFoto_Click(object sender, EventArgs e)
        {
            string location;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                location = open.FileName;
                bbb = new Bitmap(location);
            }
            using(var ms = new MemoryStream()) {
                bbb.Save(ms, ImageFormat.Png);
                if (MiEmpleado != null)
                {                    
                    new ControladorPersona().ActualizarFotoPersona(MiEmpleado.MiPersona.DNI, ms.ToArray());
                }
                else
                {
                    new ControladorPersona().ActualizarFotoPersona(MiSocio.MiPersona.DNI, ms.ToArray());
                }
            }
            reportViewer1_Load(sender, e);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void InterfazGenerarReporte_FormClosing(object sender, FormClosingEventArgs e)
        {
            MiEmpleado = null;
            MiSocio = null;
            Dispose();
        }
    }
}
