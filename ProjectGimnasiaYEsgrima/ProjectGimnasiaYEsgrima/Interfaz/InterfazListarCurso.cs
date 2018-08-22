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
    public partial class InterfazListarCurso : Form
    {
        public InterfazListarCurso()
        {
            InitializeComponent();

            DataGridListarCursos.AllowUserToAddRows = false;
            DataGridListarCursos.Visible = false;

            ControladorDeporte Cdeporte = new ControladorDeporte();
            List<Deporte> lista = new List<Deporte>();
            lista = Cdeporte.ListarTodosDeportes();
            lista.Insert(0, new Deporte() { IdDeporte = 0, Nombre = "Seleccione un deporte" });
            comboBoxDeporte.DataSource = lista;
            comboBoxDeporte.ValueMember = "IdDeporte";
            comboBoxDeporte.DisplayMember = "Nombre";



        }

        private void InterfazListarCurso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dbGimnasiaYEsgrimaDataSet.Curso' Puede moverla o quitarla según sea necesario.
            this.cursoTableAdapter.Fill(this.dbGimnasiaYEsgrimaDataSet.Curso);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BotonBuscarCurso_Click(object sender, EventArgs e)
        {
            ControladorCurso controladorCurso = new ControladorCurso();
            List<Curso> listaCurso = null;
            cursoBindingSource.Clear();

            if (txtNombreCurso.Text.ToString().Equals("") && ((Deporte)comboBoxDeporte.SelectedItem).IdDeporte == 0)
            {
                listaCurso = controladorCurso.ListarTodosCursos();
            }
            else
            {
                listaCurso = controladorCurso.ListarTodosCursosFiltro(txtNombreCurso.Text.ToString(), ((Deporte)comboBoxDeporte.SelectedItem).IdDeporte);
            }

            foreach (var i in listaCurso)
            {
                cursoBindingSource.Add(i);

            }

            DataGridListarCursos.Visible = true;

        }

        private void TextBoxCurso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void botonCrearCurso_Click(object sender, EventArgs e)
        {
            InterfazAltaCurso interfazCurso = new InterfazAltaCurso(this);
            interfazCurso.ShowDialog();
            if (DataGridListarCursos.Visible)
                BotonBuscarCurso_Click(sender, e);
        }

        private void DataGridListarCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridListarCursos.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {
                InterfazModificarCurso interfazModificar = new InterfazModificarCurso(this, (Curso)DataGridListarCursos.CurrentRow.DataBoundItem);
                interfazModificar.ShowDialog();

            }

            else if (DataGridListarCursos.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                if (MessageBox.Show("¿Seguro que desea Eliminar este Curso?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ControladorCurso controladorCurso = new ControladorCurso();
                    if (controladorCurso.EliminarCurso((Curso)DataGridListarCursos.CurrentRow.DataBoundItem) > 0)
                    {
                        //this.ModificarMensaje("Se ha eliminado el DEPORTE");
                        //MessageBox.Show(this, "Se ha eliminado el DEPORTE", "Deporte");
                    }
                }

            }
        }
    }
}
