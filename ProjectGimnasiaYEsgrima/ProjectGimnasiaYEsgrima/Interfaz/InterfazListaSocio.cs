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
    public partial class InterfazListaSocio : Form
    {
        public Ventana MiVentana;
        public InterfazListaSocio(Ventana ventana)
        {
            MiVentana = ventana;
            InitializeComponent();
            dataGridViewSocioPersona.AllowUserToAddRows = false;
            dataGridViewSocioPersona.Visible = false;
            lblInfoSocio.Text = "";
            CargarCamposFocus();
            CargarInterfazBuena();

        }

        private void CargarCamposFocus()
        {
            txtNombreSocio.Focus();
            txtNombreSocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnBuscarSocio);
            txtApellidoSocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnBuscarSocio);
            txtDNISocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnBuscarSocio);

            txtNombreSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYSeparadorYLimitador(sender, e, txtNombreSocio, 50);
            txtApellidoSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYSeparadorYLimitador(sender, e, txtNombreSocio, 50);
            txtDNISocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumerosYLimitador(sender, e, txtNombreSocio,9);

        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(labelTituloVentana);
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblNombreSocio, lblApellidoSocio, lblDNISocio, lblInfoSocio);
            interfaz.TransformarTextBoxTextoPersonalizadoTodos(txtNombreSocio, txtApellidoSocio, txtDNISocio);
            interfaz.TransformarBotonPersonalizadoTodos(btnBuscarSocio, btnCrearSocio, btnVolver);
            interfaz.TransformarTablaPersonalizado(dataGridViewSocioPersona);
            interfaz.TransformarTablaBotonesPersonalizadosTodos(Modificar, Eliminar);

        }



        private void BotonBuscarSocio_Click(object sender, EventArgs e)
        {
            ControladorSocio CSocio = new ControladorSocio();
            dataGridViewSocioPersona.Visible = true;
            List<ModelSocioPersona> lista = null;
            if (txtNombreSocio.Text.Equals("") && txtApellidoSocio.Text.Equals("") && txtDNISocio.Text.Equals(""))
            {
                lista = CSocio.ExtraerSociosAVista();

            }
            else
            {
                lista = CSocio.ExtraerSociosAVista(txtNombreSocio.Text, txtApellidoSocio.Text,
                    txtDNISocio.Text);
            }

            if (lista.Count == 0)
            {
                ModificarMensaje("No hay ningún empleado con estos filtros");
                return;
            }
            else if (lblInfoSocio.Text.Equals("No hay ningún empleado con estos filtros"))
            {
                ModificarMensaje("");
            }
            dataGridViewSocioPersona.DataSource = lista;
        }

        private void dataGridViewSocioPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSocioPersona.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {
                AbrirOtraVentana<InterfazModificarSocio>(new InterfazModificarSocio(this, (ModelSocioPersona)dataGridViewSocioPersona.CurrentRow.DataBoundItem));
                if (dataGridViewSocioPersona.Visible)
                    BotonBuscarSocio_Click(sender, e);
            }
            else if (dataGridViewSocioPersona.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                if (MyMessageBox.Show("¿Seguro que desea Eliminar este Socio?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ControladorSocio CSocio = new ControladorSocio();
                    if (CSocio.EliminarSocio(((ModelSocioPersona)dataGridViewSocioPersona.CurrentRow.DataBoundItem).MiSocio) > 0)
                    {
                        ModificarMensaje("Se ha eliminado el Socio");
                        dataGridViewSocioPersona.DataSource = CSocio.ExtraerSociosAVista(txtNombreSocio.Text, txtApellidoSocio.Text,
                    txtDNISocio.Text);
                    }
                }

            }
            
                
        }
        public void ModificarMensaje(string v)
        {
            lblInfoSocio.Text = v;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void botonCrearSocio_Click(object sender, EventArgs e)
        {
            AbrirOtraVentana<InterfazAltaSocio>(new InterfazAltaSocio(this));
            if (dataGridViewSocioPersona.Visible)
                BotonBuscarSocio_Click(sender, e);
        }

        private void AbrirOtraVentana<T>(Object Formhijo)
        {

            Form fh = MiVentana.VentanaContenedor.Controls.OfType<T>().FirstOrDefault() as Form;
            if (fh != null)
            {
                //Si la instancia esta minimizada la dejamos en su estado normal
                if (fh.WindowState == FormWindowState.Minimized)
                {
                    fh.WindowState = FormWindowState.Normal;
                }
                //Si la instancia existe la pongo en primer plano
                fh.BringToFront();
                return;
            }

            fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            MiVentana.VentanaContenedor.Controls.Add(fh);
            MiVentana.VentanaContenedor.Tag = fh;
            fh.Show();
            AbrirOtraVentana<T>(fh);
        }
        
    }

}
