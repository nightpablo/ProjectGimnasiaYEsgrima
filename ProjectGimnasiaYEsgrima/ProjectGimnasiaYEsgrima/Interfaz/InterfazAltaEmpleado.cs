using ProjectGimnasiaYEsgrima.Controlador;
using ProjectGimnasiaYEsgrima.Modelo;
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

        }

        public void BotonGuardarEmpleado_Click(object sender, EventArgs e)
        {
            EnumTipoEmpleado tipoEmpleado;
            Enum.TryParse<EnumTipoEmpleado>(ComboboxTipoEmpleado.SelectedValue.ToString(), out tipoEmpleado);

            ControladorEmpleado Cempleado = new ControladorEmpleado();
            int resultado = Cempleado.CrearEmpleado(textBoxNombreEmpleado.Text, textBoxApellidoEmpleado.Text, dateTimeNacimiento.Value,Convert.ToInt32(textBoxDocumento.Text), textBoxDescripcion.Text, dateTimeInicioEmpleado.Value, tipoEmpleado);
            Dispose();
            if (resultado > 0)
            {
                //MessageBox.Show(this, "Se ha creado el EMPLEADO", "Empleado");
                ((InterfazListaEmpleado)Padre).ModificarMensaje("Se ha creado el EMPLEADO");
                Dispose();
            }
            else if (resultado == -2)
                MessageBox.Show(this, "No se pudo crear el EMPLEADO", "Empleado");
        
      
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
    }
}
