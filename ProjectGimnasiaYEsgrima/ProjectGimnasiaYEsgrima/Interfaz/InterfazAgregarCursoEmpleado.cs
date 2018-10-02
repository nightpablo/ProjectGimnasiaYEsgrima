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
    public partial class InterfazAgregarCursoEmpleado : Form
    {
        private InterfazListaEmpleado Padre;
        private Empleado Emp;

        public InterfazAgregarCursoEmpleado(InterfazListaEmpleado padre, Empleado emp)
        {
            Padre = padre;
            Emp = emp;
            InitializeComponent();

            ActualizarTabla();
        }

        private void BotonAgregarCurso_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) { 
                MessageBox.Show("No hay cursos para asignar");
                return;
            }
            new ControladorCurso().AsignarEmpleadoAlCurso(Emp, ((ModelCurso)comboBox1.SelectedItem).Curso);
            ActualizarTabla();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ActualizarTabla()
        {
            var lista = new ControladorCurso().ListarTodosCursosDelEmpleado(Emp);
            dataGridViewListaCursosEmpleado.DataSource = lista;

            comboBox1.DataSource = new ControladorCurso().ListarTodosCursos().AsEnumerable().Where(c => !lista.Select(d => d.IdCurso).Contains(c.IdCurso)).ToList();
        }

        private void DataGridViewListaCursosEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea Eliminar este Curso?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ControladorCurso controladorCurso = new ControladorCurso();
                /*if (controladorCurso.EliminarCurso((Curso)DataGridListarCursos.CurrentRow.DataBoundItem) > 0)
                {
                    this.ModificarMensaje("Se ha eliminado el CURSO");
                    ActualizarTabla();
                }*/

            }
        }
    }
}
