using AForge.Video.DirectShow;
using ProjectGimnasiaYEsgrima.Controlador;
using ProjectGimnasiaYEsgrima.Modelo;
using ProjectGimnasiaYEsgrima.Utils;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ZXing;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    public partial class InterfazEntradaSalida : Form
    {
        private FilterInfoCollection Dispositivos;
        private VideoCaptureDevice videocapture;
        private bool parado;
        private Timer msgTimer;
        private int disposeFormTimer;
        private InterfazPrincipal MiVentana;
        public InterfazEntradaSalida(InterfazPrincipal ventana)
        {
            MiVentana = ventana;
            InitializeComponent();
            parado = true;

            CargarInterfazBuena();
        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloEntradaSalida);
            interfaz.TransformarBotonPersonalizadoTodos(btnIniciar, btnParar, btnVolver);
            interfaz.TransformarComboBoxPersonalizado(cbxSeleccionDipositivos);
            interfaz.TransformarTextBoxTextoNoEditablePersonalizado(txtFechaIngreso);
            interfaz.TransformarTextBoxTextoNoEditablePersonalizado(txtNombreApellido);
            interfaz.TransformarTextBoxTextoNoEditablePersonalizado(txtTipoDoc);
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblContador, lblFechaIngreso, lblNombreApellido, lblTipoDocumentoYNro,lblTipo);
            lblContador.Font = new System.Drawing.Font("Century Gothic", 30F);

        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (cbxSeleccionDipositivos.Items.Count == 0)
            {
                MyMessageBox.Show(this, "No hay ningún dispositivo de transmisión conectado para ejecutar", "No hay cámaras disponibles");
                return;
            }
            videocapture = new VideoCaptureDevice(Dispositivos[cbxSeleccionDipositivos.SelectedIndex].MonikerString);
            vspEntradaSalida.VideoSource = videocapture;
            vspEntradaSalida.Start();
            tmpCapture.Start();
            parado = false;
        }

        private void vspEntradaSalida_Click(object sender, EventArgs e)
        {

        }

        private void InterfazEntradaSalida_Load(object sender, EventArgs e)
        {
            Dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach(FilterInfo i in Dispositivos)
            {
                cbxSeleccionDipositivos.Items.Add(i.Name);
            }
            cbxSeleccionDipositivos.SelectedIndex = 0;
            pnlFoto.BackgroundImage = new Bitmap(global::ProjectGimnasiaYEsgrima.Properties.Resources.Perfil);
            pnlDatosPersona.Hide();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            if (videocapture != null && tmpCapture != null)
            {
                videocapture.Stop();
                tmpCapture.Stop();
            }
            parado = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if(videocapture!=null && tmpCapture != null) { 
                videocapture.Stop();
                tmpCapture.Stop();
            }
            MiVentana.CargarLogin();
            Dispose();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            if (parado) { pnlDatosPersona.Hide(); disposeFormTimer = -1; }
            disposeFormTimer--;

            if (disposeFormTimer >= 0)
            {
                lblContador.Text = disposeFormTimer.ToString();
            }
            else
            {
                pnlDatosPersona.Hide();
                if (!parado)
                {
                    vspEntradaSalida.Start();
                    tmpCapture.Start();
                }
            }
        }

        private void tmpCapture_Tick(object sender, EventArgs e)
        {
            if (vspEntradaSalida.GetCurrentVideoFrame() != null)
            {
                Bitmap image = new Bitmap(vspEntradaSalida.GetCurrentVideoFrame());
                ZXing.BarcodeReader barcodeReader = new ZXing.BarcodeReader() { AutoRotate = true};
                
                Result resultado = barcodeReader.Decode(image);
                //barcode.Format = BarcodeFormat.CODE_128;
                if (resultado != null)
                {
                    string texto = resultado.ToString().Trim();
                    vspEntradaSalida.Stop();
                    tmpCapture.Stop();
                    string[] transpaso = texto.Split('-');
                    if (transpaso.Length == 2 && new Regex("[a-zA-Z]*").IsMatch(transpaso[0]) && new Regex("[0-9]*").IsMatch(transpaso[1])) { 
                        if (CargarInformacionPlanilla((transpaso[0].Equals("Socio") ? 1 : 0), Int32.Parse(transpaso[1]))) { 
                            disposeFormTimer = 5;
                            msgTimer = new Timer();
                            msgTimer.Interval = 1000;
                            msgTimer.Enabled = true;
                            msgTimer.Start();
                            msgTimer.Tick += new System.EventHandler(this.timer_tick);
                        }
                        else
                        {
                            vspEntradaSalida.Start();
                            tmpCapture.Start();
                        }
                    }
                    else
                    {
                        vspEntradaSalida.Start();
                        tmpCapture.Start();
                    }

                }

            }
        }

        private bool CargarInformacionPlanilla(int TipoPersona, int DNI)
        {
            lblFechaIngreso.Text = "Fecha Ingreso";
            if (TipoPersona == 1) // ES SOCIO
            {
                // Cargar el socio desde controlador y adjuntar a la planilla
                ModelSocioPersona socioPersona = new ControladorSocio().BuscarPorClavesUnicasSocio(DNI);
                if (socioPersona == null) return false;
                txtNombreApellido.Text = socioPersona.MiPersona.Nombre + "," + socioPersona.MiPersona.Apellido;
                txtTipoDoc.Text = socioPersona.MiPersona.DNI + "";
                txtFechaIngreso.Text = DateTime.Now.ToString(/*"dd'/'MM'/'yyyy"*/);
                lblTipo.Text = socioPersona.MiSocio.EstadoSocio.ToString();
                if (socioPersona.MiPersona.Foto != null)
                    pnlFoto.Image = byteArrayToImage(socioPersona.MiPersona.Foto);
                else
                    using (var ms = new MemoryStream()) {
                        new Bitmap(global::ProjectGimnasiaYEsgrima.Properties.Resources.Perfil).Save(ms, ImageFormat.Png);
                        pnlFoto.Image = byteArrayToImage(ms.ToArray());
                    }
                pnlFoto.Show();

            }
            else // ES EMPLEADO
            {
                // Cargar el empleado desde controlador y adjuntar a la planilla
                ModelEmpleadoPersona empleadoPersona = new ControladorEmpleado().BuscarEmpleadoPorClavesUnicasPorVista(DNI);
                if (empleadoPersona == null) return false;
                txtNombreApellido.Text = empleadoPersona.MiPersona.Nombre + "," + empleadoPersona.MiPersona.Apellido;
                txtTipoDoc.Text = empleadoPersona.MiPersona.DNI + "";
                txtFechaIngreso.Text = DateTime.Now.ToString(/*"dd'/'MM'/'yyyy"*/);
                lblTipo.Text = empleadoPersona.MiEmpleado.TipoEmpleado.ToString();
                if (empleadoPersona.MiPersona.Foto != null)
                    pnlFoto.Image = byteArrayToImage(empleadoPersona.MiPersona.Foto);
                else
                    using (var ms = new MemoryStream())
                    {
                        new Bitmap(global::ProjectGimnasiaYEsgrima.Properties.Resources.Perfil).Save(ms, ImageFormat.Png);
                        pnlFoto.Image = byteArrayToImage(ms.ToArray());
                    }
                pnlFoto.Show();


                if (new ControladorEmpleado().RegistrarEntradaSalidaEmpleado(empleadoPersona) == 0)
                    lblFechaIngreso.Text = "Fecha Ingreso";
                else
                {
                    lblFechaIngreso.Text = "Fecha Egreso";
                }
            }
            pnlDatosPersona.Show();
            return true;
        }

        private Image byteArrayToImage(byte[] byteArrayIn)
        {
            //MemoryStream mStream = new MemoryStream(byteArrayIn);
            //return Image.FromStream(mStream);
            MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
            ms.Position = 0; // this is important
            return new Bitmap(Image.FromStream(ms, true),new Size(224, 208));

        }

        private void InterfazEntradaSalida_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videocapture != null) videocapture.Stop();
            if (tmpCapture != null) tmpCapture.Stop();
            MiVentana.CargarLogin();
            Dispose();
        }

        private void InterfazEntradaSalida_FormClosing(object sender, FormClosedEventArgs e)
        {
            videocapture.Stop();
            tmpCapture.Stop();
        }
    }
}
