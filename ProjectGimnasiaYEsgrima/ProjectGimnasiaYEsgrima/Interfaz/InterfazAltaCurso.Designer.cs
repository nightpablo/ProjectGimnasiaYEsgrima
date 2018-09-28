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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAltaCurso
            // 
            this.labelAltaCurso.AutoSize = true;
            this.labelAltaCurso.Location = new System.Drawing.Point(38, 24);
            this.labelAltaCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAltaCurso.Name = "labelAltaCurso";
            this.labelAltaCurso.Size = new System.Drawing.Size(55, 13);
            this.labelAltaCurso.TabIndex = 0;
            this.labelAltaCurso.Text = "Alta Curso";
            this.labelAltaCurso.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelAltaCursoNombre
            // 
            this.labelAltaCursoNombre.AutoSize = true;
            this.labelAltaCursoNombre.Location = new System.Drawing.Point(38, 93);
            this.labelAltaCursoNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAltaCursoNombre.Name = "labelAltaCursoNombre";
            this.labelAltaCursoNombre.Size = new System.Drawing.Size(44, 13);
            this.labelAltaCursoNombre.TabIndex = 1;
            this.labelAltaCursoNombre.Text = "Nombre";
            // 
            // labelFechaInicioCurso
            // 
            this.labelFechaInicioCurso.AutoSize = true;
            this.labelFechaInicioCurso.Location = new System.Drawing.Point(38, 132);
            this.labelFechaInicioCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaInicioCurso.Name = "labelFechaInicioCurso";
            this.labelFechaInicioCurso.Size = new System.Drawing.Size(95, 13);
            this.labelFechaInicioCurso.TabIndex = 3;
            this.labelFechaInicioCurso.Text = "Fecha Inicio Curso";
            // 
            // labelFechaFinCurso
            // 
            this.labelFechaFinCurso.AutoSize = true;
            this.labelFechaFinCurso.Location = new System.Drawing.Point(262, 132);
            this.labelFechaFinCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaFinCurso.Name = "labelFechaFinCurso";
            this.labelFechaFinCurso.Size = new System.Drawing.Size(84, 13);
            this.labelFechaFinCurso.TabIndex = 5;
            this.labelFechaFinCurso.Text = "Fecha Fin Curso";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(100, 89);
            this.txtNombreCurso.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(179, 20);
            this.txtNombreCurso.TabIndex = 6;
            // 
            // BotonGuardarCurso
            // 
            this.BotonGuardarCurso.Location = new System.Drawing.Point(88, 190);
            this.BotonGuardarCurso.Margin = new System.Windows.Forms.Padding(2);
            this.BotonGuardarCurso.Name = "BotonGuardarCurso";
            this.BotonGuardarCurso.Size = new System.Drawing.Size(106, 32);
            this.BotonGuardarCurso.TabIndex = 7;
            this.BotonGuardarCurso.Text = "Guardar";
            this.BotonGuardarCurso.UseVisualStyleBackColor = true;
            this.BotonGuardarCurso.Click += new System.EventHandler(this.BotonGuardarCurso_Click);
            // 
            // BotonCancelarCurso
            // 
            this.BotonCancelarCurso.Location = new System.Drawing.Point(275, 190);
            this.BotonCancelarCurso.Margin = new System.Windows.Forms.Padding(2);
            this.BotonCancelarCurso.Name = "BotonCancelarCurso";
            this.BotonCancelarCurso.Size = new System.Drawing.Size(106, 32);
            this.BotonCancelarCurso.TabIndex = 8;
            this.BotonCancelarCurso.Text = "Cancelar";
            this.BotonCancelarCurso.UseVisualStyleBackColor = true;
            this.BotonCancelarCurso.Click += new System.EventHandler(this.BotonCancelarCurso_Click);
            // 
            // DateTimeInicio
            // 
            this.DateTimeInicio.Location = new System.Drawing.Point(52, 152);
            this.DateTimeInicio.Margin = new System.Windows.Forms.Padding(2);
            this.DateTimeInicio.Name = "DateTimeInicio";
            this.DateTimeInicio.Size = new System.Drawing.Size(151, 20);
            this.DateTimeInicio.TabIndex = 9;
            // 
            // DateTimeFin
            // 
            this.DateTimeFin.Location = new System.Drawing.Point(278, 150);
            this.DateTimeFin.Margin = new System.Windows.Forms.Padding(2);
            this.DateTimeFin.Name = "DateTimeFin";
            this.DateTimeFin.Size = new System.Drawing.Size(151, 20);
            this.DateTimeFin.TabIndex = 9;
            // 
            // labelAltaCursoDeporte
            // 
            this.labelAltaCursoDeporte.AutoSize = true;
            this.labelAltaCursoDeporte.Location = new System.Drawing.Point(38, 61);
            this.labelAltaCursoDeporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAltaCursoDeporte.Name = "labelAltaCursoDeporte";
            this.labelAltaCursoDeporte.Size = new System.Drawing.Size(45, 13);
            this.labelAltaCursoDeporte.TabIndex = 1;
            this.labelAltaCursoDeporte.Text = "Deporte";
            this.labelAltaCursoDeporte.Click += new System.EventHandler(this.label5_Click);
            // 
            // ComboBoxDeporte
            // 
            this.ComboBoxDeporte.FormattingEnabled = true;
            this.ComboBoxDeporte.Location = new System.Drawing.Point(100, 59);
            this.ComboBoxDeporte.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxDeporte.Name = "ComboBoxDeporte";
            this.ComboBoxDeporte.Size = new System.Drawing.Size(179, 21);
            this.ComboBoxDeporte.TabIndex = 10;
            this.ComboBoxDeporte.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDeporte_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // InterfazAltaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 232);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}