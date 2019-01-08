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
    public partial class Ventana : Form
    {
        public Ventana()
        {
            
            InitializeComponent();
            //this.button1.Image = (Image)(new Bitmap(global::PruebasDeInterfaces.Properties.Resources.Mobile_Menu_Icon, new Size(32, 32)));
            // this.panel2.BackgroundImage = (Image)(new Bitmap(global::PruebasDeInterfaces.Properties.Resources.EscudoGimnasiaYEsgrima, new Size(80, 80)));
            //this.btnDeportes.Image = (Image)(new Bitmap(global::PruebasDeInterfaces.Properties.Resources.Pelota, new Size(32, 32)));
            // this.btnCursos.Image = (Image)(new Bitmap(global::PruebasDeInterfaces.Properties.Resources.Pizarra, new Size(32, 32)));
            // this.btnSocios.Image = (Image)(new Bitmap(global::PruebasDeInterfaces.Properties.Resources.Socios, new Size(32, 32)));
            //  this.btnEmpleados.Image = (Image)(new Bitmap(global::PruebasDeInterfaces.Properties.Resources.Empleados, new Size(32, 32)));
            //  this.btnReportes.Image = (Image)(new Bitmap(global::PruebasDeInterfaces.Properties.Resources.Reportes, new Size(32, 32)));
            // this.VentanaContenedor.BackColor = Color.FromArgb(39, 57, 80);

            //            this.panel3.BackColor = Color.FromArgb(50, 39, 57, 80);
            //this.panel3.BackColor = Color.Transparent;
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
    }
}
