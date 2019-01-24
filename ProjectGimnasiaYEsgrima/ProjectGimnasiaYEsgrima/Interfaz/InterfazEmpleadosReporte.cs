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
    public partial class InterfazEmpleadosReporte : Form
    {
        InterfazFiltroReporte MiVentana;
        public InterfazEmpleadosReporte(InterfazFiltroReporte ventana)
        {
            MiVentana = ventana;
            InitializeComponent();
            cbxDirectivo.Checked = true;
            cbxProfesor.Checked = true;
            cbxSecretaria.Checked = true;
            cbxMantenimiento.Checked = true;
            CargarInterfazBuena();
        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloReporteEmpleado);
            interfaz.TransformarLabelTextoPersonalizado(lblTipoEmpleado);
            interfaz.TransformarBotonPersonalizadoTodos(btnReporteAlfabetico, btnReporteFiltro, btnVolver);
            interfaz.TransformarCheckBoxPersonalizado(cbxDirectivo);
            interfaz.TransformarCheckBoxPersonalizado(cbxMantenimiento);
            interfaz.TransformarCheckBoxPersonalizado(cbxProfesor);
            interfaz.TransformarCheckBoxPersonalizado(cbxSecretaria);
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
            string dir = "ProjectGimnasiaYEsgrima.Utils.ReporteTodosDeporte.rdlc";

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
                lista = CEmpleado.TraerEmpleadoReporte()
                    .AsEnumerable()
                    .Where(b=>(cbxDirectivo.Checked? true: b.TipoEmpleado!=EnumTipoEmpleado.Directivo))
                    .Where(b => (cbxMantenimiento.Checked ? true : b.TipoEmpleado != EnumTipoEmpleado.Mantenimiento))
                    .Where(b => (cbxProfesor.Checked ? true : b.TipoEmpleado != EnumTipoEmpleado.Profesor))
                    .Where(b => (cbxSecretaria.Checked ? true : b.TipoEmpleado != EnumTipoEmpleado.Secretaria))
                    
                    .ToList()
                     ;
            }
            
            ReportDataSource dt = new ReportDataSource("DataSet1", lista);
            string dir = "ProjectGimnasiaYEsgrima.Utils.ReporteEmpleado.rdlc";

            new InterfazGenerarReporte(dt, dir).ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
