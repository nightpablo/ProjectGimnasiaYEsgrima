using System;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazAltaCurso
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
            this.components = new System.ComponentModel.Container();
            this.labelAltaCurso = new System.Windows.Forms.Label();
            this.labelAltaCursoNombre = new System.Windows.Forms.Label();
            this.labelFechaInicioCurso = new System.Windows.Forms.Label();
            this.labelFechaFinCurso = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.BotonGuardarCurso = new System.Windows.Forms.Button();
            this.BotonCancelarCurso = new System.Windows.Forms.Button();
            this.DateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.DateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.labelAltaCursoDeporte = new System.Windows.Forms.Label();
            this.ComboBoxDeporte = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtImporteMensualCurso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAltaCurso
            // 
            this.labelAltaCurso.AutoSize = true;
            this.labelAltaCurso.Location = new System.Drawing.Point(51, 30);
            this.labelAltaCurso.Name = "labelAltaCurso";
            this.labelAltaCurso.Size = new System.Drawing.Size(73, 17);
            this.labelAltaCurso.TabIndex = 0;
            this.labelAltaCurso.Text = "Alta Curso";
            this.labelAltaCurso.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelAltaCursoNombre
            // 
            this.labelAltaCursoNombre.AutoSize = true;
            this.labelAltaCursoNombre.Location = new System.Drawing.Point(66, 113);
            this.labelAltaCursoNombre.Name = "labelAltaCursoNombre";
            this.labelAltaCursoNombre.Size = new System.Drawing.Size(67, 17);
            this.labelAltaCursoNombre.TabIndex = 1;
            this.labelAltaCursoNombre.Text = "Nombre *";
            // 
            // labelFechaInicioCurso
            // 
            this.labelFechaInicioCurso.AutoSize = true;
            this.labelFechaInicioCurso.Location = new System.Drawing.Point(51, 184);
            this.labelFechaInicioCurso.Name = "labelFechaInicioCurso";
            this.labelFechaInicioCurso.Size = new System.Drawing.Size(133, 17);
            this.labelFechaInicioCurso.TabIndex = 3;
            this.labelFechaInicioCurso.Text = "Fecha Inicio Curso *";
            // 
            // labelFechaFinCurso
            // 
            this.labelFechaFinCurso.AutoSize = true;
            this.labelFechaFinCurso.Location = new System.Drawing.Point(349, 184);
            this.labelFechaFinCurso.Name = "labelFechaFinCurso";
            this.labelFechaFinCurso.Size = new System.Drawing.Size(120, 17);
            this.labelFechaFinCurso.TabIndex = 5;
            this.labelFechaFinCurso.Text = "Fecha Fin Curso *";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(136, 110);
            this.txtNombreCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(237, 22);
            this.txtNombreCurso.TabIndex = 6;
            // 
            // BotonGuardarCurso
            // 
            this.BotonGuardarCurso.Location = new System.Drawing.Point(117, 256);
            this.BotonGuardarCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonGuardarCurso.Name = "BotonGuardarCurso";
            this.BotonGuardarCurso.Size = new System.Drawing.Size(141, 39);
            this.BotonGuardarCurso.TabIndex = 7;
            this.BotonGuardarCurso.Text = "Guardar";
            this.BotonGuardarCurso.UseVisualStyleBackColor = true;
            this.BotonGuardarCurso.Click += new System.EventHandler(this.BotonGuardarCurso_Click);
            // 
            // BotonCancelarCurso
            // 
            this.BotonCancelarCurso.Location = new System.Drawing.Point(367, 256);
            this.BotonCancelarCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonCancelarCurso.Name = "BotonCancelarCurso";
            this.BotonCancelarCurso.Size = new System.Drawing.Size(141, 39);
            this.BotonCancelarCurso.TabIndex = 8;
            this.BotonCancelarCurso.Text = "Cancelar";
            this.BotonCancelarCurso.UseVisualStyleBackColor = true;
            this.BotonCancelarCurso.Click += new System.EventHandler(this.BotonCancelarCurso_Click);
            // 
            // DateTimeInicio
            // 
            this.DateTimeInicio.Location = new System.Drawing.Point(69, 209);
            this.DateTimeInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimeInicio.Name = "DateTimeInicio";
            this.DateTimeInicio.Size = new System.Drawing.Size(200, 22);
            this.DateTimeInicio.TabIndex = 9;
            // 
            // DateTimeFin
            // 
            this.DateTimeFin.Location = new System.Drawing.Point(371, 207);
            this.DateTimeFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTimeFin.Name = "DateTimeFin";
            this.DateTimeFin.Size = new System.Drawing.Size(200, 22);
            this.DateTimeFin.TabIndex = 9;
            // 
            // labelAltaCursoDeporte
            // 
            this.labelAltaCursoDeporte.AutoSize = true;
            this.labelAltaCursoDeporte.Location = new System.Drawing.Point(65, 76);
            this.labelAltaCursoDeporte.Name = "labelAltaCursoDeporte";
            this.labelAltaCursoDeporte.Size = new System.Drawing.Size(68, 17);
            this.labelAltaCursoDeporte.TabIndex = 1;
            this.labelAltaCursoDeporte.Text = "Deporte *";
            this.labelAltaCursoDeporte.Click += new System.EventHandler(this.label5_Click);
            // 
            // ComboBoxDeporte
            // 
            this.ComboBoxDeporte.FormattingEnabled = true;
            this.ComboBoxDeporte.Location = new System.Drawing.Point(136, 73);
            this.ComboBoxDeporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxDeporte.Name = "ComboBoxDeporte";
            this.ComboBoxDeporte.Size = new System.Drawing.Size(237, 24);
            this.ComboBoxDeporte.TabIndex = 10;
            this.ComboBoxDeporte.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDeporte_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtImporteMensualCurso
            // 
            this.txtImporteMensualCurso.Location = new System.Drawing.Point(136, 147);
            this.txtImporteMensualCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImporteMensualCurso.Name = "txtImporteMensualCurso";
            this.txtImporteMensualCurso.Size = new System.Drawing.Size(237, 22);
            this.txtImporteMensualCurso.TabIndex = 12;
            this.txtImporteMensualCurso.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Importe Mensual *";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "* Los campos son obligatorios";
            // 
            // InterfazAltaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImporteMensualCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxDeporte);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.DateTimeInicio);
            this.Controls.Add(this.DateTimeFin);
            this.Controls.Add(this.BotonGuardarCurso);
            this.Controls.Add(this.BotonCancelarCurso);
            this.Controls.Add(this.labelFechaFinCurso);
            this.Controls.Add(this.labelFechaInicioCurso);
            this.Controls.Add(this.labelAltaCursoDeporte);
            this.Controls.Add(this.labelAltaCursoNombre);
            this.Controls.Add(this.labelAltaCurso);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InterfazAltaCurso";
            this.Text = "InterfazAltaCurso";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label labelAltaCurso;
        private System.Windows.Forms.Label labelAltaCursoNombre;
        private System.Windows.Forms.Label labelFechaInicioCurso;
        private System.Windows.Forms.Label labelFechaFinCurso;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Button BotonGuardarCurso;
        private System.Windows.Forms.Button BotonCancelarCurso;
        private System.Windows.Forms.DateTimePicker DateTimeInicio;
        private System.Windows.Forms.DateTimePicker DateTimeFin;
        private System.Windows.Forms.Label labelAltaCursoDeporte;
        private System.Windows.Forms.ComboBox ComboBoxDeporte;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtImporteMensualCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}