using ProjectGimnasiaYEsgrima.Controlador;
using ProjectGimnasiaYEsgrima.Modelo;
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
        }

        private void BotonBuscarEmpleado_Click(object sender, EventArgs e)
        {
            dataGridViewEmpleadoPersona.Visible = true;
            List<Empleado> lista = null;
            if(txtNombreEmpleado.Text.Equals("") && txtApellidoEmpleado.Text.Equals("") && txtDNIEmpleado.Text.Equals(""))
            { 
                dataGridViewEmpleadoPersona.DataSource = CEmpleado.ExtraerEmpleadosAVista();
            }
            else
            {
                string nombre = txtNombreEmpleado.Text.ToString();
                //if (ComboBoxTipoEmpleado.Text.ToString().Equals("Profesor")) ;
                lista = CEmpleado.ListarTodosEmpleadosPorFiltros(nombre);
            }

        }

        private void BotonCrearEmpleado_Click(object sender, EventArgs e)
        {
            InterfazAltaEmpleado interfaz = new InterfazAltaEmpleado(this);
            interfaz.ShowDialog();
            if (dataGridViewEmpleadoPersona.Visible)
                BotonBuscarEmpleado_Click(sender, e);
        }

        private void dataGridViewEmpleadoPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                        this.ModificarMensaje("Se ha eliminado el Empleado");
                        
                    }
                }

            }
        }

        private void ComboBoxTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LabelInfoEmpleado_Click(object sender, EventArgs e)
        {

        }


        public void ModificarMensaje(string v)
        {
            LabelInfoEmpleado.Text = v;
        }
    }
}
