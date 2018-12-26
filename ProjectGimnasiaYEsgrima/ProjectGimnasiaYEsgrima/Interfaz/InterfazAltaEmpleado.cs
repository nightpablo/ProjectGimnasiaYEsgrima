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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    public partial class InterfazAltaEmpleado : Form
    {

        //public var selected = new List<Deporte>();
        private bool CargoPersona = false;
        private InterfazListaEmpleado Padre;

        public InterfazAltaEmpleado(InterfazListaEmpleado padre)
        {
            InitializeComponent();
            Padre = padre;


            ComboboxTipoEmpleado.DataSource = Enum.GetValues(typeof(EnumTipoEmpleado));

            textBoxNombreEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, textBoxApellidoEmpleado);
            textBoxApellidoEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, textBoxDocumento);
            textBoxDocumento.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, textBoxDescripcion);
            ComboboxTipoEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, botonGuardarEmpleado);

            textBoxNombreEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYSeparadorYLimitador(sender, e, textBoxNombreEmpleado, 50);
            textBoxApellidoEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYSeparadorYLimitador(sender, e, textBoxApellidoEmpleado, 50);
            textBoxDocumento.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumerosYLimitador(sender, e, textBoxDocumento, 8);
            textBoxDescripcion.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYSeparadorYLimitador(sender, e, textBoxDescripcion, 500);

        }

        public void BotonGuardarEmpleado_Click(object sender, EventArgs e)
        {

            var hayError = false;
            if (textBoxNombreEmpleado.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(textBoxNombreEmpleado, "El nombre debe ser con carácter entre 3 y 50");
            }
            else errorProvider1.SetError(textBoxNombreEmpleado, "");
            if (textBoxApellidoEmpleado.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(textBoxApellidoEmpleado, "El apellido debe ser con carácter entre 3 y 50");
            }
            else errorProvider1.SetError(textBoxApellidoEmpleado, "");
            if (textBoxDocumento.Text.Length < 6)
            {
                hayError = true;
                errorProvider1.SetError(textBoxDocumento, "El DNI debe ser con número entre 6 y 8");
            }
            else errorProvider1.SetError(textBoxDocumento, "");


            if (hayError)
                return;

            Enum.TryParse<EnumTipoEmpleado>(ComboboxTipoEmpleado.SelectedValue.ToString(), out EnumTipoEmpleado tipoEmpleado);

            ControladorEmpleado Cempleado = new ControladorEmpleado();
            int resultado = Cempleado.CrearEmpleado(textBoxNombreEmpleado.Text, textBoxApellidoEmpleado.Text, dateTimeNacimiento.Value,Convert.ToInt32(textBoxDocumento.Text), textBoxDescripcion.Text, dateTimeInicioEmpleado.Value, tipoEmpleado);
            if (resultado > 0)
            {
                Padre.ModificarMensaje("Se ha creado el EMPLEADO");
                Dispose();
            }
            else if(resultado == -1)
            {
                Padre.ModificarMensaje("Se ha recuperado el EMPLEADO");
                Dispose();
            }
            else if (resultado == -2)
                MessageBox.Show(this, "Ya existe el EMPLEADO", "Empleado");
        
      
        }

        private void TextBoxDocumento_Leave(object sender, EventArgs e)
        {
            if (!textBoxDocumento.Text.Equals("") && new Regex("[0-9]*").IsMatch(textBoxDocumento.Text))
            {
                ControladorPersona Cpersona = new ControladorPersona();
                Persona persona = Cpersona.BuscarPersonaPorClavesUnicas(Int32.Parse(textBoxDocumento.Text));
                if(persona !=null && !CargoPersona)
                {
                    if(MessageBox.Show("La persona ya existe (tiene el mismo DNI), ¿desea cargarlo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        textBoxNombreEmpleado.Text = persona.Nombre;
                        textBoxApellidoEmpleado.Text = persona.Apellido;
                        dateTimeNacimiento.Value = persona.FechaNacimiento;
                        CargoPersona = true;
                    }
                }
            }
        }

        private void TextBoxNombreEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (CargoPersona)
            {
                textBoxDocumento.Text = "";
                CargoPersona = false;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ComboboxTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
