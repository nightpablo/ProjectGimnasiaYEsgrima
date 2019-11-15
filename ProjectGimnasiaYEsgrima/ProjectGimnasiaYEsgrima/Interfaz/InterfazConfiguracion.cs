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
    public partial class InterfazConfiguracion : Form
    {
        InterfazPrincipal MiVentana;
            
        public InterfazConfiguracion(InterfazPrincipal ventana)
        {
            MiVentana = ventana;
            InitializeComponent();
            var valorcuotaInicial = new ControladorSocio().UltimoValorInicialClub();
            if(valorcuotaInicial==null)
                txtValorInicialAsociado.Text = 0 + "";
            else
                txtValorInicialAsociado.Text = valorcuotaInicial.Importe + "";

            CargarCamposFocus();
            CargarInterfazBuena();
        }

        private void CargarCamposFocus()
        {
            txtValorInicialAsociado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnModificarValorInicialAsociado);
            txtValorInicialAsociado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumerosYLimitador(sender, e, txtValorInicialAsociado, 8);
        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloConfiguracion);
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblValorInicialAsociado);
            interfaz.TransformarBotonPersonalizadoTodos(btnModificarValorInicialAsociado, btnVolver);
            interfaz.TransformarTextBoxTextoPersonalizadoTodos(txtValorInicialAsociado);

            
        }

        private void BtnModificarValorInicialAsociado_Click(object sender, EventArgs e)
        {
            var HayError = false;

            if (txtValorInicialAsociado.Text == "")
            {
                HayError = true;
                errorProvider1.SetError(txtValorInicialAsociado, "El importe inicial no debe ser nulo");
            }
            else if (long.Parse(txtValorInicialAsociado.Text) > Int32.MaxValue || long.Parse(txtValorInicialAsociado.Text) < Int32.MinValue)
            {
                HayError = true;
                errorProvider1.SetError(txtValorInicialAsociado, "El importe inicial es un número demasiado grande");
            }
            else if (Int32.Parse(txtValorInicialAsociado.Text) <=0)
            {
                HayError = true;
                errorProvider1.SetError(txtValorInicialAsociado, "El importe inicial debe ser un número mayor a cero");
            }
            else errorProvider1.SetError(txtValorInicialAsociado, "");
            if (HayError)
                return;


            if (MyMessageBox.Show("¿Está seguro que desea cambiar el valor inicial del club?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ControladorSocio controlador = new ControladorSocio();
                controlador.CrearValorInicialClub(double.Parse(txtValorInicialAsociado.Text));
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MiVentana.CargarLogin();
            Dispose();
        }

        private void InterfazConfiguracion_FormClosing(object sender, FormClosingEventArgs e)
        {
            MiVentana.CargarLogin();
            Dispose();
        }
    }
}
