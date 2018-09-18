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
    public partial class InterfazPrincipal : Form
    {
        public InterfazPrincipal()
        {
            InitializeComponent();
        }

        private void buttonDeportes_Click(object sender, EventArgs e)
        {
            Form interfaz = new InterfazListaDeportes();
            interfaz.Show();
        }

        private void buttonCursos_Click(object sender, EventArgs e)
        {
            Form interfaz = new InterfazListarCurso();
            interfaz.Show();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form interfaz = new InterfazListaEmpleado();
            interfaz.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form interfaz = new InterfazRegistrarEntradaSalida();
            interfaz.Show();
        }
    }
}
