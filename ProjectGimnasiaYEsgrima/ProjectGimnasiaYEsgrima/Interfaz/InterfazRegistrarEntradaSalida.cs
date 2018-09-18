using ProjectGimnasiaYEsgrima.Controlador;
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
    public partial class InterfazRegistrarEntradaSalida : Form
    {
        public InterfazRegistrarEntradaSalida()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControladorEntradaSalida CEntradaSalida = new ControladorEntradaSalida();
        }
    }
}
