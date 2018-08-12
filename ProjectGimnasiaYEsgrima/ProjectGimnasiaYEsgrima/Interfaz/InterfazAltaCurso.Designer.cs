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
            this.FechaInicioCurso = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.FechaFinCurso = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.BotonGuardarCurso = new System.Windows.Forms.Button();
            this.BotonCancelarCurso = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(51, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // FechaInicioCurso
            // 
            this.FechaInicioCurso.Location = new System.Drawing.Point(54, 173);
            this.FechaInicioCurso.Name = "FechaInicioCurso";
            this.FechaInicioCurso.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Comienzo Curso";
            // 
            // FechaFinCurso
            // 
            this.FechaFinCurso.Location = new System.Drawing.Point(324, 173);
            this.FechaFinCurso.Name = "FechaFinCurso";
            this.FechaFinCurso.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha Fin Curso";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(133, 83);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(237, 22);
            this.txtNombreCurso.TabIndex = 6;
            // 
            // BotonGuardarCurso
            // 
            this.BotonGuardarCurso.Location = new System.Drawing.Point(103, 448);
            this.BotonGuardarCurso.Name = "BotonGuardarCurso";
            this.BotonGuardarCurso.Size = new System.Drawing.Size(142, 39);
            this.BotonGuardarCurso.TabIndex = 7;
            this.BotonGuardarCurso.Text = "Guardar";
            this.BotonGuardarCurso.UseVisualStyleBackColor = true;
            this.BotonGuardarCurso.Click += new System.EventHandler(this.BotonGuardarCurso_Click);
            // 
            // BotonCancelarCurso
            // 
            this.BotonCancelarCurso.Location = new System.Drawing.Point(352, 448);
            this.BotonCancelarCurso.Name = "BotonCancelarCurso";
            this.BotonCancelarCurso.Size = new System.Drawing.Size(142, 39);
            this.BotonCancelarCurso.TabIndex = 8;
            this.BotonCancelarCurso.Text = "Cancelar";
            this.BotonCancelarCurso.UseVisualStyleBackColor = true;
            // 
            // InterfazAltaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 529);
            this.Controls.Add(this.BotonCancelarCurso);
            this.Controls.Add(this.BotonGuardarCurso);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FechaFinCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaInicioCurso);
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
        private System.Windows.Forms.MonthCalendar FechaInicioCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar FechaFinCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Button BotonGuardarCurso;
        private System.Windows.Forms.Button BotonCancelarCurso;
    }
}