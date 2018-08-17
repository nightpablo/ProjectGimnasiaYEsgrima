using ProjectGimnasiaYEsgrima;
using ProjectGimnasiaYEsgrima.Utils;
using ProjectGimnasiaYEsgrima.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectGimnasiaYEsgrima.Modelo;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    public partial class InterfazModificarDeporte : Form
    {

        private Form padre;
        private Deporte deporte;
        public InterfazModificarDeporte(Form padre, Deporte deporte)
        {
            this.padre = padre;
            this.deporte = deporte;
            InitializeComponent();
            txtNombreDeporte.Text = deporte.Nombre;
            txtDescripcionDeporte.Text = deporte.Descripcion;
            this.txtNombreDeporte.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtDescripcionDeporte);
            this.txtNombreDeporte.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, txtNombreDeporte, 50);
            this.txtDescripcionDeporte.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, BotonGuardarDeporte);
            this.txtDescripcionDeporte.KeyPress += (sender, e) => new CampoConRestriccion().Limitador(sender, e, txtDescripcionDeporte, 500);

        }
       

        private void BotonGuardarDeporte_Click(object sender, EventArgs e)
        {
            var hayError = false;
            if (txtNombreDeporte.Text.Length < 3)
            {
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
            var resultado = un_controlador_deporte.ModificarDeporte(deporte.IdDeporte, nombre, descripcion);
            if (resultado > 0)
            {
                //MessageBox.Show(this, "Se ha modificado el DEPORTE", "Deporte");
                ((InterfazListaDeportes)padre).ModificarMensaje("Se ha modificado el DEPORTE");
                Dispose();
            }
            else if (resultado == -2)
                MessageBox.Show(this, "Ya existe el nombre del DEPORTE", "Deporte");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
