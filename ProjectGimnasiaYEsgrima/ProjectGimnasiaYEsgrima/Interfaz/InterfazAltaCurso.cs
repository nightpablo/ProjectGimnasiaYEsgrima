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
    public partial class InterfazAltaCurso : Form
    {
        public InterfazAltaCurso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BotonGuardarCurso_Click(object sender, EventArgs e)
        {
            

            ControladorCurso un_controlador_curso = new ControladorCurso();

            un_controlador_curso.CrearCurso(txtNombreCurso.Text, DateTimeInicio.Value, DateTimeFin.Value);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
