using ProjectGimnasiaYEsgrima.Controlador;
using ProjectGimnasiaYEsgrima.Modelo;
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
    public partial class InterfazAltaSocio : Form
    {

        InterfazListaSocio Padre;
        public InterfazAltaSocio(InterfazListaSocio padre)
        {
            Padre = padre;
            InitializeComponent();
            comboBoxTipoDocumentoSocio.DataSource = Enum.GetValues(typeof(EnumTipoDocumento));
        }

        private void buttonGuardarSocio_Click(object sender, EventArgs e)
        {
            var hayError = false;
            if (textBoxnombreSocio.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(textBoxnombreSocio, "El nombre debe ser con carácter entre 3 y 50");
            }
            else errorProvider1.SetError(textBoxnombreSocio, "");

            if (textBoxApellido.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(textBoxApellido, "El apellido debe ser con carácter entre 3 y 50");
            }
            else errorProvider1.SetError(textBoxApellido, "");

            if (textBoxDocumentoSocio.Text.Length < 7)
            {
                hayError = true;
                errorProvider1.SetError(textBoxDocumentoSocio, "El DNI debe ser con número entre 6 y 8");
            }
            else errorProvider1.SetError(textBoxDocumentoSocio, "");

            if (textBoxDireccionSocio.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(textBoxDireccionSocio, "La direccion debe ser con carácter entre 3 y 50");
            }
            else errorProvider1.SetError(textBoxDireccionSocio, "");

            if (textBoxLocalidadSocio.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(textBoxLocalidadSocio, "La localidad debe ser con carácter entre 3 y 50");
            }
            else errorProvider1.SetError(textBoxLocalidadSocio, "");

            if (textBoxTelefonoSocio.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(textBoxTelefonoSocio, " debe ser con carácter entre 3 y 50");
            }
            else errorProvider1.SetError(textBoxTelefonoSocio, "");
            if (hayError)
                return;

            Enum.TryParse<EnumTipoDocumento>(comboBoxTipoDocumentoSocio.SelectedValue.ToString(), out EnumTipoDocumento tipoDocumento);

            ControladorSocio Csocio = new ControladorSocio();
            int resultado = Csocio.CrearSocio(textBoxnombreSocio.Text, textBoxApellido.Text, dateTimeNacimientoSocio.Value, 
                Convert.ToInt32(textBoxDocumentoSocio.Text), textBoxDireccionSocio.Text, textBoxLocalidadSocio.Text,
                textBoxTelefonoSocio.Text, tipoDocumento);
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
                MessageBox.Show(this, "Ya existe el SOCIO", "Socio");
        }

        private void buttonVolverSocio_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
