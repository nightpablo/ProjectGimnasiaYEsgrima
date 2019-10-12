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
    public partial class InterfazModificarCategoria : Form
    {
        private InterfazListaCategoria Padre;
        private ModelCategoria Categoria;
        public InterfazModificarCategoria(InterfazListaCategoria padre, ModelCategoria categoria)
        {
            Padre = padre;
            Categoria = categoria;
            InitializeComponent();
            txtNombreCategoria.Text = Categoria.Nombre;
            dtpInicioCategoria.Value = Categoria.FechaInicio;
            dtpFinCategoria.Value = Categoria.FechaFin;
            txtImporteMensualCategoria.Text = Categoria.MiCategoria.Costo+"";


            ControladorDeporte Cdeporte = new ControladorDeporte();
            List<ModelDeporte> lista = new List<ModelDeporte>();
            lista = Cdeporte.ListarTodosDeportes();

            txtDeporteCategoria.Text = Categoria.Deporte.Nombre;
            txtDeporteCategoria.ReadOnly = true;
            txtNombreCategoria.ReadOnly = true;
            CargarCamposFocus();
            CargarInterfazBuena();

        }

        private void CargarCamposFocus()
        {
            txtDeporteCategoria.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtNombreCategoria);
            txtNombreCategoria.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtImporteMensualCategoria);
            txtImporteMensualCategoria.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnGuardarCategoria);
            dtpInicioCategoria.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnGuardarCategoria);
            dtpFinCategoria.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnGuardarCategoria);

            txtNombreCategoria.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, txtNombreCategoria, 50);
            txtImporteMensualCategoria.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumerosYLimitador(sender, e, txtImporteMensualCategoria, 9);
        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloCategoria);
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblDeporteCategoria, lblNombreCategoria, lblFechaInicioCategoria, lblFechaFinCategoria, lblImporteMensualCategoria);
            interfaz.TransformarTextBoxTextoPersonalizadoTodos(txtNombreCategoria, txtImporteMensualCategoria);
            interfaz.TransformarTextBoxTextoNoEditablePersonalizado(txtDeporteCategoria);
            interfaz.TransformarTextBoxTextoNoEditablePersonalizado(txtNombreCategoria);
            interfaz.TransformarDateTimePickerPersonalizado(dtpInicioCategoria);
            interfaz.TransformarDateTimePickerPersonalizado(dtpFinCategoria);
            interfaz.TransformarBotonPersonalizadoTodos(btnGuardarCategoria, btnCancelarCategoria);
        }

        private void BotonGuardarCategoria_Click(object sender, EventArgs e)
        {
            var hayError = false;

            
            if (dtpFinCategoria.Value.CompareTo(dtpInicioCategoria.Value) < 1)
            {
                hayError = true;
                errorProvider1.SetError(dtpInicioCategoria, "El día de comienzo debe ser antes que el día de fin del Categoría");
                errorProvider1.SetError(dtpFinCategoria, "El día de comienzo debe ser antes que el día de fin del Categoría");
            }
            else { errorProvider1.SetError(dtpInicioCategoria, ""); errorProvider1.SetError(dtpFinCategoria, ""); }
            if (long.Parse(txtImporteMensualCategoria.Text) > Int32.MaxValue || long.Parse(txtImporteMensualCategoria.Text) < Int32.MinValue)
            {
                hayError = true;
                errorProvider1.SetError(txtImporteMensualCategoria, "El importe mensual es un número demasiado grande");
            }
            else if (txtImporteMensualCategoria.Text.Equals("") || Int32.Parse(txtImporteMensualCategoria.Text) == 0)
            {
                hayError = true;
                errorProvider1.SetError(txtImporteMensualCategoria, "El importe mensual debe ser un número mayor a cero");
            }
            else errorProvider1.SetError(txtImporteMensualCategoria, "");
            if (hayError)
                return;

            ControladorCategoria un_controlador_Categoria = new ControladorCategoria();
            var resultado = un_controlador_Categoria.ModificarCategoria(Categoria.IdCategoria,txtNombreCategoria.Text,Int32.Parse(txtImporteMensualCategoria.Text), dtpInicioCategoria.Value, dtpFinCategoria.Value, Categoria.Deporte, Categoria.EstadoCategoria);
            if (resultado > 0)
            {
                Padre.ModificarMensaje("La Categoría ha sido modificado con ÉXITO");
                Padre.Actualizar();
                Dispose();
            }
            else if (resultado == -2)
                MyMessageBox.Show(this, "Ya existe el nombre de la Categoría", "Categoria");

        }

        private void BotonCancelarCategoria_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}

