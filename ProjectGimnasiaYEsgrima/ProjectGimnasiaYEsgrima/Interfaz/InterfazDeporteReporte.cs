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
    public partial class InterfazDeporteReporte : Form
    {
        InterfazFiltroReporte MiVentana;
       

        public InterfazDeporteReporte(InterfazFiltroReporte  ventana)
        {
            MiVentana = ventana;
            InitializeComponent();
            cbxAlta.Checked = true;
            cbxBaja.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControladorDeporte CDeporte = new ControladorDeporte();
            List<ModelDeporte> lista = null;
            lista = CDeporte.ListarTodos()
                .AsEnumerable()
                .OrderBy(b => b.Nombre)
                .ToList();

            ReportDataSource dt = new ReportDataSource("DataSet1", lista);
            string dir = "ProjectGimnasiaYEsgrima.Utils.ReporteTodosDeporte.rdlc";

            new InterfazGenerarReporte(dt, dir).ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControladorDeporte CDeporte = new ControladorDeporte();
            List<ModelDeporte> lista = null;
            if (cbxAlta.Checked && cbxBaja.Checked)
            {
                lista = CDeporte.ListarTodos();
            }
            else
            {
                lista = CDeporte.ListarTodos()
                    .AsEnumerable()
                    .Where(b => (cbxAlta.Checked ? true : b.EstadoDeporte != EnumEstadoDeporte.Activo))
                    .Where(b => (cbxBaja.Checked ? true : b.EstadoDeporte != EnumEstadoDeporte.Baja))
                    .ToList()
                     ;
            }

            ReportDataSource dt = new ReportDataSource("DataSet1", lista);
            string dir = "ProjectGimnasiaYEsgrima.Utils.ReporteTodosDeporte.rdlc";

            new InterfazGenerarReporte(dt, dir).ShowDialog();

        }
    }
}