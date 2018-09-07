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
            List<ModelEmpleadoPersona> lista = null;
            if(txtNombre.Text.Equals("") && txtApellido.Text.Equals("") && txtDNI.Text.Equals(""))
                dataGridViewEmpleadoPersona.DataSource = new ControladorEmpleado().ExtraerEmpleadosAVista();
            //falta hacer la de listar segun filtros, y a ese primer if hay que verificar la condiccion de seleccion de profesor secretaria o nada
        }

        private void BotonCrearEmpleado_Click(object sender, EventArgs e)
        {
            InterfazAltaEmpleado interfaz = new InterfazAltaEmpleado(this);
            interfaz.ShowDialog();
            if (dataGridViewEmpleadoPersona.Visible)
                BotonBuscarEmpleado_Click(sender, e);
        }
    }
}
