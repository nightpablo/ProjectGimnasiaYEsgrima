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
            string nombre = txtNombreCurso.Text;
            string fechaInicio = FechaInicioCurso.SelectionRange.Start.ToString("dd/MM/yyyy");
            string fechaFin = FechaFinCurso.SelectionRange.Start.ToString("dd/MM/yyyy");

            ControladorCurso un_controlador_curso = new ControladorCurso();

            un_controlador_curso.CrearCurso(nombre, fechaInicio, fechaFin);

        }
    }
}
