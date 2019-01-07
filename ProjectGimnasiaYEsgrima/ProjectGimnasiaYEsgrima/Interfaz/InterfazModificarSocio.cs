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
            textBoxModificarNombreSocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, textBoxModificarNombreSocio);
            textBoxModificarApellidoSocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, textBoxModificarApellidoSocio);
            textBoxModificarNroDocSocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, textBoxModificarNroDocSocio);
            textBoxModificarDireccionSocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, textBoxModificarDireccionSocio);
            textBoxModificarLocalidadSocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, textBoxModificarLocalidadSocio);
            textBoxModificarTelefonoSocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, textBoxModificarTelefonoSocio);
            //textBoxDescripcion.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, BotonModificarEmpleado);

            textBoxModificarNombreSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, textBoxModificarNombreSocio, 50);
            textBoxModificarApellidoSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, textBoxModificarApellidoSocio, 50);
            textBoxModificarNroDocSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumerosYLimitador(sender, e, textBoxModificarNroDocSocio, 8);
            textBoxModificarDireccionSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, textBoxModificarDireccionSocio, 50);
            textBoxModificarLocalidadSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, textBoxModificarLocalidadSocio, 50);
            textBoxModificarTelefonoSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, textBoxModificarTelefonoSocio, 50);
            
            
            textBoxModificarNombreSocio.Text = Socio.Nombre;
            textBoxModificarApellidoSocio.Text = Socio.Apellido;

            dateTimePicker1.Value = Socio.MiPersona.FechaNacimiento;
            textBoxModificarNroDocSocio.Text = Convert.ToString(Socio.DNI);

            textBoxModificarDireccionSocio.Text = Socio.MiSocio.Direccion;
            textBoxModificarLocalidadSocio.Text = Socio.MiSocio.Localidad;
            textBoxModificarTelefonoSocio.Text = Socio.MiSocio.Telefono;
            textBoxModificarTipoDocSocio.Text = Socio.MiSocio.TipoDocumento.ToString();

            textBoxModificarNroDocSocio.ReadOnly = true;
            textBoxModificarTipoDocSocio.ReadOnly = true;

        }

        private void buttonModificarSocio_Click(object sender, EventArgs e)
        {
            var hayError = false;
            if (textBoxModificarNombreSocio.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(textBoxModificarNombreSocio, "El nombre debe ser con carácter entre 3 y 50");
            }
            else errorProvider1.SetError(textBoxModificarNombreSocio, "");
            if (textBoxModificarApellidoSocio.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(textBoxModificarApellidoSocio, "El apellido debe ser con carácter entre 3 y 50");
            }
            else errorProvider1.SetError(textBoxModificarApellidoSocio, "");
            if (textBoxModificarNroDocSocio.Text.Length < 6)
            {
                hayError = true;
                errorProvider1.SetError(textBoxModificarNroDocSocio, "El DNI debe ser con número entre 6 y 8");
            }
            else errorProvider1.SetError(textBoxModificarNroDocSocio, "");


            if (hayError)
                return;

            //Enum.TryParse<EnumTipoEmpleado>(txtTipoEmpleado.Text, out EnumTipoEmpleado tipoEmpleado);

            ControladorSocio Csocio = new ControladorSocio();


            var resultado = Csocio.ModificarSocio(Socio.MiPersona.IdPersona, Socio.MiSocio.IdSocio, 
                textBoxModificarNombreSocio.Text, textBoxModificarApellidoSocio.Text, 
                dateTimePicker1.Value, Convert.ToInt32(textBoxModificarNroDocSocio.Text),
                textBoxModificarDireccionSocio.Text, textBoxModificarLocalidadSocio.Text,textBoxModificarTelefonoSocio.Text);

            if (resultado > 0)
            {
                Padre.ModificarMensaje("Se ha modificado el SOCIO");
                Dispose();
            }
            else if (resultado == -2)
                MessageBox.Show(this, "Ya existe el SOCIO", "Socio");
        }

        private void buttonVolverModificarSocio_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
