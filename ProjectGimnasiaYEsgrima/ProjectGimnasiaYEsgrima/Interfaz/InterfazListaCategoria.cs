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
    public partial class InterfazListaCategoria : Form
    {
        InterfazPrincipal MiVentana;
        public InterfazListaCategoria(InterfazPrincipal ventana)
        {
            MiVentana = ventana;
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
            interfaz.TransformarBotonPersonalizadoTodos(btnBuscarCategoria, btnCrearCategoria, btnVolver);
            interfaz.TransformarTablaPersonalizado(dtvListarCategorias);
            interfaz.TransformarTablaBotonesPersonalizadosTodos(Modificar, Eliminar,AgregarProfesor);
            

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

        private void BotonCrearCategoria_Click(object sender, EventArgs e)
        {
            if(new ControladorDeporte().ListarTodosDeportes().Count == 0)
            {
                MyMessageBox.Show(this, "Debe existir algún Deporte activo", "No hay deportes");
                return;
            }
            AbrirOtraVentana<InterfazAltaCategoria>(new InterfazAltaCategoria(this));
            if (dtvListarCategorias.Visible)
                BotonBuscarCategoria_Click(sender, e);
        }

        private void DataGridListarCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtvListarCategorias.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {
                ModelCategoria seleccionado = (ModelCategoria)dtvListarCategorias.CurrentRow.DataBoundItem;
                AbrirOtraVentana<InterfazModificarCategoria>(new InterfazModificarCategoria(this, (ModelCategoria)dtvListarCategorias.CurrentRow.DataBoundItem));
                BotonBuscarCategoria_Click(sender, e);
            }

            else if (dtvListarCategorias.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                if (MyMessageBox.Show("¿Está seguro que desea eliminar esta Categoría?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ControladorCategoria controladorCategoria = new ControladorCategoria();
                    if (controladorCategoria.EliminarCategoria(((ModelCategoria)dtvListarCategorias.CurrentRow.DataBoundItem).MiCategoria) > 0)
                    {
                        this.ModificarMensaje("La CATEGORÍA ha sido eliminado con ÉXITO");
                        dtvListarCategorias.DataSource = controladorCategoria.ListarTodosCategoriasFiltro(txtNombreCategoria.Text.ToString(), ((ModelDeporte)cbxDeporteCategoria.SelectedItem).MiDeporte);
                    }
                }

            }
            else if (dtvListarCategorias.Columns[e.ColumnIndex].Name.Equals("AgregarProfesor"))
            {
                if(new ControladorEmpleado().ListarTodosEmpleadosPorFiltro("", "", "", "Profesor").Count == 0)
                {
                    MyMessageBox.Show(this, "Debe existir algún Profesor activo", "No hay profesores");
                    return;
                }
                AbrirOtraVentana<InterfazAgregarCategoriaEmpleado>(new InterfazAgregarCategoriaEmpleado(this, ((ModelCategoria)dtvListarCategorias.CurrentRow.DataBoundItem).MiCategoria));
                BotonBuscarCategoria_Click(sender, e);
            }
            
        }

        public void ModificarMensaje(string v)
        {
            lblInfoCategoria.Text = v;
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

        private void InterfazListaCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            MiVentana.CargarLogin();
            Dispose();
        }

        private void InterfazListaCategoria_Load(object sender, EventArgs e)
        {

        }

        private void lblInfoCategoria_Click(object sender, EventArgs e)
        {

        }
    }
}
