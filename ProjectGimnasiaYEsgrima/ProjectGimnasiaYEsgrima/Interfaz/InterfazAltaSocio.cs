using ProjectGimnasiaYEsgrima.Controlador;
using ProjectGimnasiaYEsgrima.Modelo;
using System;
using System.Windows.Forms;
using ProjectGimnasiaYEsgrima.Utils;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    public partial class InterfazAltaSocio : Form
    {

        InterfazListaSocio Padre;
        public InterfazAltaSocio(InterfazListaSocio padre)
        {
            Padre = padre;
            InitializeComponent();
            cbxTipoDocumentoSocio.DataSource = Enum.GetValues(typeof(EnumTipoDocumento));
            CargarCamposFocus();
            CargarInterfazBuena();
        }
        private void CargarCamposFocus()
        {
            txtNombreSocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtApellidoSocio);
            txtApellidoSocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtDocumentoSocio);
            txtDocumentoSocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtDireccionSocio);
            txtDireccionSocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtLocalidadSocio);
            txtLocalidadSocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtTelefonoSocio);
            txtTelefonoSocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnGuardarSocio);

            txtNombreSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, txtNombreSocio, 50);
            txtApellidoSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, txtApellidoSocio, 50);
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
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblNombreSocio, lblApellidoSocio, lblFechaNacimientoSocio, lblTipoDocumentoSocio, lblNumeroDocumentoSocio, lblDireccionSocio, lblLocalidadSocio, lblTelefonoSocio);
            interfaz.TransformarTextBoxTextoPersonalizadoTodos(txtNombreSocio, txtApellidoSocio, txtDocumentoSocio, txtDireccionSocio, txtLocalidadSocio, txtTelefonoSocio);
            interfaz.TransformarBotonPersonalizadoTodos(btnGuardarSocio, btnVolverSocio);
            interfaz.TransformarDateTimePickerPersonalizado(dtFechaNacimientoSocio);
            interfaz.TransformarComboBoxPersonalizado(cbxTipoDocumentoSocio);

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

            if (txtDocumentoSocio.Text.Length < 7)
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
                errorProvider1.SetError(txtTelefonoSocio, " debe ser con carácter entre 3 y 50");
            }
            else errorProvider1.SetError(txtTelefonoSocio, "");
            if (hayError)
                return;

            Enum.TryParse<EnumTipoDocumento>(cbxTipoDocumentoSocio.SelectedValue.ToString(), out EnumTipoDocumento tipoDocumento);

            ControladorSocio Csocio = new ControladorSocio();
            int resultado = Csocio.CrearSocio(txtNombreSocio.Text, txtApellidoSocio.Text, dtFechaNacimientoSocio.Value, 
                Convert.ToInt32(txtDocumentoSocio.Text), txtDireccionSocio.Text, txtLocalidadSocio.Text,
                txtTelefonoSocio.Text, tipoDocumento);
            if (resultado > 0)
            {
                Padre.ModificarMensaje("Se ha creado el SOCIO");
                Dispose();
                
                
            }   
            else if (resultado == -1)
            {
                Padre.ModificarMensaje("Se ha recuperado el SOCIO");
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
