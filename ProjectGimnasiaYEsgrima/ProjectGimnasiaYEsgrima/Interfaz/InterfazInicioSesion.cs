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
        InterfazPrincipal MiVentana;
        public InterfazInicioSesion(InterfazPrincipal ventana)
        {
            MiVentana = ventana;
            InitializeComponent();
            logueado = false;
            Recargar();
            CargarInterfazBuena();
        }

        public void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloInicioSesion);
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblUsuario, lblContraseña);
            interfaz.TransformarBotonPersonalizadoTodos(btnLogin, btnCancelar);
            interfaz.TransformarTextBoxTextoPersonalizado(txtContraseña);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            logueado = true; // revisar la existencia del usuario
            Recargar();
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
            Recargar();
        }
    }
}
