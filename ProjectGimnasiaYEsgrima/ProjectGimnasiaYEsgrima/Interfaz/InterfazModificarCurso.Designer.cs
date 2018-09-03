namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazModificarCurso
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
            this.labelModificarCurso = new System.Windows.Forms.Label();
            this.labelModificarCursoDeporte = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.ComboBoxDeporte = new System.Windows.Forms.ComboBox();
            this.labelFechaInicioCurso = new System.Windows.Forms.Label();
            this.DateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.labelFechaFinCurso = new System.Windows.Forms.Label();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.labelModificarCursoNombre = new System.Windows.Forms.Label();
            this.BotonGuardarCurso = new System.Windows.Forms.Button();
            this.BotonCancelarCurso = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelModificarCurso
            // 
            this.labelModificarCurso.AutoSize = true;
            this.labelModificarCurso.Location = new System.Drawing.Point(57, 34);
            this.labelModificarCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModificarCurso.Name = "labelModificarCurso";
            this.labelModificarCurso.Size = new System.Drawing.Size(80, 13);
            this.labelModificarCurso.TabIndex = 1;
            this.labelModificarCurso.Text = "Modificar Curso";
            // 
            // labelModificarCursoDeporte
            // 
            this.labelModificarCursoDeporte.AutoSize = true;
            this.labelModificarCursoDeporte.Location = new System.Drawing.Point(67, 67);
            this.labelModificarCursoDeporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModificarCursoDeporte.Name = "labelModificarCursoDeporte";
            this.labelModificarCursoDeporte.Size = new System.Drawing.Size(45, 13);
            this.labelModificarCursoDeporte.TabIndex = 2;
            this.labelModificarCursoDeporte.Text = "Deporte";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(161, 101);
            this.txtNombreCurso.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(179, 20);
            this.txtNombreCurso.TabIndex = 7;
            // 
            // ComboBoxDeporte
            // 
            this.ComboBoxDeporte.FormattingEnabled = true;
            this.ComboBoxDeporte.Location = new System.Drawing.Point(161, 59);
            this.ComboBoxDeporte.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxDeporte.Name = "ComboBoxDeporte";
            this.ComboBoxDeporte.Size = new System.Drawing.Size(179, 21);
            this.ComboBoxDeporte.TabIndex = 11;
            this.ComboBoxDeporte.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDeporte_SelectedIndexChanged);
            // 
            // labelFechaInicioCurso
            // 
            this.labelFechaInicioCurso.AutoSize = true;
            this.labelFechaInicioCurso.Location = new System.Drawing.Point(57, 173);
            this.labelFechaInicioCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaInicioCurso.Name = "labelFechaInicioCurso";
            this.labelFechaInicioCurso.Size = new System.Drawing.Size(95, 13);
            this.labelFechaInicioCurso.TabIndex = 12;
            this.labelFechaInicioCurso.Text = "Fecha Inicio Curso";
            // 
            // DateTimeInicio
            // 
            this.DateTimeInicio.Location = new System.Drawing.Point(60, 201);
            this.DateTimeInicio.Margin = new System.Windows.Forms.Padding(2);
            this.DateTimeInicio.Name = "DateTimeInicio";
            this.DateTimeInicio.Size = new System.Drawing.Size(151, 20);
            this.DateTimeInicio.TabIndex = 13;
            // 
            // labelFechaFinCurso
            // 
            this.labelFechaFinCurso.AutoSize = true;
            this.labelFechaFinCurso.Location = new System.Drawing.Point(256, 173);
            this.labelFechaFinCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFechaFinCurso.Name = "labelFechaFinCurso";
            this.labelFechaFinCurso.Size = new System.Drawing.Size(84, 13);
            this.labelFechaFinCurso.TabIndex = 14;
            this.labelFechaFinCurso.Text = "Fecha Fin Curso";
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Location = new System.Drawing.Point(256, 201);
            this.dateTimeFin.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(151, 20);
            this.dateTimeFin.TabIndex = 15;
            // 
            // labelModificarCursoNombre
            // 
            this.labelModificarCursoNombre.AutoSize = true;
            this.labelModificarCursoNombre.Location = new System.Drawing.Point(68, 108);
            this.labelModificarCursoNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModificarCursoNombre.Name = "labelModificarCursoNombre";
            this.labelModificarCursoNombre.Size = new System.Drawing.Size(44, 13);
            this.labelModificarCursoNombre.TabIndex = 16;
            this.labelModificarCursoNombre.Text = "Nombre";
            // 
            // BotonGuardarCurso
            // 
            this.BotonGuardarCurso.Location = new System.Drawing.Point(60, 249);
            this.BotonGuardarCurso.Margin = new System.Windows.Forms.Padding(2);
            this.BotonGuardarCurso.Name = "BotonGuardarCurso";
            this.BotonGuardarCurso.Size = new System.Drawing.Size(106, 32);
            this.BotonGuardarCurso.TabIndex = 17;
            this.BotonGuardarCurso.Text = "Guardar";
            this.BotonGuardarCurso.UseVisualStyleBackColor = true;
            this.BotonGuardarCurso.Click += new System.EventHandler(this.BotonGuardarCurso_Click);
            // 
            // BotonCancelarCurso
            // 
            this.BotonCancelarCurso.Location = new System.Drawing.Point(259, 249);
            this.BotonCancelarCurso.Margin = new System.Windows.Forms.Padding(2);
            this.BotonCancelarCurso.Name = "BotonCancelarCurso";
            this.BotonCancelarCurso.Size = new System.Drawing.Size(106, 32);
            this.BotonCancelarCurso.TabIndex = 18;
            this.BotonCancelarCurso.Text = "Cancelar";
            this.BotonCancelarCurso.UseVisualStyleBackColor = true;
            this.BotonCancelarCurso.Click += new System.EventHandler(this.BotonCancelarCurso_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // InterfazModificarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonCancelarCurso);
            this.Controls.Add(this.BotonGuardarCurso);
            this.Controls.Add(this.labelModificarCursoNombre);
            this.Controls.Add(this.dateTimeFin);
            this.Controls.Add(this.labelFechaFinCurso);
            this.Controls.Add(this.DateTimeInicio);
            this.Controls.Add(this.labelFechaInicioCurso);
            this.Controls.Add(this.ComboBoxDeporte);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.labelModificarCursoDeporte);
            this.Controls.Add(this.labelModificarCurso);
            this.Name = "InterfazModificarCurso";
            this.Text = "InterfazModificarCurso";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModificarCurso;
        private System.Windows.Forms.Label labelModificarCursoDeporte;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.ComboBox ComboBoxDeporte;
        private System.Windows.Forms.Label labelFechaInicioCurso;
        private System.Windows.Forms.DateTimePicker DateTimeInicio;
        private System.Windows.Forms.Label labelFechaFinCurso;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.Label labelModificarCursoNombre;
        private System.Windows.Forms.Button BotonGuardarCurso;
        private System.Windows.Forms.Button BotonCancelarCurso;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}