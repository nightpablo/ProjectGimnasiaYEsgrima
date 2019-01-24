﻿namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazCursoReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxDeporte = new System.Windows.Forms.ComboBox();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.cbxTerminado = new System.Windows.Forms.CheckBox();
            this.cbxCancelado = new System.Windows.Forms.CheckBox();
            this.cbxIniciado = new System.Windows.Forms.CheckBox();
            this.cbxPendiente = new System.Windows.Forms.CheckBox();
            this.cbxActivo = new System.Windows.Forms.CheckBox();
            this.cbxBaja = new System.Windows.Forms.CheckBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnAlfabetico = new System.Windows.Forms.Button();
            this.lblTituloCursosReportes = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxDeporte
            // 
            this.cbxDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDeporte.FormattingEnabled = true;
            this.cbxDeporte.Location = new System.Drawing.Point(136, 48);
            this.cbxDeporte.Name = "cbxDeporte";
            this.cbxDeporte.Size = new System.Drawing.Size(121, 24);
            this.cbxDeporte.TabIndex = 0;
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Location = new System.Drawing.Point(32, 48);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(59, 17);
            this.lblDeporte.TabIndex = 2;
            this.lblDeporte.Text = "Deporte";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(24, 8);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(117, 17);
            this.lblFiltro.TabIndex = 3;
            this.lblFiltro.Text = "Fiiltros de Cursos";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblFiltro);
            this.panel1.Controls.Add(this.lblDeporte);
            this.panel1.Controls.Add(this.cbxDeporte);
            this.panel1.Location = new System.Drawing.Point(16, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 360);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFiltro);
            this.panel2.Controls.Add(this.cbxTerminado);
            this.panel2.Controls.Add(this.cbxCancelado);
            this.panel2.Controls.Add(this.cbxIniciado);
            this.panel2.Controls.Add(this.cbxPendiente);
            this.panel2.Controls.Add(this.cbxActivo);
            this.panel2.Controls.Add(this.cbxBaja);
            this.panel2.Controls.Add(this.lblEstado);
            this.panel2.Location = new System.Drawing.Point(16, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 224);
            this.panel2.TabIndex = 6;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(16, 144);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(328, 48);
            this.btnFiltro.TabIndex = 12;
            this.btnFiltro.Text = "Generar Reporte con filtro";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxTerminado
            // 
            this.cbxTerminado.AutoSize = true;
            this.cbxTerminado.Location = new System.Drawing.Point(336, 80);
            this.cbxTerminado.Name = "cbxTerminado";
            this.cbxTerminado.Size = new System.Drawing.Size(98, 21);
            this.cbxTerminado.TabIndex = 11;
            this.cbxTerminado.Text = "Terminado";
            this.cbxTerminado.UseVisualStyleBackColor = true;
            // 
            // cbxCancelado
            // 
            this.cbxCancelado.AutoSize = true;
            this.cbxCancelado.Location = new System.Drawing.Point(168, 80);
            this.cbxCancelado.Name = "cbxCancelado";
            this.cbxCancelado.Size = new System.Drawing.Size(97, 21);
            this.cbxCancelado.TabIndex = 10;
            this.cbxCancelado.Text = "Cancelado";
            this.cbxCancelado.UseVisualStyleBackColor = true;
            // 
            // cbxIniciado
            // 
            this.cbxIniciado.AutoSize = true;
            this.cbxIniciado.Location = new System.Drawing.Point(8, 80);
            this.cbxIniciado.Name = "cbxIniciado";
            this.cbxIniciado.Size = new System.Drawing.Size(78, 21);
            this.cbxIniciado.TabIndex = 9;
            this.cbxIniciado.Text = "Iniciado";
            this.cbxIniciado.UseVisualStyleBackColor = true;
            // 
            // cbxPendiente
            // 
            this.cbxPendiente.AutoSize = true;
            this.cbxPendiente.Location = new System.Drawing.Point(336, 40);
            this.cbxPendiente.Name = "cbxPendiente";
            this.cbxPendiente.Size = new System.Drawing.Size(94, 21);
            this.cbxPendiente.TabIndex = 8;
            this.cbxPendiente.Text = "Pendiente";
            this.cbxPendiente.UseVisualStyleBackColor = true;
            // 
            // cbxActivo
            // 
            this.cbxActivo.AutoSize = true;
            this.cbxActivo.Location = new System.Drawing.Point(168, 40);
            this.cbxActivo.Name = "cbxActivo";
            this.cbxActivo.Size = new System.Drawing.Size(68, 21);
            this.cbxActivo.TabIndex = 7;
            this.cbxActivo.Text = "Activo";
            this.cbxActivo.UseVisualStyleBackColor = true;
            // 
            // cbxBaja
            // 
            this.cbxBaja.AutoSize = true;
            this.cbxBaja.Location = new System.Drawing.Point(8, 40);
            this.cbxBaja.Name = "cbxBaja";
            this.cbxBaja.Size = new System.Drawing.Size(58, 21);
            this.cbxBaja.TabIndex = 6;
            this.cbxBaja.Text = "Baja";
            this.cbxBaja.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(16, 8);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 17);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado";
            // 
            // btnAlfabetico
            // 
            this.btnAlfabetico.Location = new System.Drawing.Point(48, 408);
            this.btnAlfabetico.Name = "btnAlfabetico";
            this.btnAlfabetico.Size = new System.Drawing.Size(328, 48);
            this.btnAlfabetico.TabIndex = 5;
            this.btnAlfabetico.Text = "Generar Reporte Alfabetico";
            this.btnAlfabetico.UseVisualStyleBackColor = true;
            this.btnAlfabetico.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTituloCursosReportes
            // 
            this.lblTituloCursosReportes.AutoSize = true;
            this.lblTituloCursosReportes.Location = new System.Drawing.Point(16, 8);
            this.lblTituloCursosReportes.Name = "lblTituloCursosReportes";
            this.lblTituloCursosReportes.Size = new System.Drawing.Size(127, 17);
            this.lblTituloCursosReportes.TabIndex = 6;
            this.lblTituloCursosReportes.Text = "Reporte de Cursos";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(489, 289);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(159, 48);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // InterfazCursoReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTituloCursosReportes);
            this.Controls.Add(this.btnAlfabetico);
            this.Controls.Add(this.panel1);
            this.Name = "InterfazCursoReporte";
            this.Text = "InterfazCursoReporte";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDeporte;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlfabetico;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.CheckBox cbxTerminado;
        private System.Windows.Forms.CheckBox cbxCancelado;
        private System.Windows.Forms.CheckBox cbxIniciado;
        private System.Windows.Forms.CheckBox cbxPendiente;
        private System.Windows.Forms.CheckBox cbxActivo;
        private System.Windows.Forms.CheckBox cbxBaja;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTituloCursosReportes;
        private System.Windows.Forms.Button btnVolver;
    }
}