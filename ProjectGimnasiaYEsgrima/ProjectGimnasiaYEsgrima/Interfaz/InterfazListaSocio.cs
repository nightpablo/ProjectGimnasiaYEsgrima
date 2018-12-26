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

        }

        private void dataGridViewEmpleadoPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BotonBuscarEmpleado_Click(object sender, EventArgs e)
        {
            ControladorSocio CSocio = new ControladorSocio();
            dataGridViewEmpleadoPersona.Visible = true;
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
            dataGridViewEmpleadoPersona.DataSource = lista;
        }
    }
}
