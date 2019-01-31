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
    public partial class InterfazInicioSesion : Form
    {

        public static bool logueado { get; set; }
        public static Empleado MiEmpleado { get; set; }
        InterfazPrincipal MiVentana;
        public InterfazInicioSesion(InterfazPrincipal ventana)
        {
            MiVentana = ventana;
            InitializeComponent();
            logueado = false;
            MiEmpleado = null;
            Recargar();
            CargarInterfazBuena();
        }

        public void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloInicioSesion);
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblUsuario, lblContraseña,lblTipoEmpleado,lblPermiso);
            interfaz.TransformarBotonPersonalizadoTodos(btnLogin, btnCancelar);
            interfaz.TransformarTextBoxTextoPersonalizado(txtContraseña);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Empleado empleado = new ControladorEmpleado().VerificarLoginEmpleado(txtUsuario.Text, txtContraseña.Text);
            if (empleado != null)
            { // revisar la existencia del usuario
                MiEmpleado = empleado;
                lblTipoEmpleado.Text = MiEmpleado.TipoEmpleado.ToString();
                logueado = true;
                Recargar();
            }
            else
            {
                MyMessageBox.Show(this, "El usuario o contraseña es incorrecta", "Inicio Sesion");
            }
        }

        private void Recargar()
        {
            if (logueado)
            {
                lblTituloInicioSesion.Text = "Bienvenido";
                txtUsuario.ReadOnly = true;
                txtContraseña.ReadOnly = true;
                btnLogin.Hide();
                btnCancelar.Hide();
                txtContraseña.Hide();
                lblContraseña.Hide();
                btnDesconectar.Show();
                lblPermiso.Show();
                lblTipoEmpleado.Show();
                new InterfazBuena().TransformarTextBoxTextoNoEditablePersonalizado(txtUsuario);
                
            }
            else
            {
                lblTituloInicioSesion.Text = "Inicio Sesión";
                txtUsuario.ReadOnly = false;
                txtContraseña.ReadOnly = false;
                btnLogin.Show();
                btnCancelar.Show();
                txtContraseña.Show();
                lblContraseña.Show();
                btnDesconectar.Hide();
                lblPermiso.Hide();
                lblTipoEmpleado.Hide();
                txtUsuario.BackColor = Color.Empty;
                new InterfazBuena().TransformarTextBoxTextoPersonalizado(txtUsuario);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {           
            Dispose();
            MiVentana.Dispose();
        }

        private void BtnDesconectar_Click(object sender, EventArgs e)
        {
            logueado = false;
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            MiEmpleado = null;
            Recargar();
        }
    }
}
