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
    public partial class InterfazSociosReporte : Form
    {
        InterfazFiltroReporte MiVentana;
        public InterfazSociosReporte(InterfazFiltroReporte ventana)
        {
            MiVentana = ventana;
            InitializeComponent();
            cbxActivo.Checked = true;
            cbxAdherente.Checked = true;
            cbxMenor.Checked = true;
            cbxVitalicio.Checked = true;
            CargarInterfazBuena();
        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloReporteSocios);
            interfaz.TransformarLabelTextoPersonalizado(lblTipoSocio);
            interfaz.TransformarBotonPersonalizadoTodos(btnReporteAlfabetico, btnReporteFiltro, btnVolver);
            interfaz.TransformarCheckBoxPersonalizado(cbxActivo);
            interfaz.TransformarCheckBoxPersonalizado(cbxAdherente);
            interfaz.TransformarCheckBoxPersonalizado(cbxMenor);
            interfaz.TransformarCheckBoxPersonalizado(cbxVitalicio);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ControladorSocio CSocio = new ControladorSocio();
            List<ModelSocioPersona> lista = null;
            if (cbxActivo.Checked && cbxAdherente.Checked && cbxMenor.Checked && cbxVitalicio.Checked)
            {
                lista = CSocio.TraerSocioReporte();
            }
            else
            {
                lista = CSocio.TraerSocioReporte()
                    .AsEnumerable()
                    .Where(b=>(cbxActivo.Checked? true: b.CategoriaSocio!=EnumCategoriaSocio.Activo))
                    .Where(b => (cbxAdherente.Checked ? true : b.CategoriaSocio != EnumCategoriaSocio.Adherente))
                    .Where(b => (cbxMenor.Checked ? true : b.CategoriaSocio != EnumCategoriaSocio.Menor))
                    .Where(b => (cbxVitalicio.Checked ? true : b.CategoriaSocio != EnumCategoriaSocio.Vitalicio))
                    
                    .ToList()
                     ;
            }
            
            ReportDataSource dt = new ReportDataSource("DataSet1", lista);
            string dir = "ProjectGimnasiaYEsgrima.Utils.ReporteSocio.rdlc";

            new InterfazGenerarReporte(dt, dir).ShowDialog();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            ControladorSocio CSocio = new ControladorSocio();
            List<ModelSocioPersona> lista = null;
            lista = CSocio.ExtraerSociosAVista()
                .AsEnumerable()
                .OrderBy(b => b.Apellido)
                .ToList();

            ReportDataSource dt = new ReportDataSource("DataSet1", lista);
            string dir = "ProjectGimnasiaYEsgrima.Utils.AlfabeticoSocio.rdlc";

            new InterfazGenerarReporte(dt, dir).ShowDialog();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        
    }
}
