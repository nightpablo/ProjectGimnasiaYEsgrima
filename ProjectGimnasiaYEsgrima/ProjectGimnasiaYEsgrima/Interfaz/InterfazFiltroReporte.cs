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
    public partial class InterfazFiltroReporte : Form
    {
        InterfazPrincipal MiVentana;
        public InterfazFiltroReporte(InterfazPrincipal ventana)
        {
            MiVentana = ventana;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new InterfazSociosReporte(this).ShowDialog();
        }

        private void InterfazFiltroReporte_FormClosing(object sender, FormClosingEventArgs e)
        {
            MiVentana.CargarLogin();
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new InterfazEmpleadosReporte(this).ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new InterfazDeporteReporte(this).ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new InterfazCursoReporte(this).ShowDialog();
        }
    }
}
