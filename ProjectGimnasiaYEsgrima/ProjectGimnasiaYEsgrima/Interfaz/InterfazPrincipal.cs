
using System;

using System.Linq;

using System.Windows.Forms;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    public partial class InterfazPrincipal : Form
    {
        public InterfazPrincipal()
        {
            
            InitializeComponent();
            
            this.Opacity = .96;
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
            AbrirOtraVentana(new InterfazListaDeportes(this));
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            AbrirOtraVentana(new InterfazListaCurso(this));
        }

        private void btnSocios_Click(object sender, EventArgs e)
        {
            AbrirOtraVentana(new InterfazListaSocio(this));
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirOtraVentana(new InterfazListaEmpleado(this));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirOtraVentana(new InterfazEntradaSalida(this));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirOtraVentana(new InterfazConfiguracion(this));
        }
    }
}
