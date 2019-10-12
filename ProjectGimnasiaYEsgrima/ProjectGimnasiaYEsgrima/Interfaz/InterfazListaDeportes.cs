using ProjectGimnasiaYEsgrima;
using ProjectGimnasiaYEsgrima.Utils;
using ProjectGimnasiaYEsgrima.Controlador;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProjectGimnasiaYEsgrima.Modelo;
using System.Linq;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    public partial class InterfazListaDeportes : Form
    {

        public InterfazPrincipal MiVentana;
        public InterfazListaDeportes(InterfazPrincipal ventana)
        {
            MiVentana = ventana;
            InitializeComponent();

            
            
            dataGridViewDeporte.AllowUserToAddRows = false;
            dataGridViewDeporte.Visible = false;
            
            this.ModificarMensaje("");
            CargarCamposFocus();
            CargarInterfazBuena();
        }


        private void CargarCamposFocus()
        {
            this.txtNombreDeporte.Focus();
            this.txtNombreDeporte.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtDescripcionDeporte);
            this.txtNombreDeporte.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, txtNombreDeporte, 50);
            this.txtDescripcionDeporte.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnBuscar);
            this.txtDescripcionDeporte.KeyPress += (sender, e) => new CampoConRestriccion().Limitador(sender, e, txtDescripcionDeporte, 500);
        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloDeporte);
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblNombreDeporte, lblDescripcionDeporte, lblInfoDeporte);
            interfaz.TransformarTextBoxTextoPersonalizadoTodos(txtNombreDeporte, txtDescripcionDeporte);
            interfaz.TransformarBotonPersonalizadoTodos(btnBuscar, btnCrearDeporte,btnVolver);
            interfaz.TransformarTablaPersonalizado(dataGridViewDeporte);
            interfaz.TransformarTablaBotonesPersonalizadosTodos(Modificar, Eliminar);
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        public void Actualizar() {
            ControladorDeporte controladorDeporte = new ControladorDeporte();
            List<ModelDeporte> lista;
            deporteBindingSource.Clear();

            if (txtNombreDeporte.Text.ToString().Equals("") && txtDescripcionDeporte.Text.ToString().Equals(""))
            {
                lista = controladorDeporte.ListarTodosDeportes();
            }
            else
            {
                lista = controladorDeporte.ListarTodosDeportesPorFiltros(txtNombreDeporte.Text.ToString(), txtDescripcionDeporte.Text.ToString());
            }

            if (lista.Count == 0)
            {
                ModificarMensaje("NO EXISTE NINGÚN DEPORTE CON LOS FILTROS SELECCIONADOS");
                return;
            }
            else if (lblInfoDeporte.Text.Equals("NO EXISTE NINGÚN DEPORTE CON LOS FILTROS SELECCIONADOS"))
            {
                ModificarMensaje("");
            }
            dataGridViewDeporte.DataSource = lista;



            dataGridViewDeporte.Visible = true;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDeporte.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {
                AbrirOtraVentana<InterfazModificarDeporte>(new InterfazModificarDeporte(this, ((ModelDeporte)dataGridViewDeporte.CurrentRow.DataBoundItem).MiDeporte));
                Button1_Click(sender, e);
            }

            else if (dataGridViewDeporte.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                if(MyMessageBox.Show("¿Está seguro que desea eliminar este Deporte?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    var resultado = new ControladorDeporte().EliminarDeporte(((ModelDeporte)dataGridViewDeporte.CurrentRow.DataBoundItem).MiDeporte);
                    if (resultado > 0)
                    {
                        ModificarMensaje("El DEPORTE ha sido eliminado con ÉXITO");
                        dataGridViewDeporte.DataSource = new ControladorDeporte().ListarTodosDeportesPorFiltros(txtNombreDeporte.Text.ToString(), txtDescripcionDeporte.Text.ToString());
                    }
                }
            }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AbrirOtraVentana<InterfazAltaDeporte>(new InterfazAltaDeporte(this));
            if (dataGridViewDeporte.Visible)
                Button1_Click(sender, e);
        }
        
        public void ModificarMensaje(String entrada)
        {
            lblInfoDeporte.Text = entrada;
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

        private void BtnVolver_Click(object sender, FormClosingEventArgs e)
        {
            MiVentana.CargarLogin();
            Dispose();
        }
    }
}
