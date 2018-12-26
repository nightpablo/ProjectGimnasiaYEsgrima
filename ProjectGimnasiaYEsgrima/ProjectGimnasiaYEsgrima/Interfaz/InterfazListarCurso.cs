using ProjectGimnasiaYEsgrima.Controlador;
using ProjectGimnasiaYEsgrima.Modelo;
using ProjectGimnasiaYEsgrima.Utils;
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
            LabelInfoCurso.Text = "";

            ControladorDeporte Cdeporte = new ControladorDeporte();
            List<ModelDeporte> lista = new List<ModelDeporte>();
            lista = Cdeporte.ListarTodosDeportes();
            lista.Insert(0, new ModelDeporte() { IdDeporte = 0, Nombre = "Seleccione un deporte" });
            comboBoxDeporte.DataSource = lista;
            comboBoxDeporte.ValueMember = "IdDeporte";
            comboBoxDeporte.DisplayMember = "Nombre";

            this.cursoBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.ModelCurso);
            txtNombreCurso.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, BotonBuscarCurso);
            txtNombreCurso.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, txtNombreCurso, 50);
        }

        private void BotonBuscarCurso_Click(object sender, EventArgs e)
        {
            ControladorCurso controladorCurso = new ControladorCurso();
            List<ModelCurso> listaCurso = null;
            cursoBindingSource.Clear();

            if (txtNombreCurso.Text.ToString().Equals("") && ((ModelDeporte)comboBoxDeporte.SelectedItem).IdDeporte == 0)
            {
                listaCurso = controladorCurso.ListarTodosCursos();
            }
            else
            {
                listaCurso = controladorCurso.ListarTodosCursosFiltro(txtNombreCurso.Text.ToString(), ((ModelDeporte)comboBoxDeporte.SelectedItem).MiDeporte);
            }

            if (listaCurso.Count == 0)
            {
                ModificarMensaje("No hay ningún curso con estos filtros");
                return;
            }
            else if(LabelInfoCurso.Text.Equals("No hay ningún curso con estos filtros"))
            {
                ModificarMensaje("");
            }
            DataGridListarCursos.DataSource = listaCurso;           

            DataGridListarCursos.Visible = true;

        }

        private void BotonCrearCurso_Click(object sender, EventArgs e)
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
                ModelCurso seleccionado = (ModelCurso)DataGridListarCursos.CurrentRow.DataBoundItem;
                if (seleccionado.EstadoCurso == EnumEstadoCurso.Iniciado) { 
                    this.ModificarMensaje("No se puede modificar un CURSO Iniciado");
                    return;
                }
                InterfazModificarCurso interfazModificar = new InterfazModificarCurso(this, (ModelCurso)DataGridListarCursos.CurrentRow.DataBoundItem);
                interfazModificar.ShowDialog();

            }

            else if (DataGridListarCursos.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                if (MessageBox.Show("¿Seguro que desea Eliminar este Curso?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ControladorCurso controladorCurso = new ControladorCurso();
                    if (controladorCurso.EliminarCurso(((ModelCurso)DataGridListarCursos.CurrentRow.DataBoundItem).Curso) > 0)
                    {
                        this.ModificarMensaje("Se ha eliminado el CURSO");
                    }
                }

            }
            else if (DataGridListarCursos.Columns[e.ColumnIndex].Name.Equals("AgregarProfesor"))
            {
                InterfazAgregarCursoEmpleado interfazAgregar = new InterfazAgregarCursoEmpleado(this, ((ModelCurso)DataGridListarCursos.CurrentRow.DataBoundItem).Curso);
                interfazAgregar.ShowDialog();
            }
            BotonBuscarCurso_Click(sender, e);
        }

        public void ModificarMensaje(string v)
        {
            LabelInfoCurso.Text = v;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
