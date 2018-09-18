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
            dateTimeNacimiento.Value = empleado.MiPersona.FechaNacimiento;
            textBoxDocumento.Text = Convert.ToString(empleado.DNI);
            textBoxDescripcion.Text = empleado.MiEmpleado.DescripcionTarea;
            dateTimeInicioEmpleado.Value = empleado.MiEmpleado.FechaInicio;

            ComboboxTipoEmpleado.DataSource = Enum.GetValues(typeof(EnumTipoEmpleado));

            this.textBoxNombreEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, textBoxNombreEmpleado);
            this.textBoxApellidoEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, textBoxApellidoEmpleado, 50);
            this.textBoxDocumento.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumerosYLimitador(sender, e, textBoxDocumento,8);
            this.textBoxDescripcion.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, textBoxDescripcion);
            //this.dateTimeNacimiento.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, dateTimeNacimiento);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var hayError = false;
            if (textBoxNombreEmpleado.Text.Length < 3)
            {
                hayError = true;
                errorProvider2.SetError(textBoxNombreEmpleado, "El nombre del empleado debe tener entre 3 y 50 caracteres");
            }
            else
            {
                errorProvider2.SetError(textBoxNombreEmpleado, "");
            }


            if (textBoxApellidoEmpleado.Text.Length < 3)
            {
                hayError = true;
                errorProvider2.SetError(textBoxApellidoEmpleado, "El apellido del empleado debe tener entre 3 y 50 caracteres");
            }
            else
            {
                errorProvider2.SetError(textBoxApellidoEmpleado, "");
            }

            if (textBoxDescripcion.Text.Length < 3)
            {
                hayError = true;
                errorProvider2.SetError(textBoxDescripcion, "La descripcion del empleado debe tener entre 3 y 100 caracteres");
            }
            else
            {
                errorProvider2.SetError(textBoxDescripcion, "");
            }

            if (hayError)
                return;

            string nombre = textBoxNombreEmpleado.Text;
            string descripcion = textBoxApellidoEmpleado.Text;

            EnumTipoEmpleado tipoEmpleado;
            Enum.TryParse<EnumTipoEmpleado>(ComboboxTipoEmpleado.SelectedValue.ToString(), out tipoEmpleado);

            ControladorEmpleado Cempleado = new ControladorEmpleado();


            var resultado = Cempleado.ModificarEmpleado(empleado.MiPersona.IdPersona,empleado.MiEmpleado.IdEmpleado,textBoxNombreEmpleado.Text, textBoxApellidoEmpleado.Text, dateTimeNacimiento.Value, Convert.ToInt32(textBoxDocumento.Text), textBoxDescripcion.Text, dateTimeInicioEmpleado.Value, tipoEmpleado);
            if (resultado > 0)
            {
                ((InterfazListaEmpleado)padre).ModificarMensaje("Se ha modificado el EMPLEADO");
                Dispose();
            }
            else if (resultado == -2)
                MessageBox.Show(this, "Ya existe el nombre del EMPLEADO", "Empleado");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
