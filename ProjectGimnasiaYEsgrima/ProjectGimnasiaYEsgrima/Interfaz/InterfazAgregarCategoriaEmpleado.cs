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
    public partial class InterfazAgregarCategoriaEmpleado : Form
    {
        private InterfazListaCategoria Padre;
        private Categoria MiCategoria;

        public InterfazAgregarCategoriaEmpleado(InterfazListaCategoria padre, Categoria categoria)
        {
            Padre = padre;
            MiCategoria = categoria;
            InitializeComponent();

            

            dgvEmpleadoProfesor.AllowUserToAddRows = false;
            dgvEmpleadoProfesor.Visible = false;
            lblInfoProfesor.Text = "";

            CargarCamposFocus();
            CargarInterfazBuena();

        }

        private void CargarCamposFocus()
        {
            txtDNIProfesor.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumerosYLimitador(sender, e, txtDNIProfesor, 10);
            txtApellidoProfesor.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYSeparadorYLimitador(sender, e, txtApellidoProfesor, 50);

            txtDNIProfesor.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtApellidoProfesor);
            txtApellidoProfesor.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnBuscar);

        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloProfesor);
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblApellidoProfesor, lblDNIProfesor,lblInfoProfesor);
            interfaz.TransformarTextBoxTextoPersonalizadoTodos(txtApellidoProfesor,txtDNIProfesor);
            interfaz.TransformarBotonPersonalizadoTodos(btnBuscar, btnVolver);
            interfaz.TransformarTablaPersonalizado(dgvEmpleadoProfesor);
            interfaz.TransformarTablaBotonesPersonalizadosTodos(AsignarCategoria, EliminarCategoria);
        }


        private void BotonVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ActualizarTabla()
        {
            List<ModelEmpleadoPersona> lista = new ControladorEmpleado().ListarTodosEmpleadosPorFiltro("", txtApellidoProfesor.Text, txtDNIProfesor.Text, "Profesor");
            lblInfoProfesor.Text = "";
            if (lista.Count == 0)
            {
                lblInfoProfesor.Text = "NO EXISTE NINGÚN EMPLEADO CON LOS FILTROS SELECCIONADOS";
                return;
            }

            dgvEmpleadoProfesor.DataSource = lista;
            dgvEmpleadoProfesor.Refresh();
            if(dgvEmpleadoProfesor.Visible == false)
                dgvEmpleadoProfesor.Visible = true;
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleadoProfesor.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.Equals("Asignar Categoría"))
            {
                if (MyMessageBox.Show("¿Seguro que desea Asignar la Categoría "+MiCategoria.Nombre+" al Empleado "+ ((ModelEmpleadoPersona)dgvEmpleadoProfesor.CurrentRow.DataBoundItem).Apellido + ", "+((ModelEmpleadoPersona)dgvEmpleadoProfesor.CurrentRow.DataBoundItem).Nombre+"?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ControladorCategoria CCategoria = new ControladorCategoria();
                    var resultado = CCategoria.AsignarEmpleadoAlCategoria(((ModelEmpleadoPersona)dgvEmpleadoProfesor.CurrentRow.DataBoundItem).MiEmpleado, MiCategoria);
                    if (resultado > 0)
                    {
                        Padre.ModificarMensaje("Se ha asignado un Profesor a la Categoría");
                        Dispose();
                    }
                    else if (resultado == -2)
                    {
                        MyMessageBox.Show(this, "Ya esta asignado el Profesor a la Categoría", "Categoria");
                    }
                }
                
            }
            else if (dgvEmpleadoProfesor.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.Equals("Eliminar Categoria"))
            {
                if (MyMessageBox.Show("¿Seguro que desea Eliminar de la Categoria " + MiCategoria.Nombre + " al Empleado " + ((ModelEmpleadoPersona)dgvEmpleadoProfesor.CurrentRow.DataBoundItem).Apellido + ", " + ((ModelEmpleadoPersona)dgvEmpleadoProfesor.CurrentRow.DataBoundItem).Nombre + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ControladorCategoria CCategoria = new ControladorCategoria();
                    var resultado = CCategoria.EliminarEmpleadoDelCategoria(((ModelEmpleadoPersona)dgvEmpleadoProfesor.CurrentRow.DataBoundItem).MiEmpleado, MiCategoria);
                    if (resultado > 0)
                    {
                        Padre.ModificarMensaje("Se ha eliminado el Profesor de la Categoría");
                        Dispose();
                    }
                    else if (resultado == -2)
                    {
                        MyMessageBox.Show(this, "El Profesor no está asignado a la Categoría", "Categoria");
                    }
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void dgvEmpleadoProfesor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(dgvEmpleadoProfesor.Columns[e.ColumnIndex].Name.Equals("AsignarCategoria"))
            {
                
                if (new ControladorCategoria().ExisteEmpleadoEnCategoria(((ModelEmpleadoPersona)dgvEmpleadoProfesor.Rows[e.RowIndex].DataBoundItem).MiEmpleado, MiCategoria))
                {
                    e.Value = "";
    
                }
            }
            else if(dgvEmpleadoProfesor.Columns[e.ColumnIndex].Name.Equals("EliminarCategoria"))
            {
                if (!new ControladorCategoria().ExisteEmpleadoEnCategoria(((ModelEmpleadoPersona)dgvEmpleadoProfesor.Rows[e.RowIndex].DataBoundItem).MiEmpleado, MiCategoria))
                {
                    e.Value = "";
                }
            }
            
        }
        
    }
}
