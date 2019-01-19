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

        private InterfazListaDeportes Padre;
        private Deporte deporte;
        public InterfazModificarDeporte(InterfazListaDeportes padre, Deporte deporte)
        {
            Padre = padre;
            this.deporte = deporte;
            InitializeComponent();
            txtNombreDeporte.Text = this.deporte.Nombre;
            txtDescripcionDeporte.Text = this.deporte.Descripcion;
            txtNombreDeporte.ReadOnly = true;
           

            CargarCamposFocus();
            CargarInterfazBuena();

        }

        private void CargarCamposFocus()
        {
            txtNombreDeporte.Focus();
            txtNombreDeporte.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtDescripcionDeporte);
            txtDescripcionDeporte.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnGuardarDeporte);

            txtNombreDeporte.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, txtNombreDeporte, 50);
            txtDescripcionDeporte.KeyPress += (sender, e) => new CampoConRestriccion().Limitador(sender, e, txtDescripcionDeporte, 500);
        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloDeporte);
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblNombreDeporte, lblDescripcionDeporte);
            interfaz.TransformarTextBoxTextoPersonalizadoTodos(txtDescripcionDeporte);
            interfaz.TransformarBotonPersonalizadoTodos(btnGuardarDeporte, btnCancelarDeporte);
            interfaz.TransformarTextBoxTextoNoEditablePersonalizado(txtNombreDeporte);
        }


        private void BotonGuardarDeporte_Click(object sender, EventArgs e)
        {
            var hayError = false;
            if (txtNombreDeporte.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(txtNombreDeporte, "El nombre debe ser con carácter entre 3 y 50");
            }
            else errorProvider1.SetError(txtNombreDeporte, "");

            if (hayError)
                return;

            string nombre = txtNombreDeporte.Text;
            string descripcion = txtDescripcionDeporte.Text;

            ControladorDeporte un_controlador_deporte = new ControladorDeporte();
            var resultado = un_controlador_deporte.ModificarDeporte(deporte.IdDeporte, nombre, descripcion);
            if (resultado > 0)
            {
                Padre.ModificarMensaje("El DEPORTE ha sido modificado con ÉXITO");
                Padre.Actualizar();
                Dispose();
            }
            else if (resultado == -2)
                MyMessageBox.Show(this, "Ya existe el nombre del DEPORTE", "Deporte");
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
