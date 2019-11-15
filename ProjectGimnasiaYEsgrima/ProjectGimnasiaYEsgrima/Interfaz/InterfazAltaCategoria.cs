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
    public partial class InterfazAltaCategoria : Form
    {
        private InterfazListaCategoria Padre;

        public InterfazAltaCategoria(InterfazListaCategoria interfazListaCategoria)
        {
            this.Padre = interfazListaCategoria;
            InitializeComponent();
            
            ControladorDeporte Cdeporte = new ControladorDeporte();
            List<ModelDeporte> lista = new List<ModelDeporte>();
            lista = Cdeporte.ListarTodosDeportes();

            cbxDeporte.DataSource = lista;
            cbxDeporte.ValueMember = "IdDeporte";
            cbxDeporte.DisplayMember = "Nombre";

            CargarCamposFocus();
            CargarInterfazBuena();

            
        }

        private void CargarCamposFocus()
        {
            txtNombreCategoria.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtImporteMensualCategoria);
            txtImporteMensualCategoria.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnGuardarCategoria);
            dtpInicioCategoria.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnGuardarCategoria);
            dtpFinCategoria.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnGuardarCategoria);

            txtNombreCategoria.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, txtNombreCategoria, 50);
            txtImporteMensualCategoria.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumerosYLimitador(sender, e, txtImporteMensualCategoria,9);

        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloCategoria);
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblDeporteCategoria, lblNombreCategoria, lblFechaInicioCategoria, lblFechaFinCategoria, lblImporteMensualCategoria);
            interfaz.TransformarTextBoxTextoPersonalizadoTodos(txtNombreCategoria, txtImporteMensualCategoria);
            interfaz.TransformarComboBoxPersonalizado(cbxDeporte);
            interfaz.TransformarDateTimePickerPersonalizado(dtpInicioCategoria);
            interfaz.TransformarDateTimePickerPersonalizado(dtpFinCategoria);
            interfaz.TransformarBotonPersonalizadoTodos(btnGuardarCategoria, btnCancelarCategoria);
        }

        private void BotonGuardarCategoria_Click(object sender, EventArgs e)
        {
            var hayError = false;
            if (txtNombreCategoria.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(txtNombreCategoria, "El nombre de la categoría debe contener entre 3 y 50 caracteres");
            }
            else errorProvider1.SetError(txtNombreCategoria, "");
            if (dtpFinCategoria.Value.CompareTo(dtpInicioCategoria.Value) < 1)
            {
                hayError = true;
                errorProvider1.SetError(dtpInicioCategoria, "El día de inicio de una categoría no debe ser mayor al día de fin la misma");
                errorProvider1.SetError(dtpFinCategoria, "El día de fin de una categoria no debe ser menor al día inicio de la misma");
            }
            else { errorProvider1.SetError(dtpInicioCategoria, ""); errorProvider1.SetError(dtpFinCategoria, ""); }
            if(txtImporteMensualCategoria.Text=="" || long.Parse(txtImporteMensualCategoria.Text)>Int32.MaxValue || long.Parse(txtImporteMensualCategoria.Text) < Int32.MinValue)
            {
                hayError = true;
                errorProvider1.SetError(txtImporteMensualCategoria, "El importe mensual de la categoría es un número demasiado grande");
            }
            else if (txtImporteMensualCategoria.Text.Equals("") || Int32.Parse(txtImporteMensualCategoria.Text) == 0)
            {
                hayError = true;
                errorProvider1.SetError(txtImporteMensualCategoria, "El importe mensual categoría debe ser un número mayor a cero");
            }
            else errorProvider1.SetError(txtImporteMensualCategoria, ""); 
            if (hayError)
                return;
            
            ControladorCategoria un_controlador_Categoria = new ControladorCategoria();
            var resultado =un_controlador_Categoria.CrearCategoria(txtNombreCategoria.Text, Int32.Parse(txtImporteMensualCategoria.Text), dtpInicioCategoria.Value, dtpFinCategoria.Value, ((ModelDeporte)cbxDeporte.SelectedItem).MiDeporte);
            if (resultado > 0)
            {
                
                Padre.ModificarMensaje("La Categoría ha sido creado con ÉXITO");
                Padre.Actualizar();
                Dispose();
            }
            else if (resultado == -1)
            {
                Padre.ModificarMensaje("La Categoría ha sido recuperada con ÉXITO");
                Padre.Actualizar();
                Dispose();
            }
            else if (resultado == -2)
                MyMessageBox.Show(this, "Ya existe el nombre de la Categoría, intente con otro número", "Categoría");

        }

        private void ComboBoxDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BotonCancelarCategoria_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
    
}
