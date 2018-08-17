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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.BotonGuardarCurso = new System.Windows.Forms.Button();
            this.BotonCancelarCurso = new System.Windows.Forms.Button();
            this.DateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.DateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxDeporte = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta Curso";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Comienzo Curso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha Fin Curso";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(133, 110);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(237, 22);
            this.txtNombreCurso.TabIndex = 6;
            // 
            // BotonGuardarCurso
            // 
            this.BotonGuardarCurso.Location = new System.Drawing.Point(118, 234);
            this.BotonGuardarCurso.Name = "BotonGuardarCurso";
            this.BotonGuardarCurso.Size = new System.Drawing.Size(142, 39);
            this.BotonGuardarCurso.TabIndex = 7;
            this.BotonGuardarCurso.Text = "Guardar";
            this.BotonGuardarCurso.UseVisualStyleBackColor = true;
            this.BotonGuardarCurso.Click += new System.EventHandler(this.BotonGuardarCurso_Click);
            // 
            // BotonCancelarCurso
            // 
            this.BotonCancelarCurso.Location = new System.Drawing.Point(367, 234);
            this.BotonCancelarCurso.Name = "BotonCancelarCurso";
            this.BotonCancelarCurso.Size = new System.Drawing.Size(142, 39);
            this.BotonCancelarCurso.TabIndex = 8;
            this.BotonCancelarCurso.Text = "Cancelar";
            this.BotonCancelarCurso.UseVisualStyleBackColor = true;
            // 
            // DateTimeInicio
            // 
            this.DateTimeInicio.Location = new System.Drawing.Point(69, 187);
            this.DateTimeInicio.Name = "DateTimeInicio";
            this.DateTimeInicio.Size = new System.Drawing.Size(200, 22);
            this.DateTimeInicio.TabIndex = 9;
            // 
            // DateTimeFin
            // 
            this.DateTimeFin.Location = new System.Drawing.Point(370, 185);
            this.DateTimeFin.Name = "DateTimeFin";
            this.DateTimeFin.Size = new System.Drawing.Size(200, 22);
            this.DateTimeFin.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Deporte";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ComboBoxDeporte
            // 
            this.ComboBoxDeporte.FormattingEnabled = true;
            this.ComboBoxDeporte.Location = new System.Drawing.Point(133, 73);
            this.ComboBoxDeporte.Name = "ComboBoxDeporte";
            this.ComboBoxDeporte.Size = new System.Drawing.Size(237, 24);
            this.ComboBoxDeporte.TabIndex = 10;
            // 
            // InterfazAltaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 285);
            this.Controls.Add(this.ComboBoxDeporte);
            this.Controls.Add(this.DateTimeFin);
            this.Controls.Add(this.DateTimeInicio);
            this.Controls.Add(this.BotonCancelarCurso);
            this.Controls.Add(this.BotonGuardarCurso);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InterfazAltaCurso";
            this.Text = "InterfazAltaCurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Button BotonGuardarCurso;
        private System.Windows.Forms.Button BotonCancelarCurso;
        private System.Windows.Forms.DateTimePicker DateTimeInicio;
        private System.Windows.Forms.DateTimePicker DateTimeFin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxDeporte;
    }
}