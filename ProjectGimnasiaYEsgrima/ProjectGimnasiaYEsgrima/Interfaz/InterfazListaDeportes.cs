using ProjectGimnasiaYEsgrima;
using ProjectGimnasiaYEsgrima.Utils;
using ProjectGimnasiaYEsgrima.Controlador;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    public partial class InterfazListaDeportes : Form
    {
        

        public InterfazListaDeportes()
        {
            InitializeComponent();

            this.txtNombreDeporte.Focus();
            this.txtNombreDeporte.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtDescripcionDeporte);
            this.txtNombreDeporte.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, txtNombreDeporte, 50);
            this.txtDescripcionDeporte.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, BotonBuscar);
            this.txtDescripcionDeporte.KeyPress += (sender, e) => new CampoConRestriccion().Limitador(sender, e, txtDescripcionDeporte, 500);
            
            dataGridViewDeporte.AllowUserToAddRows = false;
            dataGridViewDeporte.Visible = false;

            this.ModificarMensaje("");

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ControladorDeporte controladorDeporte = new ControladorDeporte();
            List<Deporte> lista;
            deporteBindingSource.Clear();
            
            if (txtNombreDeporte.Text.ToString().Equals("") && txtDescripcionDeporte.Text.ToString().Equals(""))
            {
                lista = controladorDeporte.ListarTodosDeportes();   
            }
            else
            {
                lista = controladorDeporte.ListarTodosDeportesPorFiltros(txtNombreDeporte.Text.ToString(), txtDescripcionDeporte.Text.ToString());
            }
            
            foreach (var i in lista)
            {
                deporteBindingSource.Add(i);

            }


            dataGridViewDeporte.Visible = true;
            //dataGridViewDeporte.Columns[0].Visible = false;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDeporte.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {
                InterfazModificarDeporte interfazModificar = new InterfazModificarDeporte(this, (Deporte)dataGridViewDeporte.CurrentRow.DataBoundItem);
                interfazModificar.ShowDialog();
                
            }

            else if (dataGridViewDeporte.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                if(MessageBox.Show("¿Seguro que desea Eliminar este deporte?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ControladorDeporte un_controlador_deporte = new ControladorDeporte();
                    if (un_controlador_deporte.EliminarDeporte((Deporte)dataGridViewDeporte.CurrentRow.DataBoundItem) > 0)
                    {
                        this.ModificarMensaje("Se ha eliminado el DEPORTE");
                        //MessageBox.Show(this, "Se ha eliminado el DEPORTE", "Deporte");
                    }
                }
            }
            Button1_Click(sender, e);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            InterfazAltaDeporte interfazDeporte = new InterfazAltaDeporte(this);
            interfazDeporte.ShowDialog();
            if(dataGridViewDeporte.Visible)
                Button1_Click(sender, e);
        }
        
        public void ModificarMensaje(String entrada)
        {
            LabelInfoDeporte.Text = entrada;
        }
    }
}
