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
    public partial class InterfazInscribirSocioCurso : Form
    {

        InterfazListaSocio Padre;
        ModelSocioPersona MiSocio;
        public InterfazInscribirSocioCurso(InterfazListaSocio ventana, ModelSocioPersona socio)
        {
            Padre = ventana;
            MiSocio = socio;
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
            interfaz.TransformarBotonPersonalizadoTodos(btnBuscarCurso, btnVolver);
            interfaz.TransformarTablaPersonalizado(dtvListarCursos);
            interfaz.TransformarTablaBotonesPersonalizadosTodos(Inscribir,Unsuscribir);


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

        public void ModificarMensaje(string v)
        {
            lblInfoCurso.Text = v;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dtvListarCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtvListarCursos.Columns[e.ColumnIndex].Name.Equals("Inscribir"))
            {
                ModelCurso MiCurso = (ModelCurso)dtvListarCursos.CurrentRow.DataBoundItem;
                if (MyMessageBox.Show("¿Seguro que desea inscribir el curso " + MiCurso.Nombre + " al Socio " + MiSocio.Apellido + ", " + MiSocio.Nombre + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ControladorCurso CCurso = new ControladorCurso();
                    var resultado = CCurso.InscribirSocioAlCurso(MiSocio.MiSocio, MiCurso.Curso);
                    if (resultado > 0)
                    {
                        Padre.ModificarMensaje("Se ha inscripto al Socio en el CURSO");
                        Dispose();
                    }
                    else if (resultado == -2)
                    {
                        MyMessageBox.Show(this, "Ya esta inscripto el Socio al CURSO", "Curso");
                    }
                }
            }
            else if (dtvListarCursos.Columns[e.ColumnIndex].Name.Equals("Unsuscribir"))
            {
                ModelCurso MiCurso = (ModelCurso)dtvListarCursos.CurrentRow.DataBoundItem;
                if (MyMessageBox.Show("¿Seguro que desea unsuscribir el curso " + MiCurso.Nombre + " al Socio " + MiSocio.Apellido + ", " + MiSocio.Nombre + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ControladorCurso CCurso = new ControladorCurso();
                    var resultado = CCurso.UnsuscribirSocioAlCurso(MiSocio.MiSocio, MiCurso.Curso);
                    if (resultado > 0)
                    {
                        Padre.ModificarMensaje("Se ha unsuscripto al Socio del CURSO");
                        Dispose();
                    }
                    else if (resultado == -2)
                    {
                        MyMessageBox.Show(this, "El Socio no está inscripto en el CURSO", "Curso");
                    }
                }
            }
        }
    }
}
