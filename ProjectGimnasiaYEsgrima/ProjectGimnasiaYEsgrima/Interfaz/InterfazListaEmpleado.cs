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
        public InterfazListaEmpleado()
        {
            InitializeComponent();
            dataGridViewEmpleadoPersona.AllowUserToAddRows = false;
            dataGridViewEmpleadoPersona.Visible = false;
            List<string> lista = Enum.GetNames(typeof(EnumTipoEmpleado)).ToList();
            lista.Insert(0, "");
            ComboBoxTipoEmpleado.DataSource = lista;
            LabelInfoEmpleado.Text = "";

            this.empleadoPersonaBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.ModelEmpleadoPersona);
            txtNombreEmpleado.Focus();
            txtNombreEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtApellidoEmpleado);
            txtNombreEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYSeparadorYLimitador(sender, e, txtNombreEmpleado, 50);
            txtApellidoEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtDNIEmpleado);
            txtApellidoEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYSeparadorYLimitador(sender, e, txtApellidoEmpleado, 50);
            txtDNIEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, BotonBuscarEmpleado);
            txtDNIEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumerosYLimitador(sender, e, txtDNIEmpleado, 8);
        }

        private void BotonBuscarEmpleado_Click(object sender, EventArgs e)
        {
            dataGridViewEmpleadoPersona.Visible = true;
            if(txtNombreEmpleado.Text.Equals("") && txtApellidoEmpleado.Text.Equals("") && txtDNIEmpleado.Text.Equals("") && ComboBoxTipoEmpleado.SelectedIndex==0)
            { 
                dataGridViewEmpleadoPersona.DataSource = CEmpleado.ExtraerEmpleadosAVista();
            }
            else
            {
                dataGridViewEmpleadoPersona.DataSource = CEmpleado.ExtraerEmpleadosAVista(txtNombreEmpleado.Text, txtApellidoEmpleado.Text,
                    txtDNIEmpleado.Text,ComboBoxTipoEmpleado.SelectedItem);
            }

        }

        private void BotonCrearEmpleado_Click(object sender, EventArgs e)
        {
            InterfazAltaEmpleado interfaz = new InterfazAltaEmpleado(this);
            interfaz.ShowDialog();
            if (dataGridViewEmpleadoPersona.Visible)
                BotonBuscarEmpleado_Click(sender, e);
        }

        private void DataGridViewEmpleadoPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEmpleadoPersona.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {
                InterfazModificarEmpleado interfazModificar = new InterfazModificarEmpleado(this, (ModelEmpleadoPersona)dataGridViewEmpleadoPersona.CurrentRow.DataBoundItem);
                interfazModificar.ShowDialog();
            }
            else if(dataGridViewEmpleadoPersona.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                if (MessageBox.Show("¿Seguro que desea Eliminar este Empleado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ControladorEmpleado CEmpleado = new ControladorEmpleado();
                    if(CEmpleado.EliminarEmpleado(((ModelEmpleadoPersona)dataGridViewEmpleadoPersona.CurrentRow.DataBoundItem).MiEmpleado) > 0)
                    {
                        ModificarMensaje("Se ha eliminado el Empleado");
                        
                    }
                }

            }
            if (dataGridViewEmpleadoPersona.Visible)
                BotonBuscarEmpleado_Click(sender, e);
        }

        public void ModificarMensaje(string v)
        {
            LabelInfoEmpleado.Text = v;
        }
    }
}
