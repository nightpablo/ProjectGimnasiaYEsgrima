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
    public partial class InterfazAltaEmpleado : Form
    {
        public List<Deporte> listaDeportes = new List<Deporte>();
        //public var selected = new List<Deporte>();

        public ControladorDeporte CDeporte = new ControladorDeporte();

        public InterfazAltaEmpleado()
        {
            InitializeComponent();
            labelDeportes.Visible = false;
            checkedListBox1.Visible = false;

            ControladorDeporte Cdeporte = new ControladorDeporte();
            List<Deporte> lista = new List<Deporte>();
            lista = Cdeporte.ListarTodosDeportes();

            this.checkedListBox1.DataSource = lista.ToList();
            this.checkedListBox1.DisplayMember = "Nombre";
            this.checkedListBox1.ValueMember = "";
            foreach (var item in this.checkedListBox1.CheckedItems)
            {
                Deporte deporte = (Deporte)(item);
                MessageBox.Show(deporte.Nombre + Environment.NewLine);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((string)ComboboxTipoEmpleado.SelectedItem).Equals("Profesor"))
            {
                labelDeportes.Visible = true;
                checkedListBox1.Visible = true;
            }
            else
            {
                labelDeportes.Visible = false;
                checkedListBox1.Visible = false;
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {     
    /*           for (int x = 0; x <= checkedListBox1.CheckedItems.Count - 1; x++)
            {
             listaDeportes.Add(CDeporte.BuscarDeportePorClavesUnicas(checkedListBox1.CheckedItems[x].ToString()));
            }*/
            
            foreach (int index in checkedListBox1.SelectedIndices)
            {
                listaDeportes.Add((Deporte)checkedListBox1.Items[index]);
            }

        }

        public void botonGuardarEmpleado_Click(object sender, EventArgs e)
        {
            ControladorEmpleado Cempleado = new ControladorEmpleado();

            if (((string)ComboboxTipoEmpleado.SelectedItem).Equals("Secretaria"))
            {
                Cempleado.crearEmpleado(textBoxNombreEmpleado.Text, textBoxApellidoEmpleado.Text, dateTimeNacimiento.Value,Convert.ToInt32(textBoxDocumento.Text), textBoxDescripcion.Text, dateTimeInicioEmpleado.Value);
            }
            else
            {
                Cempleado.crearProfesor(textBoxNombreEmpleado.Text, textBoxApellidoEmpleado.Text, dateTimeNacimiento.Value, Convert.ToInt32(textBoxDocumento.Text), textBoxDescripcion.Text, dateTimeInicioEmpleado.Value,listaDeportes);
            }
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
