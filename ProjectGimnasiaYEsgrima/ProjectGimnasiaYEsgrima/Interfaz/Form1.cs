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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new InterfazListarCurso() { TopLevel = false, AutoScroll = true , FormBorderStyle =FormBorderStyle.None};
            PlanoPantallaPrincipal.Controls.Add(form);
            form.Show();
            PlanoPantallaPrincipal.AutoSize=true;
        }
    }
}
