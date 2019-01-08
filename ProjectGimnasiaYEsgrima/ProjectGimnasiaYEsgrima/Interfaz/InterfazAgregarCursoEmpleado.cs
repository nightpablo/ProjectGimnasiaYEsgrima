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
        private InterfazListaCurso Padre;
        private Curso MiCurso;

        public InterfazAgregarCursoEmpleado(InterfazListaCurso padre, Curso curso)
        {
            Padre = padre;
            MiCurso = curso;
            InitializeComponent();

            

            dgvEmpleadoProfesor.AllowUserToAddRows = false;
            dgvEmpleadoProfesor.Visible = false;
            lblInfoProfesor.Text = "";

            CargarCamposFocus();
            CargarInterfazBuena();

        }

        private void CargarCamposFocus()
        {
            txtDNIProfesor.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumerosYLimitador(sender, e, txtDNIProfesor, 8);
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
            interfaz.TransformarTablaBotonesPersonalizadosTodos(AsignarCurso, EliminarCurso);
        }


        private void BotonVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void ActualizarTabla()
        {
            List<ModelEmpleadoPersona> lista = new ControladorEmpleado().ExtraerEmpleadosAVista("", txtApellidoProfesor.Text, txtDNIProfesor.Text, "Profesor");
            lblInfoProfesor.Text = "";
            if (lista.Count == 0)
            {
                lblInfoProfesor.Text = "No hay ningún profesor con estos filtros";
                return;
            }

            dgvEmpleadoProfesor.DataSource = lista;
            if(dgvEmpleadoProfesor.Visible == false)
                dgvEmpleadoProfesor.Visible = true;
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleadoProfesor.Columns[e.ColumnIndex].Name.Equals("AsignarCurso"))
            {
                if (MyMessageBox.Show("¿Seguro que desea Asignar el curso "+MiCurso.Nombre+" al Empleado "+ ((ModelEmpleadoPersona)dgvEmpleadoProfesor.CurrentRow.DataBoundItem).Apellido + ", "+((ModelEmpleadoPersona)dgvEmpleadoProfesor.CurrentRow.DataBoundItem).Nombre+"?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ControladorCurso CCurso = new ControladorCurso();
                    var resultado = CCurso.AsignarEmpleadoAlCurso(((ModelEmpleadoPersona)dgvEmpleadoProfesor.CurrentRow.DataBoundItem).MiEmpleado, MiCurso);
                    if (resultado > 0)
                    {
                        Padre.ModificarMensaje("Se ha asignado un Profesor Al CURSO");
                        Dispose();
                    }
                    else if (resultado == -2)
                    {
                        MyMessageBox.Show(this, "Ya esta asignado el Profesor al CURSO", "Curso");
                    }
                }
                
            }
            else if (dgvEmpleadoProfesor.Columns[e.ColumnIndex].Name.Equals("EliminarCurso"))
            {
                if (MyMessageBox.Show("¿Seguro que desea Eliminar del curso " + MiCurso.Nombre + " al Empleado " + ((ModelEmpleadoPersona)dgvEmpleadoProfesor.CurrentRow.DataBoundItem).Apellido + ", " + ((ModelEmpleadoPersona)dgvEmpleadoProfesor.CurrentRow.DataBoundItem).Nombre + "?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ControladorCurso CCurso = new ControladorCurso();
                    var resultado = CCurso.EliminarEmpleadoDelCurso(((ModelEmpleadoPersona)dgvEmpleadoProfesor.CurrentRow.DataBoundItem).MiEmpleado, MiCurso);
                    if (resultado > 0)
                    {
                        Padre.ModificarMensaje("Se ha eliminado un Profesor Del CURSO");
                        Dispose();
                    }
                    else if (resultado == -2)
                    {
                        MyMessageBox.Show(this, "El Profesor no está asignado al CURSO", "Curso");
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
