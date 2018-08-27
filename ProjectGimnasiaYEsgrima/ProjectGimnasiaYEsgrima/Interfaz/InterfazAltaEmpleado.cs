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
        public InterfazAltaEmpleado()
        {
            InitializeComponent();
            labelDeportes.Visible = false;
            ComboboxDeportes.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((string)ComboboxTipoEmpleado.SelectedItem).Equals("Profesor"))
            {
                labelDeportes.Visible = true;
                ComboboxDeportes.Visible = true;
            }
            else
            {
                labelDeportes.Visible = false;
                ComboboxDeportes.Visible = false;
            }
        }
    }
}
