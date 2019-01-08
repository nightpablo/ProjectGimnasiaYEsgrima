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
            txtNombreEmpleado.Text = empleado.Nombre;
            txtApellidoEmpleado.Text = empleado.Apellido;
            dtpFechaNacimiento.Value = empleado.MiPersona.FechaNacimiento;
            txtDNIEmpleado.Text = Convert.ToString(empleado.DNI);
            txtDescripcionEmpleado.Text = empleado.MiEmpleado.DescripcionTarea;
            dtpInicioEmpleado.Value = empleado.MiEmpleado.FechaInicio;

            txtTipoEmpleado.Text = empleado.TipoEmpleado.ToString();
            txtTipoEmpleado.ReadOnly = true;
            txtDNIEmpleado.ReadOnly = true;

            CargarCamposFocus();
            CargarInterfazBuena();
        }


        private void CargarCamposFocus()
        {
            txtNombreEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtApellidoEmpleado);
            txtApellidoEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtDNIEmpleado);
            txtDNIEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtDescripcionEmpleado);
            txtTipoEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnGuardarEmpleado);

            txtNombreEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYSeparadorYLimitador(sender, e, txtNombreEmpleado, 50);
            txtApellidoEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYSeparadorYLimitador(sender, e, txtApellidoEmpleado, 50);
            txtDNIEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumerosYLimitador(sender, e, txtDNIEmpleado, 8);
            txtDescripcionEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYSeparadorYLimitador(sender, e, txtDescripcionEmpleado, 500);
        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloEmpleado);
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblNombreEmpleado, lblApellidoEmpleado, lblTipoEmpleado, lblDNIEmpleado, lblFechaInicioEmpleado, lblFechaNacimientoEmpleado, lblDescripcionEmpleado);
            interfaz.TransformarTextBoxTextoPersonalizadoTodos(txtNombreEmpleado, txtApellidoEmpleado);
            interfaz.TransformarTextBoxTextoNoEditablePersonalizado(txtDNIEmpleado);
            interfaz.TransformarTextBoxTextoNoEditablePersonalizado(txtTipoEmpleado);
            interfaz.TransformarDateTimePickerPersonalizado(dtpFechaNacimiento);
            interfaz.TransformarDateTimePickerPersonalizado(dtpInicioEmpleado);
            interfaz.TransformarBotonPersonalizadoTodos(btnGuardarEmpleado, btnCancelar);



        }

        private void BotonGuardarEmpleado_Click(object sender, EventArgs e)
        {
            var hayError = false;
            if (txtNombreEmpleado.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(txtNombreEmpleado, "El nombre debe ser con carácter entre 3 y 50");
            }
            else errorProvider1.SetError(txtNombreEmpleado, "");
            if (txtApellidoEmpleado.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(txtApellidoEmpleado, "El apellido debe ser con carácter entre 3 y 50");
            }
            else errorProvider1.SetError(txtApellidoEmpleado, "");
            if (txtDNIEmpleado.Text.Length < 6)
            {
                hayError = true;
                errorProvider1.SetError(txtDNIEmpleado, "El DNI debe ser con número entre 6 y 8");
            }
            else errorProvider1.SetError(txtDNIEmpleado, "");


            if (hayError)
                return;

            Enum.TryParse<EnumTipoEmpleado>(txtTipoEmpleado.Text, out EnumTipoEmpleado tipoEmpleado);

            ControladorEmpleado Cempleado = new ControladorEmpleado();


            var resultado = Cempleado.ModificarEmpleado(empleado.MiPersona.IdPersona,empleado.MiEmpleado.IdEmpleado,txtNombreEmpleado.Text, txtApellidoEmpleado.Text, dtpFechaNacimiento.Value, Convert.ToInt32(txtDNIEmpleado.Text), txtDescripcionEmpleado.Text, dtpInicioEmpleado.Value, tipoEmpleado,empleado.MiEmpleado.EstadoEmpleado);
            if (resultado > 0)
            {
                Padre.ModificarMensaje("Se ha modificado el EMPLEADO");
                Dispose();
            }
            else if (resultado == -2)
                MessageBox.Show(this, "Ya existe el EMPLEADO", "Empleado");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
