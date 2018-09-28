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
        private InterfazListaEmpleado Padre;
        private ModelEmpleadoPersona empleado;

        public InterfazModificarEmpleado(InterfazListaEmpleado padre, ModelEmpleadoPersona empleado)
        {

            this.Padre = padre;
            this.empleado = empleado;
            InitializeComponent();
            textBoxNombreEmpleado.Text = empleado.Nombre;
            textBoxApellidoEmpleado.Text = empleado.Apellido;
            dateTimeNacimiento.Value = empleado.MiPersona.FechaNacimiento;
            textBoxDocumento.Text = Convert.ToString(empleado.DNI);
            textBoxDescripcion.Text = empleado.MiEmpleado.DescripcionTarea;
            dateTimeInicioEmpleado.Value = empleado.MiEmpleado.FechaInicio;

            txtTipoEmpleado.Text = empleado.TipoEmpleado.ToString();
            txtTipoEmpleado.ReadOnly = true;

            textBoxNombreEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, textBoxApellidoEmpleado);
            textBoxApellidoEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, textBoxDocumento);
            textBoxDocumento.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, textBoxDescripcion);
            textBoxDescripcion.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, BotonModificarEmpleado);

            textBoxNombreEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, textBoxNombreEmpleado, 50);
            textBoxApellidoEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, textBoxApellidoEmpleado, 50);
            textBoxDocumento.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumerosYLimitador(sender, e, textBoxDocumento,8);
            textBoxDescripcion.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumerosYLimitador(sender, e, textBoxDescripcion, 500);


        }

        private void Button1_Click(object sender, EventArgs e)
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

            Enum.TryParse<EnumTipoEmpleado>(txtTipoEmpleado.Text, out EnumTipoEmpleado tipoEmpleado);

            ControladorEmpleado Cempleado = new ControladorEmpleado();


            var resultado = Cempleado.ModificarEmpleado(empleado.MiPersona.IdPersona,empleado.MiEmpleado.IdEmpleado,textBoxNombreEmpleado.Text, textBoxApellidoEmpleado.Text, dateTimeNacimiento.Value, Convert.ToInt32(textBoxDocumento.Text), textBoxDescripcion.Text, dateTimeInicioEmpleado.Value, tipoEmpleado);
            if (resultado > 0)
            {
                Padre.ModificarMensaje("Se ha modificado el EMPLEADO");
                Dispose();
            }
            else if (resultado == -2)
                MessageBox.Show(this, "Ya existe el EMPLEADO", "Empleado");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
