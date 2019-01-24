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
    public partial class InterfazFiltroReporte : Form
    {
        InterfazPrincipal MiVentana;
        public InterfazFiltroReporte(InterfazPrincipal ventana)
        {
            MiVentana = ventana;
            InitializeComponent();
            CargarInterfazBuena();
        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloReportes);
            interfaz.TransformarBotonPersonalizadoTodos(btnCursosReportes, btnDeportesReportes, btnEmpleadosReportes, btnIngresosReportes, btnSociosReportes,btnVolver);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirOtraVentana<InterfazSociosReporte>(new InterfazSociosReporte(this));
            //new InterfazSociosReporte(this).ShowDialog();
        }

        private void InterfazFiltroReporte_FormClosing(object sender, FormClosingEventArgs e)
        {
            MiVentana.CargarLogin();
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirOtraVentana<InterfazEmpleadosReporte>(new InterfazEmpleadosReporte(this));
            //new InterfazEmpleadosReporte(this).ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirOtraVentana<InterfazDeporteReporte>(new InterfazDeporteReporte(this));
            //new InterfazDeporteReporte(this).ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirOtraVentana<InterfazCursoReporte>(new InterfazCursoReporte(this));
            //new InterfazCursoReporte(this).ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirOtraVentana<InterfazIngresosReporte>(new InterfazIngresosReporte(this));
            //new InterfazIngresosReporte(this).ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MiVentana.CargarLogin();
            Dispose();
        }

        private void AbrirOtraVentana<T>(Object Formhijo)
        {

            Form fh = MiVentana.VentanaContenedor.Controls.OfType<T>().FirstOrDefault() as Form;
            if (fh != null)
            {
                //Si la instancia esta minimizada la dejamos en su estado normal
                if (fh.WindowState == FormWindowState.Minimized)
                {
                    fh.WindowState = FormWindowState.Normal;
                }
                //Si la instancia existe la pongo en primer plano
                fh.BringToFront();
                return;
            }

            fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            MiVentana.VentanaContenedor.Controls.Add(fh);
            MiVentana.VentanaContenedor.Tag = fh;
            fh.Show();
            AbrirOtraVentana<T>(fh);
        }
    }
}
