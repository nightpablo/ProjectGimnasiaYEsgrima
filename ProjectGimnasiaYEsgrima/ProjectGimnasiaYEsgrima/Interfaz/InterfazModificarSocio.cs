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
    public partial class InterfazModificarSocio : Form
    {
        private InterfazListaSocio Padre;
        private ModelSocioPersona Socio;

        public InterfazModificarSocio(InterfazListaSocio padre, ModelSocioPersona socio)
        {
            this.Padre = padre;
            this.Socio = socio;
            InitializeComponent();
            
            
            
            txtNombreSocio.Text = Socio.Nombre;
            txtApellidoSocio.Text = Socio.Apellido;

            dtFechaNacimientoSocio.Value = Socio.MiPersona.FechaNacimiento;
            txtDocumentoSocio.Text = Convert.ToString(Socio.DNI);

            txtDireccionSocio.Text = Socio.MiSocio.Direccion;
            txtLocalidadSocio.Text = Socio.MiSocio.Localidad;
            txtTelefonoSocio.Text = Socio.MiSocio.Telefono;
            txtTipoDocSocio.Text = Socio.MiSocio.TipoDocumento.ToString();

            txtDocumentoSocio.ReadOnly = true;
            txtTipoDocSocio.ReadOnly = true;


            cbxCategoria.DataSource = Enum.GetValues(typeof(EnumCategoriaSocio));
            CargarCamposFocus();
            CargarInterfazBuena();
        }
        private void CargarCamposFocus()
        {
            txtNombreSocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtApellidoSocio);
            txtApellidoSocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtDireccionSocio);
            txtDireccionSocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtLocalidadSocio);
            txtLocalidadSocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtTelefonoSocio);
            txtTelefonoSocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnGuardarSocio);

            txtNombreSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYSeparadorYLimitador(sender, e, txtNombreSocio, 50);
            txtApellidoSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYSeparadorYLimitador(sender, e, txtApellidoSocio, 50);
            txtDocumentoSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumerosYLimitador(sender, e, txtDocumentoSocio, 8);
            txtDireccionSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, txtDireccionSocio, 50);
            txtLocalidadSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, txtLocalidadSocio, 50);
            txtTelefonoSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, txtTelefonoSocio, 50);
            
        }
        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloSocio);
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblNombreSocio, lblApellidoSocio, lblFechaNacimientoSocio, lblTipoDocumentoSocio, lblNumeroDocumentoSocio, lblDireccionSocio, lblLocalidadSocio, lblTelefonoSocio, lblCategoria);
            interfaz.TransformarTextBoxTextoPersonalizadoTodos(txtNombreSocio, txtApellidoSocio, txtDireccionSocio, txtLocalidadSocio, txtTelefonoSocio);
            interfaz.TransformarBotonPersonalizadoTodos(btnGuardarSocio, btnVolverSocio);
            interfaz.TransformarDateTimePickerPersonalizado(dtFechaNacimientoSocio);
            interfaz.TransformarTextBoxTextoNoEditablePersonalizado(txtTipoDocSocio);
            interfaz.TransformarTextBoxTextoNoEditablePersonalizado(txtDocumentoSocio);
            interfaz.TransformarComboBoxPersonalizado(cbxCategoria);

        }





        private void buttonGuardarSocio_Click(object sender, EventArgs e)
        {
            var hayError = false;
            if (txtNombreSocio.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(txtNombreSocio, "El nombre debe ser con carácter entre 3 y 50");
            }
            else errorProvider1.SetError(txtNombreSocio, "");
            if (txtApellidoSocio.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(txtApellidoSocio, "El apellido debe ser con carácter entre 3 y 50");
            }
            else errorProvider1.SetError(txtApellidoSocio, "");
            if (txtDocumentoSocio.Text.Length < 6)
            {
                hayError = true;
                errorProvider1.SetError(txtDocumentoSocio, "El DNI debe ser con número entre 6 y 8");
            }
            else errorProvider1.SetError(txtDocumentoSocio, "");
            if (txtDireccionSocio.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(txtDireccionSocio, "La direccion debe ser con carácter entre 3 y 50");
            }
            else errorProvider1.SetError(txtDireccionSocio, "");

            if (txtLocalidadSocio.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(txtLocalidadSocio, "La localidad debe ser con carácter entre 3 y 50");
            }
            else errorProvider1.SetError(txtLocalidadSocio, "");
            if (txtTelefonoSocio.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(txtTelefonoSocio, "El teléfono debe ser con numérico y más de 3 digitos");
            }
            else errorProvider1.SetError(txtTelefonoSocio, "");
            


            if (hayError)
                return;


            ControladorSocio Csocio = new ControladorSocio();
            Enum.TryParse<EnumCategoriaSocio>(cbxCategoria.SelectedValue.ToString(), out EnumCategoriaSocio categoria);

            var resultado = Csocio.ModificarSocio(Socio.MiPersona.IdPersona, Socio.MiSocio.IdSocio, 
                txtNombreSocio.Text, txtApellidoSocio.Text, 
                dtFechaNacimientoSocio.Value, Convert.ToInt32(txtDocumentoSocio.Text),
                txtDireccionSocio.Text, txtLocalidadSocio.Text,txtTelefonoSocio.Text, categoria);

            if (resultado > 0)
            {
                Padre.ModificarMensaje("El SOCIO ha sido modificado con ÉXITO");
                Padre.Actualizar();
                Dispose();
            }
            else if (resultado == -2)
                MyMessageBox.Show(this, "Ya existe el SOCIO", "Socio");
        }

        private void buttonVolverSocio_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
