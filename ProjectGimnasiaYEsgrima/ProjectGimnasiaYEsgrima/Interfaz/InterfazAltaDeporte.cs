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

namespace ProjectGimnasiaYEsgrima
{
    public partial class InterfazAltaDeporte : Form
    {
        private Form padre;
        public InterfazAltaDeporte(Form padre)
        {
            this.padre = padre;
            InitializeComponent();

            this.txtNombreDeporte.Focus();
            this.txtNombreDeporte.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtDescripcionDeporte);
            this.txtNombreDeporte.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, txtNombreDeporte, 50);
            this.txtDescripcionDeporte.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, BotonGuardarDeporte);
            this.txtDescripcionDeporte.KeyPress += (sender, e) => new CampoConRestriccion().Limitador(sender, e, txtDescripcionDeporte, 500);


        }

        private void BotonGuardarDeporte_Click(object sender, EventArgs e)
        {
            var hayError = false;
            if (txtNombreDeporte.Text.Length < 3) { 
                hayError = true;
                errorProvider1.SetError(txtNombreDeporte, "El nombre debe ser con carácter entre 3 y 50");
            }
            else
            {
                errorProvider1.SetError(txtNombreDeporte, "");
            }

            if (hayError)
                return;
            string nombre = txtNombreDeporte.Text;
            string descripcion = txtDescripcionDeporte.Text;

            ControladorDeporte un_controlador_deporte = new ControladorDeporte();
            var resultado = un_controlador_deporte.CrearDeporte(nombre, descripcion);
            if ( resultado > 0)
            {
                MessageBox.Show(this, "Se ha creado un nuevo DEPORTE", "Deporte");
                Dispose();
            }
            else if(resultado == -2)
                MessageBox.Show(this, "Ya existe el nombre del DEPORTE", "Deporte");


        }

        private void BotonCancelarDeporte_Click(object sender, EventArgs e)
        {
            Dispose();
        }
       
    }
}
