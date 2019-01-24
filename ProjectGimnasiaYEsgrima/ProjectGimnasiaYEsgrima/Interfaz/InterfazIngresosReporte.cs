using Microsoft.Reporting.WinForms;
using ProjectGimnasiaYEsgrima.Controlador;
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
    public partial class InterfazIngresosReporte : Form
    {
        InterfazFiltroReporte MiVentana;
        public InterfazIngresosReporte(InterfazFiltroReporte ventana)
        {
            MiVentana = ventana;
            InitializeComponent();
            this.cbxMes.SelectedIndex = 0;
            this.cbxMesInicio.SelectedIndex = 0;
            this.cbxMesFin.SelectedIndex = 11;

            CargarInterfazBuena();

        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloReporteIngreso);
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblReportePeriodo, lblReporteMensual, lblMesInicio, lblMesFin, lblMes, lblAño2, lblAño1);
            interfaz.TransformarBotonPersonalizadoTodos(btnReporteAnual, btnReporteMensual,btnVolver);
            interfaz.TransformarComboBoxPersonalizado(cbxMes);
            interfaz.TransformarComboBoxPersonalizado(cbxMesInicio);
            interfaz.TransformarComboBoxPersonalizado(cbxMesFin);
            interfaz.TransformarDateTimePickerPersonalizado(dtpAño1);
            interfaz.TransformarDateTimePickerPersonalizado(dtpAño2);

        }


        private void BtnReporteAnual_Click(object sender, EventArgs e)
        {
            ControladorSocio CSocio = new ControladorSocio();
            List<ModelCuponSocio> lista = CSocio.ListarTodasCuotasSocios()
                .AsEnumerable()
                .Where(b => b.Estado == EnumEstadoCuotaSocio.Pagado)
                .Where(b => b.FechaCobro.Value.Year == dtpAño1.Value.Year)
                .Where(b => b.FechaCobro.Value.Month >= cbxMesInicio.SelectedIndex+1)
                .Where(b => b.FechaCobro.Value.Month <= cbxMesFin.SelectedIndex+1)
                .ToList();

            ReportDataSource dt = new ReportDataSource("DataSet1", lista);
            string dir = "ProjectGimnasiaYEsgrima.Utils.ReporteIngreso.rdlc";
            new InterfazGenerarReporte(dt, dir).ShowDialog();
        }

        private void BtnReporteMensual_Click(object sender, EventArgs e)
        {
            ControladorSocio CSocio = new ControladorSocio();
            List<ModelCuponSocio> lista = CSocio.ListarTodasCuotasSocios()
                .AsEnumerable()
                .Where(b => b.Estado == EnumEstadoCuotaSocio.Pagado)
                .Where(b => b.FechaCobro.Value.Year == dtpAño2.Value.Year)
                .Where(b => b.FechaCobro.Value.Month == cbxMes.SelectedIndex+1)
                .ToList();
            ReportDataSource dt = new ReportDataSource("DataSet1", lista);
            string dir = "ProjectGimnasiaYEsgrima.Utils.ReporteIngreso.rdlc";
            new InterfazGenerarReporte(dt, dir).ShowDialog();
        }

        private void cbxMesInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cbxMesInicio.SelectedIndex <= cbxMesFin.SelectedIndex))
            {
                cbxMesInicio.SelectedIndex = cbxMesFin.SelectedIndex;
            }
        }

        private void cbxMesFin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cbxMesInicio.SelectedIndex <= cbxMesFin.SelectedIndex))
            {
                cbxMesFin.SelectedIndex = cbxMesInicio.SelectedIndex;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
