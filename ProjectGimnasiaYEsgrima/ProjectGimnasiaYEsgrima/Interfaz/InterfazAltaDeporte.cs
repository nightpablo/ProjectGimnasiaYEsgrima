﻿using ProjectGimnasiaYEsgrima.Utils;
using ProjectGimnasiaYEsgrima.Controlador;
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
    public partial class InterfazAltaDeporte : Form
    {
        private InterfazListaDeportes Padre;
        public InterfazAltaDeporte(InterfazListaDeportes interfazListaDeportes)
        {
            Padre = interfazListaDeportes;
            InitializeComponent();

            txtNombreDeporte.Focus();
            txtNombreDeporte.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, txtDescripcionDeporte);
            txtDescripcionDeporte.KeyPress += (sender, e) => new CampoConRestriccion().EventoEnterFocus(sender, e, BotonGuardarDeporte);

            txtNombreDeporte.KeyPress += (sender, e) => new CampoConRestriccion().PermiteLetrasYNumerosYSeparadorYLimitador(sender, e, txtNombreDeporte, 50);
            txtDescripcionDeporte.KeyPress += (sender, e) => new CampoConRestriccion().Limitador(sender, e, txtDescripcionDeporte, 500);


        }

        private void BotonGuardarDeporte_Click(object sender, EventArgs e)
        {
            var hayError = false;
            if (txtNombreDeporte.Text.Length < 3) { 
                hayError = true;
                errorProvider1.SetError(txtNombreDeporte, "El nombre debe ser con carácter entre 3 y 50");
            }
            else errorProvider1.SetError(txtNombreDeporte, "");

            if (hayError)
                return;

            ControladorDeporte un_controlador_deporte = new ControladorDeporte();
            var resultado = un_controlador_deporte.CrearDeporte(txtNombreDeporte.Text, txtDescripcionDeporte.Text);
            if ( resultado > 0)
            {
                Padre.ModificarMensaje("Se ha creado un nuevo DEPORTE");
                Dispose();
            }
            else if(resultado == -2)
                MessageBox.Show(this, "Ya existe el nombre del DEPORTE", "Deporte");


        }

        private void BotonCancelarDeporte_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
