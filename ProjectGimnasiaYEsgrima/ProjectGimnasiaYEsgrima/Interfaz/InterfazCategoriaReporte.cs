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
    public partial class InterfazCategoriaReporte : Form
    {
        InterfazFiltroReporte MiVentana;
        public InterfazCategoriaReporte(InterfazFiltroReporte ventana)
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
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloCategoriasReportes);
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
            ControladorCategoria CCategoria = new ControladorCategoria();
            List<ModelCategoria> lista = null;
            lista = CCategoria.BuscarCategoriasTodos()

                .ToList();

            ReportDataSource dt = new ReportDataSource("DataSet1", lista);
            string dir = "ProjectGimnasiaYEsgrima.Utils.ReporteTodosCategoria.rdlc";

            new InterfazGenerarReporte(dt, dir).ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ModelCategoria> lista = null;

            if (((ModelDeporte)cbxDeporte.SelectedItem).IdDeporte == 0
                && cbxBaja.Checked == true
            && cbxActivo.Checked == true
            && cbxCancelado.Checked == true
            && cbxIniciado.Checked ==true
            && cbxPendiente.Checked == true
            && cbxTerminado.Checked == true)
            {
                ControladorCategoria CCategoria = new ControladorCategoria();
             
                lista = CCategoria.BuscarCategoriasTodos().ToList();
               
            }

            else
            {
                
                    ControladorCategoria CCategoria = new ControladorCategoria();

                    lista = CCategoria.BuscarCategoriasTodos()
                    .AsEnumerable()
                    .Where(b => ((ModelDeporte)cbxDeporte.SelectedItem).IdDeporte==0? true : b.Deporte.IdDeporte== ((ModelDeporte)cbxDeporte.SelectedItem).IdDeporte)
                    .Where(b => (cbxBaja.Checked ? true : b.EstadoCategoria != EnumEstadoCategoria.Baja))
                    .Where(b => (cbxCancelado.Checked ? true : b.EstadoCategoria != EnumEstadoCategoria.Cancelado))
                    .Where(b => (cbxActivo.Checked ? true : b.EstadoCategoria != EnumEstadoCategoria.Activo))
                    .Where(b => (cbxIniciado.Checked ? true : b.EstadoCategoria != EnumEstadoCategoria.Iniciado))
                    .Where(b => (cbxPendiente.Checked ? true : b.EstadoCategoria != EnumEstadoCategoria.Pendiente))
                    .Where(b => (cbxTerminado.Checked ? true : b.EstadoCategoria != EnumEstadoCategoria.Terminado))
                    .ToList()
                    ;

                    
                
            }
            ReportDataSource dt = new ReportDataSource("DataSet1", lista);
            string dir = "ProjectGimnasiaYEsgrima.Utils.ReporteTodosCategoria.rdlc";
            new InterfazGenerarReporte(dt, dir).ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        
    }
}
