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
    public partial class InterfazAgregarCursoEmpleado : Form
    {
        private InterfazListarCurso Padre;
        private Curso MiCurso;

        public InterfazAgregarCursoEmpleado(InterfazListarCurso padre, Curso curso)
        {
            Padre = padre;
            MiCurso = curso;
            InitializeComponent();

            txtDNIEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumerosYLimitador(sender, e, txtDNIEmpleado, 8);
            txtApellidoEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYSeparadorYLimitador(sender, e, txtApellidoEmpleado, 50);

            txtDNIEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtApellidoEmpleado);
            txtApellidoEmpleado.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnBuscar);

            dataGridViewEmpleadoProfesor.AllowUserToAddRows = false;
            dataGridViewEmpleadoProfesor.Visible = false;
            LabelInfo.Text = "";
        }
        

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ActualizarTabla()
        {
            List<ModelEmpleadoPersona> lista = new ControladorEmpleado().ExtraerEmpleadosAVista("", txtApellidoEmpleado.Text, txtDNIEmpleado.Text, "Profesor");
            LabelInfo.Text = "";
            if (lista.Count == 0)
            {
                LabelInfo.Text = "No hay ningún profesor con estos filtros";
                return;
            }

            dataGridViewEmpleadoProfesor.DataSource = lista;
            if(dataGridViewEmpleadoProfesor.Visible == false)
                dataGridViewEmpleadoProfesor.Visible = true;
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewEmpleadoProfesor.Columns[e.ColumnIndex].Name.Equals("AsignarCurso"))
            {
                if (MessageBox.Show("¿Seguro que desea Asignar el curso "+MiCurso.Nombre+" al Empleado "+ ((ModelEmpleadoPersona)dataGridViewEmpleadoProfesor.CurrentRow.DataBoundItem).Apellido + ", "+((ModelEmpleadoPersona)dataGridViewEmpleadoProfesor.CurrentRow.DataBoundItem).Nombre+"?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ControladorCurso CCurso = new ControladorCurso();
                    var resultado = CCurso.AsignarEmpleadoAlCurso(((ModelEmpleadoPersona)dataGridViewEmpleadoProfesor.CurrentRow.DataBoundItem).MiEmpleado, MiCurso);
                    if (resultado > 0)
                    {
                        Padre.ModificarMensaje("Se ha asignado un Profesor Al CURSO");
                        Dispose();
                    }
                    else if (resultado == -2)
                    {
                        MessageBox.Show(this, "Ya esta asignado el Profesor al CURSO", "Curso");
                    }
                }
                
            }
            else if (dataGridViewEmpleadoProfesor.Columns[e.ColumnIndex].Name.Equals("EliminarCurso"))
            {
                if (MessageBox.Show("¿Seguro que desea Eliminar del curso " + MiCurso.Nombre + " al Empleado " + ((ModelEmpleadoPersona)dataGridViewEmpleadoProfesor.CurrentRow.DataBoundItem).Apellido + ", " + ((ModelEmpleadoPersona)dataGridViewEmpleadoProfesor.CurrentRow.DataBoundItem).Nombre + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ControladorCurso CCurso = new ControladorCurso();
                    var resultado = CCurso.EliminarEmpleadoDelCurso(((ModelEmpleadoPersona)dataGridViewEmpleadoProfesor.CurrentRow.DataBoundItem).MiEmpleado, MiCurso);
                    if (resultado > 0)
                    {
                        Padre.ModificarMensaje("Se ha eliminado un Profesor Del CURSO");
                        Dispose();
                    }
                    else if (resultado == -2)
                    {
                        MessageBox.Show(this, "El Profesor no está asignado al CURSO", "Curso");
                    }
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
        }


    }
}
