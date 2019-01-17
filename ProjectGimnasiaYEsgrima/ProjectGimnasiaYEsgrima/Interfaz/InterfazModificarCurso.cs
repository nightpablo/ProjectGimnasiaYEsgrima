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
    public partial class InterfazModificarCurso : Form
    {
        private InterfazListaCurso Padre;
        private ModelCurso Curso;
        public InterfazModificarCurso(InterfazListaCurso padre, ModelCurso curso)
        {
            Padre = padre;
            Curso = curso;
            InitializeComponent();
            txtNombreCurso.Text = curso.Nombre;
            dtpInicioCurso.Value = curso.FechaInicio;
            dtpFinCurso.Value = curso.FechaFin;
            txtImporteMensualCurso.Text = curso.Curso.Costo+"";


            ControladorDeporte Cdeporte = new ControladorDeporte();
            List<ModelDeporte> lista = new List<ModelDeporte>();
            lista = Cdeporte.ListarTodosDeportes();

            txtDeporteCurso.Text = curso.Deporte.Nombre;
            txtDeporteCurso.ReadOnly = true;
            txtNombreCurso.ReadOnly = true;
            CargarCamposFocus();
            CargarInterfazBuena();

        }

        private void CargarCamposFocus()
        {
            txtDeporteCurso.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtNombreCurso);
            txtNombreCurso.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtImporteMensualCurso);
            txtImporteMensualCurso.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnGuardarCurso);
            dtpInicioCurso.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnGuardarCurso);
            dtpFinCurso.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnGuardarCurso);

            txtNombreCurso.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, txtNombreCurso, 80);
            txtImporteMensualCurso.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumeros(sender, e);
        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloCurso);
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblDeporteCurso, lblNombreCurso, lblFechaInicioCurso, lblFechaFinCurso, lblImporteMensualCurso);
            interfaz.TransformarTextBoxTextoPersonalizadoTodos(txtNombreCurso, txtImporteMensualCurso);
            interfaz.TransformarTextBoxTextoNoEditablePersonalizado(txtDeporteCurso);
            interfaz.TransformarTextBoxTextoNoEditablePersonalizado(txtNombreCurso);
            interfaz.TransformarDateTimePickerPersonalizado(dtpInicioCurso);
            interfaz.TransformarDateTimePickerPersonalizado(dtpFinCurso);
            interfaz.TransformarBotonPersonalizadoTodos(btnGuardarCurso, btnCancelarCurso);
        }

        private void BotonGuardarCurso_Click(object sender, EventArgs e)
        {
            var hayError = false;
            if (txtNombreCurso.Text.Length < 3)
            {
                hayError = true;
                errorProvider1.SetError(txtNombreCurso, "El nombre debe ser con carácter entre 3 y 80");
            }
            if (txtImporteMensualCurso.Text.Equals("") || Int32.Parse(txtImporteMensualCurso.Text)==0)
            {
                hayError = true;
                errorProvider1.SetError(txtImporteMensualCurso, "El importe mensual debe ser un número mayor a cero");
            }
            else errorProvider1.SetError(txtNombreCurso, "");
            if (hayError)
                return;

            ControladorCurso un_controlador_curso = new ControladorCurso();
            var resultado = un_controlador_curso.ModificarCurso(Curso.IdCurso,txtNombreCurso.Text,Int32.Parse(txtImporteMensualCurso.Text), dtpInicioCurso.Value, dtpFinCurso.Value, Curso.Deporte, Curso.EstadoCurso);
            if (resultado > 0)
            {
                Padre.ModificarMensaje("Se ha modificado el Curso");
                Padre.Actualizar();
                Dispose();
            }
            else if (resultado == -2)
                MyMessageBox.Show(this, "Ya existe el nombre del CURSO", "Curso");

        }

        private void BotonCancelarCurso_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}

