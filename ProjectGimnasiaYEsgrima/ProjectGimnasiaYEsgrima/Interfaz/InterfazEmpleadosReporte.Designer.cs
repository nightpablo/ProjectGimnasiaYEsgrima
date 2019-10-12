namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazEmpleadosReporte
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
            this.btnReporteAlfabetico = new System.Windows.Forms.Button();
            this.btnReporteFiltro = new System.Windows.Forms.Button();
            this.cbxDirectivo = new System.Windows.Forms.CheckBox();
            this.cbxSecretaria = new System.Windows.Forms.CheckBox();
            this.cbxProfesor = new System.Windows.Forms.CheckBox();
            this.cbxMantenimiento = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTipoEmpleado = new System.Windows.Forms.Label();
            this.lblTituloReporteEmpleado = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReporteAlfabetico
            // 
            this.btnReporteAlfabetico.Location = new System.Drawing.Point(40, 320);
            this.btnReporteAlfabetico.Name = "btnReporteAlfabetico";
            this.btnReporteAlfabetico.Size = new System.Drawing.Size(200, 56);
            this.btnReporteAlfabetico.TabIndex = 6;
            this.btnReporteAlfabetico.Text = "Generar Reporte Alfabético";
            this.btnReporteAlfabetico.UseVisualStyleBackColor = true;
            this.btnReporteAlfabetico.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReporteFiltro
            // 
            this.btnReporteFiltro.Location = new System.Drawing.Point(16, 200);
            this.btnReporteFiltro.Name = "btnReporteFiltro";
            this.btnReporteFiltro.Size = new System.Drawing.Size(200, 56);
            this.btnReporteFiltro.TabIndex = 5;
            this.btnReporteFiltro.Text = "Generar Reporte con flitro";
            this.btnReporteFiltro.UseVisualStyleBackColor = true;
            this.btnReporteFiltro.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbxDirectivo
            // 
            this.cbxDirectivo.AutoSize = true;
            this.cbxDirectivo.Location = new System.Drawing.Point(232, 120);
            this.cbxDirectivo.Name = "cbxDirectivo";
            this.cbxDirectivo.Size = new System.Drawing.Size(85, 21);
            this.cbxDirectivo.TabIndex = 4;
            this.cbxDirectivo.Text = "Directivo";
            this.cbxDirectivo.UseVisualStyleBackColor = true;
            // 
            // cbxSecretaria
            // 
            this.cbxSecretaria.AutoSize = true;
            this.cbxSecretaria.Location = new System.Drawing.Point(16, 72);
            this.cbxSecretaria.Name = "cbxSecretaria";
            this.cbxSecretaria.Size = new System.Drawing.Size(95, 21);
            this.cbxSecretaria.TabIndex = 1;
            this.cbxSecretaria.Text = "Secretaria";
            this.cbxSecretaria.UseVisualStyleBackColor = true;
            // 
            // cbxProfesor
            // 
            this.cbxProfesor.AutoSize = true;
            this.cbxProfesor.Location = new System.Drawing.Point(232, 72);
            this.cbxProfesor.Name = "cbxProfesor";
            this.cbxProfesor.Size = new System.Drawing.Size(84, 21);
            this.cbxProfesor.TabIndex = 2;
            this.cbxProfesor.Text = "Profesor";
            this.cbxProfesor.UseVisualStyleBackColor = true;
            // 
            // cbxMantenimiento
            // 
            this.cbxMantenimiento.AutoSize = true;
            this.cbxMantenimiento.Location = new System.Drawing.Point(16, 120);
            this.cbxMantenimiento.Name = "cbxMantenimiento";
            this.cbxMantenimiento.Size = new System.Drawing.Size(122, 21);
            this.cbxMantenimiento.TabIndex = 3;
            this.cbxMantenimiento.Text = "Mantenimiento";
            this.cbxMantenimiento.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTipoEmpleado);
            this.panel1.Controls.Add(this.btnReporteFiltro);
            this.panel1.Controls.Add(this.cbxDirectivo);
            this.panel1.Controls.Add(this.cbxMantenimiento);
            this.panel1.Controls.Add(this.cbxSecretaria);
            this.panel1.Controls.Add(this.cbxProfesor);
            this.panel1.Location = new System.Drawing.Point(24, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 268);
            this.panel1.TabIndex = 11;
            // 
            // lblTipoEmpleado
            // 
            this.lblTipoEmpleado.AutoSize = true;
            this.lblTipoEmpleado.Location = new System.Drawing.Point(32, 24);
            this.lblTipoEmpleado.Name = "lblTipoEmpleado";
            this.lblTipoEmpleado.Size = new System.Drawing.Size(137, 17);
            this.lblTipoEmpleado.TabIndex = 6;
            this.lblTipoEmpleado.Text = "Tipos de Empleados";
            // 
            // lblTituloReporteEmpleado
            // 
            this.lblTituloReporteEmpleado.AutoSize = true;
            this.lblTituloReporteEmpleado.Location = new System.Drawing.Point(33, 9);
            this.lblTituloReporteEmpleado.Name = "lblTituloReporteEmpleado";
            this.lblTituloReporteEmpleado.Size = new System.Drawing.Size(153, 17);
            this.lblTituloReporteEmpleado.TabIndex = 6;
            this.lblTituloReporteEmpleado.Text = "Reporte de Empleados";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(488, 240);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(152, 56);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // InterfazEmpleadosReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTituloReporteEmpleado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnReporteAlfabetico);
            this.Name = "InterfazEmpleadosReporte";
            this.Text = "InterfazEmpleados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReporteAlfabetico;
        private System.Windows.Forms.Button btnReporteFiltro;
        private System.Windows.Forms.CheckBox cbxDirectivo;
        private System.Windows.Forms.CheckBox cbxSecretaria;
        private System.Windows.Forms.CheckBox cbxProfesor;
        private System.Windows.Forms.CheckBox cbxMantenimiento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTipoEmpleado;
        private System.Windows.Forms.Label lblTituloReporteEmpleado;
        private System.Windows.Forms.Button btnVolver;
    }
}