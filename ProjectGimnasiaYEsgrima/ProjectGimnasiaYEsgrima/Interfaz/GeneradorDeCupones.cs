using Microsoft.Reporting.WinForms;
using ProjectGimnasiaYEsgrima.Modelo;
using ProjectGimnasiaYEsgrima.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    public partial class InterfazGeneradorDeCupones : Form
    {
        private InterfazListaSocio MiVentana;
        private List<ModelImpresionCuponSocio> MiModelos1;
        private List<ModelImpresionCuponSocio> MiModelos2;
        public InterfazGeneradorDeCupones(InterfazListaSocio ventana, List<ModelImpresionCuponSocio> models1, List<ModelImpresionCuponSocio> models2)
        {
            MiVentana = ventana;
            MiModelos1 = models1;
            MiModelos2 = models2;
            InitializeComponent();
            
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjectGimnasiaYEsgrima.Utils.Cupon.rdlc";
            CargarInterfazBuena();
        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarBotonPersonalizado(btnVolver);
        }

        private void GeneradorDeCupones_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

       

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {


            //var i = new ModelImpresionCuponSocio[] { adh, a,b, adh2, a2, b2 };

            ReportDataSource dt1 = new ReportDataSource("database", MiModelos1);
            ReportDataSource dt2= new ReportDataSource("database2", MiModelos2);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dt1);
            reportViewer1.LocalReport.DataSources.Add(dt2);

            reportViewer1.RefreshReport();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
