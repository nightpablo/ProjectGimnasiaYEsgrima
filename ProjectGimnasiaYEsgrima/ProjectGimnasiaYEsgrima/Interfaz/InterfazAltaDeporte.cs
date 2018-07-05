using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGimnasiaYEsgrima
{
    public partial class InterfazDeporte : Form
    {
        public InterfazDeporte()
        {
            InitializeComponent();
        }

        private void BotonGuardarDeporte_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreDeporte.Text;
            string descripcion = txtDescripcionDeporte.Text;

            ControladorDeporte un_controlador_deporte = new ControladorDeporte();
            if(un_controlador_deporte.CrearDeporte(nombre, descripcion) > 0)
            {
                MessageBox.Show(this, "Se ha creado un nuevo DEPORTE", "Deporte");
            }

        }
    }
}
