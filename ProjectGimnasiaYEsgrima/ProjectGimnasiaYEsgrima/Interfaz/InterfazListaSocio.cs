﻿using Microsoft.Reporting.WinForms;
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
    public partial class InterfazListaSocio : Form
    {
        public InterfazPrincipal MiVentana;
        public InterfazListaSocio(InterfazPrincipal ventana)
        {
            MiVentana = ventana;
            InitializeComponent();
            dataGridViewSocioPersona.AllowUserToAddRows = false;
            dataGridViewSocioPersona.Visible = false;
            lblInfoSocio.Text = "";
            CargarCamposFocus();
            CargarInterfazBuena();

        }

        private void CargarCamposFocus()
        {
            txtNombreSocio.Focus();
            txtNombreSocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnBuscarSocio);
            txtApellidoSocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnBuscarSocio);
            txtDNISocio.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, btnBuscarSocio);

            txtNombreSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYSeparadorYLimitador(sender, e, txtNombreSocio, 50);
            txtApellidoSocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYSeparadorYLimitador(sender, e, txtApellidoSocio, 50);
            txtDNISocio.KeyPress += (sender, e) => new CampoConRestriccion().PermiteNumerosYLimitador(sender, e, txtDNISocio, 8);

        }

        private void CargarInterfazBuena()
        {
            InterfazBuena interfaz = new InterfazBuena();
            interfaz.TransformarVentanaPersonalizado(this);
            interfaz.TransformarTituloVentanaPersonalizado(labelTituloVentana);
            interfaz.TransformarLabelTextoPersonalizadoTodos(lblNombreSocio, lblApellidoSocio, lblDNISocio, lblInfoSocio);
            interfaz.TransformarTextBoxTextoPersonalizadoTodos(txtNombreSocio, txtApellidoSocio, txtDNISocio);
            interfaz.TransformarBotonPersonalizadoTodos(btnBuscarSocio, btnCrearSocio, btnVolver,btnEjecutarProcesoGeneral);
            interfaz.TransformarTablaPersonalizado(dataGridViewSocioPersona);
            interfaz.TransformarTablaBotonesPersonalizadosTodos(Modificar, Eliminar,InscribirCategoria,CuponPago,EmitirCarnet);

        }



        private void BotonBuscarSocio_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        public void Actualizar()
        {
            ControladorSocio CSocio = new ControladorSocio();
            dataGridViewSocioPersona.Visible = true;
            List<ModelSocioPersona> lista = null;
            if (txtNombreSocio.Text.Equals("") && txtApellidoSocio.Text.Equals("") && txtDNISocio.Text.Equals(""))
            {
                lista = CSocio.ListarTodosSocios();

            }
            else
            {
                lista = CSocio.ListarTodosSociosPorFiltro(txtNombreSocio.Text, txtApellidoSocio.Text,
                    txtDNISocio.Text);
            }

            if (lista.Count == 0)
            {
                ModificarMensaje("NO EXISTE NINGÚN SOCIO CON LOS FILTROS SELECCIONADOS");
                return;
            }
            else if (lblInfoSocio.Text.Equals("NO EXISTE NINGÚN SOCIO CON LOS FILTROS SELECCIONADOS"))
            {
                ModificarMensaje("");
            }
            dataGridViewSocioPersona.DataSource = lista;
        }

        private void DataGridViewSocioPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSocioPersona.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {
                AbrirOtraVentana<InterfazModificarSocio>(new InterfazModificarSocio(this, (ModelSocioPersona)dataGridViewSocioPersona.CurrentRow.DataBoundItem));
                if (dataGridViewSocioPersona.Visible)
                    BotonBuscarSocio_Click(sender, e);
            }
            else if (dataGridViewSocioPersona.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                if (MyMessageBox.Show("¿Está seguro que desea eliminar este Socio?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ControladorSocio CSocio = new ControladorSocio();
                    if (CSocio.EliminarSocio(((ModelSocioPersona)dataGridViewSocioPersona.CurrentRow.DataBoundItem).MiSocio) > 0)
                    {
                        ModificarMensaje("El SOCIO ha sido eliminado con ÉXITO");
                        dataGridViewSocioPersona.DataSource = CSocio.ListarTodosSociosPorFiltro(txtNombreSocio.Text, txtApellidoSocio.Text,
                    txtDNISocio.Text);
                    }
                }

            }
            else if (dataGridViewSocioPersona.Columns[e.ColumnIndex].Name.Equals("CuponPago"))
            {
                AbrirOtraVentana<InterfazEmisionCuponPago>(new InterfazEmisionCuponPago(this, ((ModelSocioPersona)dataGridViewSocioPersona.CurrentRow.DataBoundItem).MiSocio));
            }
            else if (dataGridViewSocioPersona.Columns[e.ColumnIndex].Name.Equals("EmitirCarnet"))
            {
                AbrirOtraVentana<InterfazEmitirCarnet>(new InterfazEmitirCarnet(this, (ModelSocioPersona)dataGridViewSocioPersona.CurrentRow.DataBoundItem));
            }
            else if (dataGridViewSocioPersona.Columns[e.ColumnIndex].Name.Equals("InscribirCategoria"))
            {
                if(new ControladorCategoria().ListarTodosCategorias().Count == 0) {
                    MyMessageBox.Show(this, "Debe existir alguna categoría activa", "No hay categorías");
                    return;
                }
                AbrirOtraVentana<InterfazInscribirSocioCategoria>(new InterfazInscribirSocioCategoria(this, (ModelSocioPersona)dataGridViewSocioPersona.CurrentRow.DataBoundItem));
            }


        }
        public void ModificarMensaje(string v)
        {
            lblInfoSocio.Text = v;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BotonCrearSocio_Click(object sender, EventArgs e)
        {
            if (new ControladorSocio().UltimoValorInicialClub()==null)
            {
                MyMessageBox.Show(this, "No se ha definido un monto inicial del club", "Socio");
                return;
            }
            AbrirOtraVentana<InterfazAltaSocio>(new InterfazAltaSocio(this));
            if (dataGridViewSocioPersona.Visible)
                BotonBuscarSocio_Click(sender, e);
        }

        private void AbrirOtraVentana<T>(Object Formhijo)
        {

            Form fh = MiVentana.VentanaContenedor.Controls.OfType<T>().FirstOrDefault() as Form;
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
            MiVentana.VentanaContenedor.Controls.Add(fh);
            MiVentana.VentanaContenedor.Tag = fh;
            fh.Show();
            AbrirOtraVentana<T>(fh);
        }

        private void BtnVolver_Click_1(object sender, EventArgs e)
        {
            MiVentana.CargarLogin();
            Dispose();
        }

        private void BtnGenerarProceso_Click(object sender, EventArgs e)
        {
            string[] lista = { "Enero", "Febrero", "Marzo", "Abril", "Mayo" ,"Junio" , "Julio", "Agosto"
            , "Septiembre", "Octubre", "Noviembre", "Diciembre"};
            Object[] resultado = MyMessageBox.ShowComboBox("Seleccione el mes que desea generar el proceso", "Mensaje", lista, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ((DialogResult)resultado[0] == DialogResult.OK && (int)resultado[1]!=-1)
            {
                
                new ControladorSocio().EjecutarProcesoCuponesGeneral((int)resultado[1]);

                GenerarReporteCupones((int)resultado[1]);
            }
            
        }
        private void GenerarReporteCupones(int mes)
        {
            ControladorSocio controladorSocio = new ControladorSocio();
            List<ModelSocioPersona> socios = controladorSocio.ListarTodosSocios();
            List<ModelImpresionCuponSocio> listacuponesOrdenados;
            List<ModelImpresionCuponSocio> todoscupones1 = new List<ModelImpresionCuponSocio>();
            List<ModelImpresionCuponSocio> todoscupones2 = new List<ModelImpresionCuponSocio>();
            List<ModelCuponSocio> listacuponsocio;

            int k = 0;
            foreach (var i in socios)
            {
                listacuponsocio = controladorSocio.ListarCuotaSocios(i.MiSocio,mes+1);
                listacuponesOrdenados = new List<ModelImpresionCuponSocio>();
                foreach (var j in listacuponsocio)
                {
                    if (j.MiCategoria == null)
                        listacuponesOrdenados.Insert(0, new ModelImpresionCuponSocio(i, j));
                    else
                        listacuponesOrdenados.Add(new ModelImpresionCuponSocio(i,j));
                }
                if(k%2==0)
                    todoscupones1.AddRange(listacuponesOrdenados);
                else
                    todoscupones2.AddRange(listacuponesOrdenados);
                k++;
            }

            AbrirOtraVentana<InterfazGeneradorDeCupones>(new InterfazGeneradorDeCupones(this,todoscupones1,todoscupones2));

        }

        private void InterfazListaSocio_FormClosing(object sender, FormClosingEventArgs e)
        {
            MiVentana.CargarLogin();
            Dispose();
        }
    }

}
