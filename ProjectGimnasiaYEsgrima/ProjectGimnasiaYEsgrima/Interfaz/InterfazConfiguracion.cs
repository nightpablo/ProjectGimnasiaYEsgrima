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
            txtValorInicialAsociado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumerosYLimitador(sender, e, txtValorInicialAsociado, 50);
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
            if(MyMessageBox.Show("¿Está seguro que desea cambiar el valor inicial del club?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
            {
                ControladorSocio controlador = new ControladorSocio();
                controlador.CrearValorInicialClub(double.Parse(txtValorInicialAsociado.Text));
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
