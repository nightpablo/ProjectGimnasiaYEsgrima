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
    public partial class InterfazInscribirSocioCategoria : Form
    {

        InterfazListaSocio Padre;
        ModelSocioPersona MiSocio;
        public InterfazInscribirSocioCategoria(InterfazListaSocio ventana, ModelSocioPersona socio)
        {
            Padre = ventana;
            MiSocio = socio;
            InitializeComponent();

            dtvListarCategorias.AllowUserToAddRows = false;
            dtvListarCategorias.Visible = false;
            lblInfoCategoria.Text = "";

            ControladorDeporte Cdeporte = new ControladorDeporte();
            List<ModelDeporte> lista = new List<ModelDeporte>();
            lista = Cdeporte.ListarTodosDeportes();
            lista.Insert(0, new ModelDeporte() { IdDeporte = 0, Nombre = "Seleccione un deporte" });
            cbxDeporteCategoria.DataSource = lista;
            cbxDeporteCategoria.ValueMember = "IdDeporte";
            cbxDeporteCategoria.DisplayMember = "Nombre";

            this.CategoriaBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.ModelCategoria);

            CargarCamposFocus();
            CargarInterfazBuena();
        }

        private void CargarCamposFocus()
        {
            txtNombreCategoria.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnBuscarCategoria);
            txtNombreCategoria.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, txtNombreCategoria, 50);
        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloCategoria);
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblDeporteCategoria, lblNombreCategoria, lblInfoCategoria);
            interfaz.TransformarTextBoxTextoPersonalizadoTodos(txtNombreCategoria);
            interfaz.TransformarComboBoxPersonalizado(cbxDeporteCategoria);
            interfaz.TransformarBotonPersonalizadoTodos(btnBuscarCategoria, btnVolver);
            interfaz.TransformarTablaPersonalizado(dtvListarCategorias);
            interfaz.TransformarTablaBotonesPersonalizadosTodos(Inscribir,Unsuscribir);


        }

        private void BotonBuscarCategoria_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        public void Actualizar()
        {
            ControladorCategoria controladorCategoria = new ControladorCategoria();
            List<ModelCategoria> listaCategoria = null;
            CategoriaBindingSource.Clear();

            if (txtNombreCategoria.Text.ToString().Equals("") && ((ModelDeporte)cbxDeporteCategoria.SelectedItem).IdDeporte == 0)
            {
                listaCategoria = controladorCategoria.ListarTodosCategorias();
            }
            else
            {
                listaCategoria = controladorCategoria.ListarTodosCategoriasFiltro(txtNombreCategoria.Text.ToString(), ((ModelDeporte)cbxDeporteCategoria.SelectedItem).MiDeporte);
            }

            if (listaCategoria.Count == 0)
            {
                ModificarMensaje("NO EXISTE NINGUNA CATEGORIA CON LOS FILTROS SELECCIONADOS");
                return;
            }
            else if (lblInfoCategoria.Text.Equals("NO EXISTE NINGUNA CATEGORIA CON LOS FILTROS SELECCIONADOS"))
            {
                ModificarMensaje("");
            }
            dtvListarCategorias.DataSource = listaCategoria;

            dtvListarCategorias.Visible = true;
        }

        public void ModificarMensaje(string v)
        {
            lblInfoCategoria.Text = v;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dtvListarCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtvListarCategorias.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.Equals("Inscribir"))
            {
                ModelCategoria MiCategoria = (ModelCategoria)dtvListarCategorias.CurrentRow.DataBoundItem;
                if (MyMessageBox.Show("¿Seguro que desea inscribir en la Categoría " + MiCategoria.Nombre + " al Socio " + MiSocio.Apellido + ", " + MiSocio.Nombre + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ControladorCategoria CCategoria = new ControladorCategoria();
                    var resultado = CCategoria.InscribirSocioAlCategoria(MiSocio.MiSocio, MiCategoria.MiCategoria);
                    if (resultado > 0)
                    {
                        Padre.ModificarMensaje("Se ha inscripto al Socio a la Categoría");
                        Dispose();
                    }
                    else if (resultado == -2)
                    {
                        MyMessageBox.Show(this, "Ya esta inscripto el Socio de la Categoría", "Categoria");
                    }
                }
            }
            else if (dtvListarCategorias.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.Equals("Desinscribir"))
            {
                ModelCategoria MiCategoria = (ModelCategoria)dtvListarCategorias.CurrentRow.DataBoundItem;
                if (MyMessageBox.Show("¿Seguro que desea desinscribir en la Categoría " + MiCategoria.Nombre + " al Socio " + MiSocio.Apellido + ", " + MiSocio.Nombre + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ControladorCategoria CCategoria = new ControladorCategoria();
                    var resultado = CCategoria.UnsuscribirSocioAlCategoria(MiSocio.MiSocio, MiCategoria.MiCategoria);
                    if (resultado > 0)
                    {
                        Padre.ModificarMensaje("Se ha desubscripto al Socio de la Categoría");
                        Dispose();
                    }
                    else if (resultado == -2)
                    {
                        MyMessageBox.Show(this, "El Socio no está inscripto de la Categoría", "Categoria");
                    }
                }
            }
        }

        private void dtvListarCategorias_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtvListarCategorias.Columns[e.ColumnIndex].Name.Equals("Inscribir"))
            {

                if (new ControladorCategoria().ExisteSocioEnCategoria(MiSocio.MiSocio, ((ModelCategoria)dtvListarCategorias.Rows[e.RowIndex].DataBoundItem).MiCategoria))
                {
                    e.Value = "";

                }
            }
            else if (dtvListarCategorias.Columns[e.ColumnIndex].Name.Equals("Unsuscribir"))
            {
                if (!new ControladorCategoria().ExisteSocioEnCategoria(MiSocio.MiSocio, ((ModelCategoria)dtvListarCategorias.Rows[e.RowIndex].DataBoundItem).MiCategoria))
                {
                    e.Value = "";
                }
            }
        }
    }
}
