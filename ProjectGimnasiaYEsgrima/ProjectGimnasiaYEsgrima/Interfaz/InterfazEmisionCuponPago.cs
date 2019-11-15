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
    public partial class InterfazEmisionCuponPago : Form
    {
        InterfazListaSocio MiVentana;
        Socio MiSocio;
        public InterfazEmisionCuponPago(InterfazListaSocio ventana, Socio socio)
        {
            MiVentana = ventana;
            MiSocio = socio;
            InitializeComponent();
            dgvListaCuponesSocio.AllowUserToAddRows = false;
            CargarInterfazBuena();
            ActualizarTabla();
            foreach (DataGridViewRow i in dgvListaCuponesSocio.Rows)
            {
                i.Cells["Confirmación"].Value = true;

            }
            cbxFechaEmisionInicial.SelectedIndex = 0;
            cbxFechaEmisionFinal.SelectedIndex = 11;
        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(lblTituloCuponSocio);
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblFechaEmisionInicial, lblFechaEmisionFinal);
            interfaz.TransformarComboBoxPersonalizado(cbxFechaEmisionInicial);
            interfaz.TransformarComboBoxPersonalizado(cbxFechaEmisionFinal);
            interfaz.TransformarCheckBoxPersonalizado(cbxPagados);
            interfaz.TransformarBotonPersonalizadoTodos(btnPagar, btnVolver);
            interfaz.TransformarTablaPersonalizado(dgvListaCuponesSocio);
            interfaz.TransformarTablaBotonesPersonalizados(Anular);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void InterfazEmisionCuponPago_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {
            
            List<ModelCuponSocio> lista = new ControladorSocio().ListarCuotaSocios(MiSocio);
            lista = lista.AsEnumerable()
                .Where(b => b.FechaEmision.Month >= cbxFechaEmisionInicial.SelectedIndex+1)
                .Where(b => b.FechaEmision.Month <= cbxFechaEmisionFinal.SelectedIndex+1)
                .Where(b => (!cbxPagados.Checked ? b.Estado == EnumEstadoCuotaSocio.NoPagado : b.Estado != EnumEstadoCuotaSocio.NoPagado))
                
                .ToList();

            dgvListaCuponesSocio.DataSource = lista;

            foreach (DataGridViewRow i in dgvListaCuponesSocio.Rows) {
                if (((ModelCuponSocio)i.DataBoundItem).Estado != EnumEstadoCuotaSocio.NoPagado) 
                    i.Cells["Confirmación"].ReadOnly = true;

            }
            lblPrueba.Text = lista.Count()+"";

        }

        private void cbxFechaEmisionInicial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cbxFechaEmisionInicial.SelectedIndex <= cbxFechaEmisionFinal.SelectedIndex))
                cbxFechaEmisionFinal.SelectedIndex = cbxFechaEmisionInicial.SelectedIndex;
            ActualizarTabla();
        }

        private void cbxFechaEmisionFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(cbxFechaEmisionInicial.SelectedIndex <= cbxFechaEmisionFinal.SelectedIndex))
                cbxFechaEmisionInicial.SelectedIndex = cbxFechaEmisionFinal.SelectedIndex;
            ActualizarTabla();
        }

        private void cbxPagados_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void dgvListaCuponesSocio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((ModelCuponSocio)dgvListaCuponesSocio.CurrentRow.DataBoundItem).MiCuota.Estado == EnumEstadoCuotaSocio.Pagado || ((ModelCuponSocio)dgvListaCuponesSocio.CurrentRow.DataBoundItem).MiCuota.Estado == EnumEstadoCuotaSocio.Anulado) return;
            if (dgvListaCuponesSocio.Columns[e.ColumnIndex].Name.Equals("Anular"))
            {
                if (MyMessageBox.Show("¿Esta seguro que desea Anular esta Cuota?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ControladorSocio controladorSocio = new ControladorSocio();
                    if (controladorSocio.AnularCuotaSocio(((ModelCuponSocio)dgvListaCuponesSocio.CurrentRow.DataBoundItem).MiCuota)>0){
                        MyMessageBox.Show(this, "Se anuló la cuota", "Cuota Socio");
                        ActualizarTabla();
                    }
                }
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {


            

            List<ModelCuponSocio> lista = new List<ModelCuponSocio>();
            var socio = new ControladorSocio().ExtraerSocioAVista(MiSocio);
            foreach (DataGridViewRow row in dgvListaCuponesSocio.Rows)
            {
                if (row.Cells["Confirmación"].Value != null && (bool)row.Cells["Confirmación"].Value)
                {
                    lista.Add((ModelCuponSocio)row.DataBoundItem);
                    
                }
            }
            if (lista.Count == 0) { MyMessageBox.Show(this, "No se ha seleccionado ninguna cuota", "Cuota Socio"); return; }

            List<ModelImpresionCuponSocio> listacuponesOrdenados = new List<ModelImpresionCuponSocio>();
            foreach (var j in lista)
            {
                if (j.MiCategoria == null)
                    listacuponesOrdenados.Insert(0, new ModelImpresionCuponSocio(socio, j));
                else
                    listacuponesOrdenados.Add(new ModelImpresionCuponSocio(socio, j));
            }

            double montototal = 0;
            foreach(var j in lista)
            {
                montototal += j.Importe; 
            }

            if(MyMessageBox.Show("El monto total de la cuota es de $"+montototal+". ¿Desea realizar el pago?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK){
                new ControladorSocio().PagarCuponSocio(lista);
                if (MyMessageBox.Show("Se ha realizado el pago correspondiente, ¿Desea imprimir el cupón de pago?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    AbrirOtraVentana<InterfazGeneradorDeCupones>(new InterfazGeneradorDeCupones(MiVentana, listacuponesOrdenados, new List<ModelImpresionCuponSocio>()));
                }
                ActualizarTabla();
            }
        }
        private void AbrirOtraVentana<T>(Object Formhijo)
        {

            Form fh = MiVentana.MiVentana.Controls.OfType<T>().FirstOrDefault() as Form;
            if (fh != null)
            {
                //Si la instancia esta minimizada la dejamos en su estado normal
                if (fh.WindowState == FormWindowState.Minimized)
                {
                    fh.WindowState = FormWindowState.Normal;
                }
                //Si la instancia existe la pongo en primer plano
                fh.BringToFront();
                return;
            }

            fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            MiVentana.MiVentana.Controls.Add(fh);
            MiVentana.MiVentana.Tag = fh;
            fh.Show();
            AbrirOtraVentana<T>(fh);
        }
    }
}