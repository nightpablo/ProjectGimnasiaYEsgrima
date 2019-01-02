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
    public partial class InterfazListaSocio : Form
    {
        public InterfazListaSocio()
        {
            InitializeComponent();
            dataGridViewSocioPersona.AllowUserToAddRows = false;
            dataGridViewSocioPersona.Visible = false;

        }

        private void dataGridViewEmpleadoPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BotonBuscarEmpleado_Click(object sender, EventArgs e)
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
                //ModificarMensaje("No hay ningún empleado con estos filtros");
                return;
            }
           // else if (LabelInfoEmpleado.Text.Equals("No hay ningún empleado con estos filtros"))
            {
            //    ModificarMensaje("");
            }
            dataGridViewSocioPersona.DataSource = lista;
        }

        private void dataGridViewSocioPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSocioPersona.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {
                InterfazModificarSocio interfazModificar = new InterfazModificarSocio(this, (ModelSocioPersona  )dataGridViewSocioPersona.CurrentRow.DataBoundItem);
                interfazModificar.ShowDialog();
            }
            else if (dataGridViewSocioPersona.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                if (MessageBox.Show("¿Seguro que desea Eliminar este Socio?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ControladorSocio CSocio = new ControladorSocio();
                    if (CSocio.EliminarSocio(((ModelEmpleadoPersona)dataGridViewSocioPersona.CurrentRow.DataBoundItem).MiEmpleado) > 0)
                    {
                        ModificarMensaje("Se ha eliminado el Socio");

                    }
                }

            }
            if (dataGridViewEmpleadoPersona.Visible)
                BotonBuscarEmpleado_Click(sender, e);
        }
    }
}
