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
    public partial class InterfazModificarEmpleado : Form
    {
        private Form padre;
        private ModelEmpleadoPersona empleado;

        public InterfazModificarEmpleado(Form padre, ModelEmpleadoPersona empleado)
        {

            this.padre = padre;
            this.empleado = empleado;
            InitializeComponent();
            textBoxNombreEmpleado.Text = empleado.Nombre;
            textBoxApellidoEmpleado.Text = empleado.Apellido;
            //dateTimeNacimiento.Value = empleado.MiEmpleado.Persona.FechaNacimiento;
            textBoxDocumento.Text = Convert.ToString(empleado.DNI);
            textBoxDescripcion.Text = empleado.MiEmpleado.DescripcionTarea;
            //dateTimeInicioEmpleado.Value = empleado.MiEmpleado.FechaInicio;

            List<string> lista = Enum.GetNames(typeof(EnumTipoEmpleado)).ToList();
            lista.Insert(0, "");
            ComboboxTipoEmpleado.DataSource = lista;

            this.textBoxNombreEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, textBoxNombreEmpleado);
            this.textBoxApellidoEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, textBoxApellidoEmpleado, 50);
            this.textBoxDocumento.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, textBoxDocumento);
            this.textBoxDescripcion.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, textBoxDescripcion);
            //this.dateTimeNacimiento.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, BotonGuardarDeporte);
            //this.txtDescripcionDeporte.KeyPress += (sender, e) => new CampoConRestriccion().Limitador(sender, e, txtDescripcionDeporte, 500);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* var hayError = false;
            if (textBoxNombreEmpleado.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(textBoxNombreEmpleado, "El nombre del empleado debe tener entre 3 y 50 caracteres");
            }
            else
            {
                errorProvider1.SetError(textBoxNombreEmpleado, "");
            }


            if (textBoxApellidoEmpleado.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(textBoxApellidoEmpleado, "El apellido del empleado debe tener entre 3 y 50 caracteres");
            }
            else
            {
                errorProvider1.SetError(textBoxApellidoEmpleado, "");
            }

            if (textBoxDescripcion.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(textBoxDescripcion, "La descripcion del empleado debe tener entre 3 y 100 caracteres");
            }
            else
            {
                errorProvider1.SetError(textBoxDescripcion, "");
            }

            if (hayError)
                return;*/

            string nombre = textBoxNombreEmpleado.Text;
            string descripcion = textBoxApellidoEmpleado.Text;

            EnumTipoEmpleado tipoEmpleado;
            Enum.TryParse<EnumTipoEmpleado>(ComboboxTipoEmpleado.SelectedValue.ToString(), out tipoEmpleado);

            ControladorEmpleado Cempleado = new ControladorEmpleado();


            var resultado = Cempleado.ModificarEmpleado(textBoxNombreEmpleado.Text, textBoxApellidoEmpleado.Text, dateTimeNacimiento.Value, Convert.ToInt32(textBoxDocumento.Text), textBoxDescripcion.Text, dateTimeInicioEmpleado.Value, tipoEmpleado);
            if (resultado > 0)
            {
                //MessageBox.Show(this, "Se ha modificado el DEPORTE", "Deporte");
                //  ((InterfazListaDeportes)padre).ModificarMensaje("Se ha modificado el EMPLEADO");
                Dispose();
            }
            else if (resultado == -2)
                MessageBox.Show(this, "Ya existe el nombre del EMPLEADO", "Empleado");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
