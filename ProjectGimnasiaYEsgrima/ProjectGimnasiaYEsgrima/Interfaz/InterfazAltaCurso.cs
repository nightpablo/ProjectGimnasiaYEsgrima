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
    public partial class InterfazAltaCurso : Form
    {
        private InterfazListarCurso Padre;

        public InterfazAltaCurso(InterfazListarCurso interfazListaCurso)
        {
            this.Padre = interfazListaCurso;
            InitializeComponent();
            
            ControladorDeporte Cdeporte = new ControladorDeporte();
            List<ModelDeporte> lista = new List<ModelDeporte>();
            lista = Cdeporte.ListarTodosDeportes();

            ComboBoxDeporte.DataSource = lista;
            ComboBoxDeporte.ValueMember = "IdDeporte";
            ComboBoxDeporte.DisplayMember = "Nombre";

            txtNombreCurso.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtImporteMensualCurso);
            txtImporteMensualCurso.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, BotonGuardarCurso);
            DateTimeInicio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, BotonGuardarCurso);
            DateTimeFin.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, BotonGuardarCurso);

            txtNombreCurso.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, txtNombreCurso, 80);
            txtImporteMensualCurso.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumeros(sender,e);
        }

        private void BotonGuardarCurso_Click(object sender, EventArgs e)
        {
            var hayError = false;
            if (txtNombreCurso.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(txtNombreCurso, "El nombre debe ser con carácter entre 3 y 80");
            }
            if (txtImporteMensualCurso.Text.Equals(""))
            {
                hayError = true;
                errorProvider1.SetError(txtImporteMensualCurso, "El importe mensual debe ser un número mayor a cero");
            }
            else errorProvider1.SetError(txtNombreCurso, "");
            /*if (DateTimeFin.Value.CompareTo(DateTimeInicio) < 1)
            {
                hayError = true;
                errorProvider1.SetError(DateTimeInicio, "El dia de comienzo debe ser antes que el dia de fin del curso");
                errorProvider1.SetError(DateTimeFin, "El dia de comienzo debe ser antes que el dia de fin del curso");
            }
            else { errorProvider1.SetError(DateTimeInicio, ""); errorProvider1.SetError(DateTimeFin, ""); }
            */
            if (hayError)
                return;
            
            ControladorCurso un_controlador_curso = new ControladorCurso();
            var resultado =un_controlador_curso.CrearCurso(txtNombreCurso.Text, Int32.Parse(txtImporteMensualCurso.Text), DateTimeInicio.Value, DateTimeFin.Value, ((ModelDeporte)ComboBoxDeporte.SelectedItem).MiDeporte);
            if (resultado > 0)
            {
                Padre.ModificarMensaje("Se ha creado un nuevo CURSO");
                Dispose();
            }
            else if (resultado == -1)
            {
                Padre.ModificarMensaje("Se ha recuperado el CURSO");
                Dispose();
            }
            else if (resultado == -2)
                MessageBox.Show(this, "Ya existe el nombre del CURSO", "Curso");

        }

        private void ComboBoxDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void BotonCancelarCurso_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
    
}
