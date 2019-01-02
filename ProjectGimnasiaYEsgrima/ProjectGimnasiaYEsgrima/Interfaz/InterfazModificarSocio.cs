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
    public partial class InterfazModificarSocio : Form
    {
        private InterfazListaSocio Padre;
        private ModelSocioPersona socio;

        public InterfazModificarSocio()
        {
            InitializeComponent();

            this.Padre = padre;
            this.socio = socio;
            InitializeComponent();
            textBoxModificarNombreSocio.Text = socio.Nombre;
            textBoxModificarApellidoSocio.Text = socio.Apellido;

            dateTimePicker1.Value = socio.MiPersona.FechaNacimiento;
            textBoxModificarNroDocSocio.Text = Convert.ToString(socio.DNI);

            textBoxModificarNroDocSocio.Text = socio.MiSocio
                //.DescripcionTarea;
            dateTimeInicioEmpleado.Value = empleado.MiEmpleado.FechaInicio;

            txtTipoEmpleado.Text = empleado.TipoEmpleado.ToString();
            txtTipoEmpleado.ReadOnly = true;
            textBoxDocumento.ReadOnly = true;

            textBoxNombreEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, textBoxApellidoEmpleado);
            textBoxApellidoEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, textBoxDocumento);
            textBoxDocumento.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, textBoxDescripcion);
            textBoxDescripcion.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, BotonModificarEmpleado);

            textBoxNombreEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, textBoxNombreEmpleado, 50);
            textBoxApellidoEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, textBoxApellidoEmpleado, 50);
            textBoxDocumento.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumerosYLimitador(sender, e, textBoxDocumento, 8);
            textBoxDescripcion.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYSeparadorYLimitador(sender, e, textBoxDescripcion, 500);
        }

        private void buttonModificarSocio_Click(object sender, EventArgs e)
        {

        }
    }
}
