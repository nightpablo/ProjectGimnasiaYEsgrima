using Microsoft.Reporting.WinForms;
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
    public partial class InterfazCursoReporte : Form
    {
        InterfazFiltroReporte MiVentana;
        public InterfazCursoReporte(InterfazFiltroReporte ventana)
        {
            MiVentana = ventana;
            InitializeComponent();
            cbxBaja.Checked = true;
            cbxActivo.Checked = true;
            cbxCancelado.Checked = true;
            cbxIniciado.Checked = true;
            cbxPendiente.Checked = true;
            cbxTerminado.Checked = true;

            ControladorDeporte CDeporte = new ControladorDeporte();

            List<ModelDeporte> lista = new List<ModelDeporte>();
            lista = CDeporte.ListarTodosDeportes();
            cbxDeporte.DataSource = lista;
              lista.Insert(0, new ModelDeporte() { IdDeporte = 0, Nombre = "Seleccione un deporte" });
            cbxDeporte.ValueMember = "IdDeporte";
            cbxDeporte.DisplayMember = "Nombre";
            CargarInterfazBuena();
        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloCursosReportes);
            interfaz.TransformarBotonPersonalizadoTodos(btnFiltro, btnAlfabetico,btnVolver);
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblFiltro, lblEstado, lblDeporte);
            interfaz.TransformarComboBoxPersonalizado(cbxDeporte);
            interfaz.TransformarCheckBoxPersonalizado(cbxBaja);
            interfaz.TransformarCheckBoxPersonalizado(cbxActivo);
            interfaz.TransformarCheckBoxPersonalizado(cbxPendiente);
            interfaz.TransformarCheckBoxPersonalizado(cbxIniciado);
            interfaz.TransformarCheckBoxPersonalizado(cbxCancelado);
            interfaz.TransformarCheckBoxPersonalizado(cbxTerminado);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControladorCurso CCurso = new ControladorCurso();
            List<ModelCurso> lista = null;
            lista = CCurso.BuscarCursosTodos()

                .ToList();

            ReportDataSource dt = new ReportDataSource("DataSet1", lista);
            string dir = "ProjectGimnasiaYEsgrima.Utils.ReporteTodosCurso.rdlc";

            new InterfazGenerarReporte(dt, dir).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ModelCurso> lista = null;

            if (((ModelDeporte)cbxDeporte.SelectedItem).IdDeporte == 0
                && cbxBaja.Checked == true
            && cbxActivo.Checked == true
            && cbxCancelado.Checked == true
            && cbxIniciado.Checked ==true
            && cbxPendiente.Checked == true
            && cbxTerminado.Checked == true)
            {
                ControladorCurso CCurso = new ControladorCurso();
             
                lista = CCurso.BuscarCursosTodos().ToList();
               
            }

            else
            {
                
                    ControladorCurso CCurso = new ControladorCurso();

                    lista = CCurso.BuscarCursosTodos()
                    .AsEnumerable()
                    .Where(b => ((ModelDeporte)cbxDeporte.SelectedItem).IdDeporte==0? true : b.Deporte.IdDeporte== ((ModelDeporte)cbxDeporte.SelectedItem).IdDeporte)
                    .Where(b => (cbxBaja.Checked ? true : b.EstadoCurso != EnumEstadoCurso.Baja))
                    .Where(b => (cbxCancelado.Checked ? true : b.EstadoCurso != EnumEstadoCurso.Cancelado))
                    .Where(b => (cbxActivo.Checked ? true : b.EstadoCurso != EnumEstadoCurso.Activo))
                    .Where(b => (cbxIniciado.Checked ? true : b.EstadoCurso != EnumEstadoCurso.Iniciado))
                    .Where(b => (cbxPendiente.Checked ? true : b.EstadoCurso != EnumEstadoCurso.Pendiente))
                    .Where(b => (cbxTerminado.Checked ? true : b.EstadoCurso != EnumEstadoCurso.Terminado))
                    .ToList()
                    ;

                    
                
            }
            ReportDataSource dt = new ReportDataSource("DataSet1", lista);
            string dir = "ProjectGimnasiaYEsgrima.Utils.ReporteTodosCurso.rdlc";
            new InterfazGenerarReporte(dt, dir).ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        
    }
}
