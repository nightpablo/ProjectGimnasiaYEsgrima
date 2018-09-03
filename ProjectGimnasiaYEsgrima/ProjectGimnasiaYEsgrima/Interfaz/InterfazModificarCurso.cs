using ProjectGimnasiaYEsgrima.Controlador;
using ProjectGimnasiaYEsgrima.Modelo;
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
    public partial class InterfazModificarCurso : Form
    {
        private Form padre;
        private Curso curso;
        public InterfazModificarCurso(Form padre, Curso curso)
        {
            this.padre = padre;
            this.curso = curso;
            InitializeComponent();
            txtNombreCurso.Text = curso.Nombre;
            DateTimeInicio.Value = curso.FechaInicio;
            dateTimeFin.Value = curso.FechaInicio;


            ControladorDeporte Cdeporte = new ControladorDeporte();
            List<Deporte> lista = new List<Deporte>();
            lista = Cdeporte.ListarTodosDeportes();
            ComboBoxDeporte.DataSource = lista;
            ComboBoxDeporte.ValueMember = "IdDeporte";
            ComboBoxDeporte.DisplayMember = "Nombre";
            ComboBoxDeporte.Focus();
            foreach (Deporte i in ComboBoxDeporte.Items)
            {
                if (i.IdDeporte.Equals(curso.DeporteIdDeporte))
                {
                    ComboBoxDeporte.SelectedItem = i;
                    break;
                }
            }
            //ComboBoxDeporte.SelectedIndex = ComboBoxDeporte.FindString(curso.Deporte.Nombre);
            //(Deporte) Convert.ToInt32(ComboBoxDeporte.SelectedValue) = curso.DeporteIdDeporte;


        }

        private void BotonGuardarCurso_Click(object sender, EventArgs e)
        {
            var hayError = false;
            if (txtNombreCurso.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(txtNombreCurso, "El nombre debe ser con carácter entre 3 y 80");
            }
            else
            {
                errorProvider1.SetError(txtNombreCurso, "");
            }

            if (hayError)
                return;
            string nombre = txtNombreCurso.Text;
            string descripcion = txtNombreCurso.Text;

            ControladorCurso un_controlador_curso = new ControladorCurso();
            var resultado = un_controlador_curso.ModificarCurso(curso.IdCurso,txtNombreCurso.Text, DateTimeInicio.Value, dateTimeFin.Value, Convert.ToInt32(ComboBoxDeporte.SelectedValue));
            if (resultado > 0)
            {
                ((InterfazListarCurso)padre).ModificarMensaje("Se ha modificado el Curso");
                //MessageBox.Show(this, "Se ha creado un nuevo DEPORTE", "Deporte");
                Dispose();
            }
            else if (resultado == -2)
                MessageBox.Show(this, "Ya existe el nombre del CURSO", "Curso");

        }

        private void BotonCancelarCurso_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ComboBoxDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

