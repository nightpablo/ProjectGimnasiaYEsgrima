using Microsoft.Reporting.WinForms;
using ProjectGimnasiaYEsgrima.Controlador;
using ProjectGimnasiaYEsgrima.Modelo;
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
    public partial class InterfazEmpleadosReporte : Form
    {
        InterfazFiltroReporte MiVentana;
        public InterfazEmpleadosReporte(InterfazFiltroReporte ventana)
        {
            MiVentana = ventana;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControladorEmpleado CEmpleado = new ControladorEmpleado();
            List<ModelEmpleadoPersona> lista = null;
            lista = CEmpleado.ExtraerEmpleadosAVista()
                .AsEnumerable()
                .OrderBy(b => b.Apellido)
                .ToList();

            ReportDataSource dt = new ReportDataSource("DataSet1", lista);
            string dir = "ProjectGimnasiaYEsgrima.Utils.AlfabeticoEmpleado.rdlc";

            new InterfazGenerarReporte(dt, dir).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             ControladorEmpleado CEmpleado = new ControladorEmpleado();
            List<ModelEmpleadoPersona> lista = null;
            if (cbxDirectivo.Checked && cbxSecretaria.Checked && cbxProfesor.Checked && cbxMantenimiento.Checked)
            {
                lista = CEmpleado.TraerEmpleadoReporte();
            }
            else
            {
                /*lista = CEmpleado.TraerSocioReporte()
                    .AsEnumerable()
                    .Where(b=>(cbxActivo.Checked? true: b.CategoriaSocio!=EnumCategoriaSocio.Activo))
                    .Where(b => (cbxAdherente.Checked ? true : b.CategoriaSocio != EnumCategoriaSocio.Adherente))
                    .Where(b => (cbxMenor.Checked ? true : b.CategoriaSocio != EnumCategoriaSocio.Menor))
                    .Where(b => (cbxVitalicio.Checked ? true : b.CategoriaSocio != EnumCategoriaSocio.Vitalicio))
                    
                    .ToList()
                     ;*/
            }
            
            ReportDataSource dt = new ReportDataSource("DataSet1", lista);
            string dir = "ProjectGimnasiaYEsgrima.Utils.ReporteEmpleado.rdlc";

            new InterfazGenerarReporte(dt, dir).ShowDialog();
        }
    }
}
