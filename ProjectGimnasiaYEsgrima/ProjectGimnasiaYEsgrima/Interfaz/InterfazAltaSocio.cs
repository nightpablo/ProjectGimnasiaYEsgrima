using ProjectGimnasiaYEsgrima.Controlador;
using ProjectGimnasiaYEsgrima.Modelo;
using System;
using System.Windows.Forms;
using ProjectGimnasiaYEsgrima.Utils;
using System.Text.RegularExpressions;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    public partial class InterfazAltaSocio : Form
    {

        InterfazListaSocio Padre;
        private bool CargoPersona = false;
        public InterfazAltaSocio(InterfazListaSocio padre)
        {
            Padre = padre;
            InitializeComponent();
            cbxTipoDocumentoSocio.DataSource = Enum.GetValues(typeof(EnumTipoDocumento));
            cbxCategoria.DataSource = Enum.GetValues(typeof(EnumCategoriaSocio));
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

            txtNombreSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYSeparadorYLimitador(sender, e, txtNombreSocio, 50);
            txtApellidoSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYSeparadorYLimitador(sender, e, txtApellidoSocio, 50);
            txtDocumentoSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumerosYLimitador(sender, e, txtDocumentoSocio, 8);
            txtDireccionSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, txtDireccionSocio, 50);
            txtLocalidadSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, txtLocalidadSocio, 50);
            txtTelefonoSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYLimitador(sender, e, txtTelefonoSocio, 50);

        }
        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloSocio);
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblNombreSocio, lblApellidoSocio, lblFechaNacimientoSocio, lblTipoDocumentoSocio, lblNumeroDocumentoSocio, lblDireccionSocio, lblLocalidadSocio, lblTelefonoSocio,lblCategoria);
            interfaz.TransformarTextBoxTextoPersonalizadoTodos(txtNombreSocio, txtApellidoSocio, txtDocumentoSocio, txtDireccionSocio, txtLocalidadSocio, txtTelefonoSocio);
            interfaz.TransformarBotonPersonalizadoTodos(btnGuardarSocio, btnVolverSocio);
            interfaz.TransformarDateTimePickerPersonalizado(dtFechaNacimientoSocio);
            interfaz.TransformarComboBoxPersonalizado(cbxTipoDocumentoSocio);
            interfaz.TransformarComboBoxPersonalizado(cbxCategoria);


        }

        private void buttonGuardarSocio_Click(object sender, EventArgs e)
        {
            var hayError = false;
            if (txtNombreSocio.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(txtNombreSocio, "El nombre del socio debe contener entre 3 y 50 caracteres");
            }
            else errorProvider1.SetError(txtNombreSocio, "");

            if (txtApellidoSocio.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(txtApellidoSocio, "El apellido del socio debe contener entre 3 y 50 caracteres");
            }
            else errorProvider1.SetError(txtApellidoSocio, "");

            if (txtDocumentoSocio.Text.Length < 6 || (Convert.ToInt32(txtDocumentoSocio.Text)+"").Length < 6 )
            {
                hayError = true;
                errorProvider1.SetError(txtDocumentoSocio, "El DNI debe ser un número entre 6 y 8 dígitos");
            }
            else errorProvider1.SetError(txtDocumentoSocio, "");

            if (txtDireccionSocio.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(txtDireccionSocio, "La direccion del socio debe contener entre 3 y 50 caracteres");
            }
            else errorProvider1.SetError(txtDireccionSocio, "");

            if (txtLocalidadSocio.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(txtLocalidadSocio, "La localidad del socio debe contener entre 3 y 50 caracteres");
            }
            else errorProvider1.SetError(txtLocalidadSocio, "");

            if (txtTelefonoSocio.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(txtTelefonoSocio, "El teléfono del socio debe contener entre 3 y 50 caracteres");
            }
            else errorProvider1.SetError(txtTelefonoSocio, "");

            if (dtFechaNacimientoSocio.Value.CompareTo(DateTime.Now) >= 0)
            {
                hayError = true;
                errorProvider1.SetError(dtFechaNacimientoSocio, "La fecha de nacimiento debe ser inferior al dia de hoy.");
            }
            else errorProvider1.SetError(dtFechaNacimientoSocio, "");
            

            if (hayError)
                return;

            Enum.TryParse<EnumTipoDocumento>(cbxTipoDocumentoSocio.SelectedValue.ToString(), out EnumTipoDocumento tipoDocumento);
            Enum.TryParse<EnumCategoriaSocio>(cbxCategoria.SelectedValue.ToString(), out EnumCategoriaSocio categoria);

            ControladorSocio Csocio = new ControladorSocio();
            int resultado = Csocio.CrearSocio(txtNombreSocio.Text, txtApellidoSocio.Text, dtFechaNacimientoSocio.Value, 
                Convert.ToInt32(txtDocumentoSocio.Text), txtDireccionSocio.Text, txtLocalidadSocio.Text,
                txtTelefonoSocio.Text, tipoDocumento, categoria);
            if (resultado > 0)
            {

                Padre.ModificarMensaje("El SOCIO ha sido creado con ÉXITO");
                Padre.Actualizar();
                Dispose();
                
                
            }   
            else if (resultado == -1)
            {
                Padre.ModificarMensaje("Se ha recuperado el SOCIO");
                Padre.Actualizar();
                Dispose();


            }
            else if (resultado == -2)
                MyMessageBox.Show(this, "Ya existe el SOCIO", "Socio");
            else if (resultado == -3)
                MyMessageBox.Show(this, "No se ha definido un monto inicial de la cuota mensual del club, ir a las configuraciones del sistema", "Socio");
        }

        private void buttonVolverSocio_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumentoSocio_Leave(object sender, EventArgs e)
        {
            if (!txtDocumentoSocio.Text.Equals("") && new Regex("[0-9]*").IsMatch(txtDocumentoSocio.Text))
            {
                ControladorPersona Cpersona = new ControladorPersona();
                Persona persona = Cpersona.BuscarPersonaPorClavesUnicas(Int32.Parse(txtDocumentoSocio.Text));
                if (persona != null && !CargoPersona)
                {
                    if (MyMessageBox.Show("La persona ya existe (tiene el mismo DNI), ¿desea cargarlo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        txtNombreSocio.Text = persona.Nombre;
                        txtApellidoSocio.Text = persona.Apellido;
                        dtFechaNacimientoSocio.Value = persona.FechaNacimiento;
                        CargoPersona = true;
                    }
                }
            }
        }

        private void txtNombreSocio_TextChanged(object sender, EventArgs e)
        {
            if (CargoPersona)
            {
                txtDocumentoSocio.Text = "";
                CargoPersona = false;
            }
        }
    }
}
