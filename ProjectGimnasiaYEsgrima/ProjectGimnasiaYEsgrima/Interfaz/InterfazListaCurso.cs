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
    public partial class InterfazListaCurso : Form
    {
        InterfazPrincipal MiVentana;
        public InterfazListaCurso(InterfazPrincipal ventana)
        {
            MiVentana = ventana;
            InitializeComponent();
            
            dtvListarCursos.AllowUserToAddRows = false;
            dtvListarCursos.Visible = false;
            lblInfoCurso.Text = "";

            ControladorDeporte Cdeporte = new ControladorDeporte();
            List<ModelDeporte> lista = new List<ModelDeporte>();
            lista = Cdeporte.ListarTodosDeportes();
            lista.Insert(0, new ModelDeporte() { IdDeporte = 0, Nombre = "Seleccione un deporte" });
            cbxDeporteCurso.DataSource = lista;
            cbxDeporteCurso.ValueMember = "IdDeporte";
            cbxDeporteCurso.DisplayMember = "Nombre";

            this.cursoBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.ModelCurso);
            
            CargarCamposFocus();
            CargarInterfazBuena();
        }


        private void CargarCamposFocus()
        {
            txtNombreCurso.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnBuscarCurso);
            txtNombreCurso.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, txtNombreCurso, 50);
        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloCurso);
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblDeporteCurso, lblNombreCurso, lblInfoCurso);
            interfaz.TransformarTextBoxTextoPersonalizadoTodos(txtNombreCurso);
            interfaz.TransformarComboBoxPersonalizado(cbxDeporteCurso);
            interfaz.TransformarBotonPersonalizadoTodos(btnBuscarCurso, btnCrearCurso, btnVolver);
            interfaz.TransformarTablaPersonalizado(dtvListarCursos);
            interfaz.TransformarTablaBotonesPersonalizadosTodos(Modificar, Eliminar,AgregarProfesor);
            

        }

        private void BotonBuscarCurso_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        public void Actualizar()
        {
            ControladorCurso controladorCurso = new ControladorCurso();
            List<ModelCurso> listaCurso = null;
            cursoBindingSource.Clear();

            if (txtNombreCurso.Text.ToString().Equals("") && ((ModelDeporte)cbxDeporteCurso.SelectedItem).IdDeporte == 0)
            {
                listaCurso = controladorCurso.ListarTodosCursos();
            }
            else
            {
                listaCurso = controladorCurso.ListarTodosCursosFiltro(txtNombreCurso.Text.ToString(), ((ModelDeporte)cbxDeporteCurso.SelectedItem).MiDeporte);
            }

            if (listaCurso.Count == 0)
            {
                ModificarMensaje("No hay ningún curso con estos filtros");
                return;
            }
            else if (lblInfoCurso.Text.Equals("No hay ningún curso con estos filtros"))
            {
                ModificarMensaje("");
            }
            dtvListarCursos.DataSource = listaCurso;

            dtvListarCursos.Visible = true;
        }

        private void BotonCrearCurso_Click(object sender, EventArgs e)
        {
            AbrirOtraVentana<InterfazAltaCurso>(new InterfazAltaCurso(this));
            if (dtvListarCursos.Visible)
                BotonBuscarCurso_Click(sender, e);
        }

        private void DataGridListarCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtvListarCursos.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {
                ModelCurso seleccionado = (ModelCurso)dtvListarCursos.CurrentRow.DataBoundItem;
                AbrirOtraVentana<InterfazModificarCurso>(new InterfazModificarCurso(this, (ModelCurso)dtvListarCursos.CurrentRow.DataBoundItem));
                BotonBuscarCurso_Click(sender, e);
            }

            else if (dtvListarCursos.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                if (MyMessageBox.Show("¿Está seguro que desea eliminar este Curso?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ControladorCurso controladorCurso = new ControladorCurso();
                    if (controladorCurso.EliminarCurso(((ModelCurso)dtvListarCursos.CurrentRow.DataBoundItem).Curso) > 0)
                    {
                        this.ModificarMensaje("El CURSO ha sido eliminado con ÉXITO");
                        dtvListarCursos.DataSource = controladorCurso.ListarTodosCursosFiltro(txtNombreCurso.Text.ToString(), ((ModelDeporte)cbxDeporteCurso.SelectedItem).MiDeporte);
                    }
                }

            }
            else if (dtvListarCursos.Columns[e.ColumnIndex].Name.Equals("AgregarProfesor"))
            {
                AbrirOtraVentana<InterfazAgregarCursoEmpleado>(new InterfazAgregarCursoEmpleado(this, ((ModelCurso)dtvListarCursos.CurrentRow.DataBoundItem).Curso));
                BotonBuscarCurso_Click(sender, e);
            }
            
        }

        public void ModificarMensaje(string v)
        {
            lblInfoCurso.Text = v;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            MiVentana.CargarLogin();
            Dispose();
        }

        private void AbrirOtraVentana<T>(Object Formhijo)
        {

            Form fh = MiVentana.VentanaContenedor.Controls.OfType<T>().FirstOrDefault() as Form;
            if (fh != null)
            {
                //Si la instancia esta minimizada la dejamos en su estado normal
                if (fh.WindowState == FormWindowState.Minimized)
                {
                    fh.WindowState = FormWindowState.Normal;
                }
                //Si la instancia existe la pongo en primer plano
                fh.BringToFront();
                return;
            }

            fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            MiVentana.VentanaContenedor.Controls.Add(fh);
            MiVentana.VentanaContenedor.Tag = fh;
            fh.Show();
            AbrirOtraVentana<T>(fh);
        }

        private void InterfazListaCurso_FormClosing(object sender, FormClosingEventArgs e)
        {
            MiVentana.CargarLogin();
            Dispose();
        }

        private void InterfazListaCurso_Load(object sender, EventArgs e)
        {

        }
    }
}
