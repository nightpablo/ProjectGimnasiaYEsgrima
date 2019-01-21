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
    public partial class InterfazCursoReporte : Form
    {
        InterfazFiltroReporte MiVentana;
        public InterfazCursoReporte(InterfazFiltroReporte ventana)
        {
            MiVentana = ventana;
            InitializeComponent();
            cbdBaja.Checked = true;
            cxbActivo.Checked = true;
            cxbCancelado.Checked = true;
            cxbInciado.Checked = true;
            cxbPendiente.Checked = true;
            cxbTerminado.Checked = true;

            ControladorDeporte CDeporte = new ControladorDeporte();

            List<ModelDeporte> lista = new List<ModelDeporte>();
            lista = CDeporte.ListarTodosDeportes();
            comboBox1.DataSource = lista;
              lista.Insert(0, new ModelDeporte() { IdDeporte = 0, Nombre = "Seleccione un deporte" });
            comboBox1.ValueMember = "IdDeporte";
            comboBox1.DisplayMember = "Nombre";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControladorCurso CCurso = new ControladorCurso();
            List<ModelCurso> lista = null;
            lista = CCurso.BuscarCursosTodos()

                .ToList();

            ReportDataSource dt = new ReportDataSource("DataSet1", lista);
            string dir = "ProjectGimnasiaYEsgrima.Utils.ReporteTodosCurso.rdlc";

            new InterfazGenerarReporte(dt, dir).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //comboBox1.SelectedIndex == 0 ? true : comboBox1
        }
    }
}
