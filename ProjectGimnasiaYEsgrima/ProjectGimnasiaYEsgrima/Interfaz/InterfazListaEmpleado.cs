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
    public partial class InterfazListaEmpleado : Form
    {
        ControladorEmpleado CEmpleado = new ControladorEmpleado();
        InterfazPrincipal MiVentana;
        public InterfazListaEmpleado(InterfazPrincipal ventana)
        {
            MiVentana = ventana;
            InitializeComponent();
            dgvEmpleadoPersona.AllowUserToAddRows = false;
            dgvEmpleadoPersona.Visible = false;
            List<string> lista = Enum.GetNames(typeof(EnumTipoEmpleado)).ToList();
            lista.Insert(0, "");
            cbxTipoEmpleado.DataSource = lista;
            lblInfoEmpleado.Text = "";

            this.empleadoPersonaBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.ModelEmpleadoPersona);
            
            CargarCamposFocus();
            CargarInterfazBuena();
        }


        private void CargarCamposFocus()
        {
            txtNombreEmpleado.Focus();
            txtNombreEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtApellidoEmpleado);
            txtNombreEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYSeparadorYLimitador(sender, e, txtNombreEmpleado, 50);
            txtApellidoEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtDNIEmpleado);
            txtApellidoEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYSeparadorYLimitador(sender, e, txtApellidoEmpleado, 50);
            txtDNIEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnBuscarEmpleado);
            txtDNIEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumerosYLimitador(sender, e, txtDNIEmpleado, 8);
        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloEmpleado);
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblNombreEmpleado, lblApellidoEmpleado, lblTipoEmpleado,lblDNIEmpleado,lblInfoEmpleado);
            interfaz.TransformarTextBoxTextoPersonalizadoTodos(txtNombreEmpleado, txtApellidoEmpleado,txtDNIEmpleado);
            interfaz.TransformarComboBoxPersonalizado(cbxTipoEmpleado);
            interfaz.TransformarBotonPersonalizadoTodos(btnBuscarEmpleado, btnCrearEmpleado, btnVolver);
            interfaz.TransformarTablaPersonalizado(dgvEmpleadoPersona);
            interfaz.TransformarTablaBotonesPersonalizadosTodos(Modificar, Eliminar,EmitirCarnet);

        }

        private void BotonBuscarEmpleado_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        public void Actualizar()
        {
            dgvEmpleadoPersona.Visible = true;
            List<ModelEmpleadoPersona> lista = null;
            if (txtNombreEmpleado.Text.Equals("") && txtApellidoEmpleado.Text.Equals("") && txtDNIEmpleado.Text.Equals("") && cbxTipoEmpleado.SelectedIndex == 0)
            {
                lista = CEmpleado.ExtraerEmpleadosAVista();

            }
            else
            {
                lista = CEmpleado.ExtraerEmpleadosAVista(txtNombreEmpleado.Text, txtApellidoEmpleado.Text,
                    txtDNIEmpleado.Text, cbxTipoEmpleado.SelectedItem);
            }

            if (lista.Count == 0)
            {
                ModificarMensaje("No hay ningún empleado con estos filtros");
                return;
            }
            else if (lblInfoEmpleado.Text.Equals("No hay ningún empleado con estos filtros"))
            {
                ModificarMensaje("");
            }
            dgvEmpleadoPersona.DataSource = lista;
        }

        private void BotonCrearEmpleado_Click(object sender, EventArgs e)
        {
            AbrirOtraVentana<InterfazAltaEmpleado>(new InterfazAltaEmpleado(this));
            if (dgvEmpleadoPersona.Visible)
                BotonBuscarEmpleado_Click(sender, e);
        }

        private void DataGridViewEmpleadoPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleadoPersona.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {
                AbrirOtraVentana<InterfazModificarEmpleado>(new InterfazModificarEmpleado(this, (ModelEmpleadoPersona)dgvEmpleadoPersona.CurrentRow.DataBoundItem));
                BotonBuscarEmpleado_Click(sender, e);

            }
            else if(dgvEmpleadoPersona.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                if (MyMessageBox.Show("¿Seguro que desea Eliminar este Empleado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ControladorEmpleado CEmpleado = new ControladorEmpleado();
                    if(CEmpleado.EliminarEmpleado(((ModelEmpleadoPersona)dgvEmpleadoPersona.CurrentRow.DataBoundItem).MiEmpleado) > 0)
                    {
                        ModificarMensaje("Se ha eliminado el Empleado");
                        dgvEmpleadoPersona.DataSource = CEmpleado.ExtraerEmpleadosAVista(txtNombreEmpleado.Text, txtApellidoEmpleado.Text,
                    txtDNIEmpleado.Text, cbxTipoEmpleado.SelectedItem);
                    }
                }

            }
            else if (dgvEmpleadoPersona.Columns[e.ColumnIndex].Name.Equals("EmitirCarnet"))
            {
                AbrirOtraVentana<InterfazGenerarReporte>(new InterfazGenerarReporte(this, (ModelEmpleadoPersona)dgvEmpleadoPersona.CurrentRow.DataBoundItem));
            }


        }

        public void ModificarMensaje(string v)
        {
            lblInfoEmpleado.Text = v;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Dispose();
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
