
using System;

using System.Linq;

using System.Windows.Forms;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    public partial class InterfazPrincipal : Form
    {
        InterfazInicioSesion inicio;
        public InterfazPrincipal()
        {
            
            InitializeComponent();
            inicio = new InterfazInicioSesion(this);
            this.Opacity = .96;
            CargarLogin();
        }

        public void CargarLogin()
        {
            AbrirOtraVentana(inicio);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 250)
            {
                panel1.Width = 90;
            }
            else
            {
                panel1.Width = 250;
            }
        }

        private void AbrirOtraVentana(Object Formhijo)
        {
            foreach(var i in VentanaContenedor.Controls.OfType<Form>()) {
                VentanaContenedor.Controls.Remove(i);
            }

            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.VentanaContenedor.Controls.Add(fh);
            this.VentanaContenedor.Tag = fh;
            fh.Show();
        }

        private void btnDeportes_Click(object sender, EventArgs e)
        {
            if(InterfazInicioSesion.logueado)
                AbrirOtraVentana(new InterfazListaDeportes(this));
            else
                CargarLogin();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            if (InterfazInicioSesion.logueado)
                AbrirOtraVentana(new InterfazListaCurso(this));
            else
                CargarLogin();
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            if (InterfazInicioSesion.logueado)
                AbrirOtraVentana(new InterfazListaSocio(this));
            else
                CargarLogin();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if (InterfazInicioSesion.logueado)
                AbrirOtraVentana(new InterfazListaEmpleado(this));
            else
                CargarLogin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirOtraVentana(new InterfazEntradaSalida(this));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (InterfazInicioSesion.logueado)
                AbrirOtraVentana(new InterfazConfiguracion(this));
            else
                CargarLogin();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            if (InterfazInicioSesion.logueado && InterfazInicioSesion.MiEmpleado.TipoEmpleado == Modelo.EnumTipoEmpleado.Directivo)
                AbrirOtraVentana(new InterfazFiltroReporte(this));
            else
                CargarLogin();
        }
    }
}
