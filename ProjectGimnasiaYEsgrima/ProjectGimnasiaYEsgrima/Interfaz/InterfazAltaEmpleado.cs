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


            cbxTipoEmpleado.DataSource = Enum.GetValues(typeof(EnumTipoEmpleado));

            
            CargarCamposFocus();
            CargarInterfazBuena();
        }


        private void CargarCamposFocus()
        {
            txtNombreEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtApellidoEmpleado);
            txtApellidoEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtDNIEmpleado);
            txtDNIEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtDescripcionEmpleado);
            cbxTipoEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnGuardarEmpleado);

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
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblNombreEmpleado, lblApellidoEmpleado, lblTipoEmpleado, lblDNIEmpleado, lblFechaInicioEmpleado,lblFechaNacimientoEmpleado,lblDescripcionEmpleado);
            interfaz.TransformarTextBoxTextoPersonalizadoTodos(txtNombreEmpleado, txtApellidoEmpleado, txtDNIEmpleado);
            interfaz.TransformarComboBoxPersonalizado(cbxTipoEmpleado);
            interfaz.TransformarDateTimePickerPersonalizado(dtpFechaNacimiento);
            interfaz.TransformarDateTimePickerPersonalizado(dtpInicioEmpleado);
            interfaz.TransformarBotonPersonalizadoTodos(btnGuardarEmpleado, btnCancelar);
            
            

        }

        public void BotonGuardarEmpleado_Click(object sender, EventArgs e)
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

            Enum.TryParse<EnumTipoEmpleado>(cbxTipoEmpleado.SelectedValue.ToString(), out EnumTipoEmpleado tipoEmpleado);

            ControladorEmpleado Cempleado = new ControladorEmpleado();
            int resultado = Cempleado.CrearEmpleado(txtNombreEmpleado.Text, txtApellidoEmpleado.Text, dtpFechaNacimiento.Value,Convert.ToInt32(txtDNIEmpleado.Text), txtDescripcionEmpleado.Text, dtpInicioEmpleado.Value, tipoEmpleado);
            if (resultado > 0)
            {
                Padre.ModificarMensaje("Se ha creado el EMPLEADO");
                Padre.Actualizar();
                Dispose();
            }
            else if(resultado == -1)
            {
                Padre.ModificarMensaje("Se ha recuperado el EMPLEADO");
                Padre.Actualizar();
                Dispose();
            }
            else if (resultado == -2)
                MyMessageBox.Show(this, "Ya existe el EMPLEADO", "Empleado");
        
      
        }

        private void TextBoxDocumento_Leave(object sender, EventArgs e)
        {
            if (!txtDNIEmpleado.Text.Equals("") && new Regex("[0-9]*").IsMatch(txtDNIEmpleado.Text))
            {
                ControladorPersona Cpersona = new ControladorPersona();
                Persona persona = Cpersona.BuscarPersonaPorClavesUnicas(Int32.Parse(txtDNIEmpleado.Text));
                if(persona !=null && !CargoPersona)
                {
                    if(MyMessageBox.Show("La persona ya existe (tiene el mismo DNI), ¿desea cargarlo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        txtNombreEmpleado.Text = persona.Nombre;
                        txtApellidoEmpleado.Text = persona.Apellido;
                        dtpFechaNacimiento.Value = persona.FechaNacimiento;
                        CargoPersona = true;
                    }
                }
            }
        }

        private void TextBoxNombreEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (CargoPersona)
            {
                txtDNIEmpleado.Text = "";
                CargoPersona = false;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
