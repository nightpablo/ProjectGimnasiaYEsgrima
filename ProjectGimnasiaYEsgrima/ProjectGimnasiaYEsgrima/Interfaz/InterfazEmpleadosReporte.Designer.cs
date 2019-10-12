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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReporteAlfabetico
            // 
            this.btnReporteAlfabetico.Location = new System.Drawing.Point(32, 264);
            this.btnReporteAlfabetico.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteAlfabetico.Name = "btnReporteAlfabetico";
            this.btnReporteAlfabetico.Size = new System.Drawing.Size(150, 46);
            this.btnReporteAlfabetico.TabIndex = 6;
            this.btnReporteAlfabetico.Text = "Generar Reporte Alfabético";
            this.btnReporteAlfabetico.UseVisualStyleBackColor = true;
            this.btnReporteAlfabetico.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReporteFiltro
            // 
            this.btnReporteFiltro.Location = new System.Drawing.Point(12, 162);
            this.btnReporteFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporteFiltro.Name = "btnReporteFiltro";
            this.btnReporteFiltro.Size = new System.Drawing.Size(150, 46);
            this.btnReporteFiltro.TabIndex = 5;
            this.btnReporteFiltro.Text = "Generar Reporte con flitro";
            this.btnReporteFiltro.UseVisualStyleBackColor = true;
            this.btnReporteFiltro.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbxDirectivo
            // 
            this.cbxDirectivo.AutoSize = true;
            this.cbxDirectivo.Location = new System.Drawing.Point(174, 98);
            this.cbxDirectivo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxDirectivo.Name = "cbxDirectivo";
            this.cbxDirectivo.Size = new System.Drawing.Size(68, 17);
            this.cbxDirectivo.TabIndex = 4;
            this.cbxDirectivo.Text = "Directivo";
            this.cbxDirectivo.UseVisualStyleBackColor = true;
            // 
            // cbxSecretaria
            // 
            this.cbxSecretaria.AutoSize = true;
            this.cbxSecretaria.Location = new System.Drawing.Point(12, 58);
            this.cbxSecretaria.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSecretaria.Name = "cbxSecretaria";
            this.cbxSecretaria.Size = new System.Drawing.Size(74, 17);
            this.cbxSecretaria.TabIndex = 1;
            this.cbxSecretaria.Text = "Secretaria";
            this.cbxSecretaria.UseVisualStyleBackColor = true;
            // 
            // cbxProfesor
            // 
            this.cbxProfesor.AutoSize = true;
            this.cbxProfesor.Location = new System.Drawing.Point(174, 58);
            this.cbxProfesor.Margin = new System.Windows.Forms.Padding(2);
            this.cbxProfesor.Name = "cbxProfesor";
            this.cbxProfesor.Size = new System.Drawing.Size(65, 17);
            this.cbxProfesor.TabIndex = 2;
            this.cbxProfesor.Text = "Profesor";
            this.cbxProfesor.UseVisualStyleBackColor = true;
            // 
            // cbxMantenimiento
            // 
            this.cbxMantenimiento.AutoSize = true;
            this.cbxMantenimiento.Location = new System.Drawing.Point(12, 98);
            this.cbxMantenimiento.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMantenimiento.Name = "cbxMantenimiento";
            this.cbxMantenimiento.Size = new System.Drawing.Size(95, 17);
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
            this.panel1.Location = new System.Drawing.Point(18, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 218);
            this.panel1.TabIndex = 11;
            // 
            // lblTipoEmpleado
            // 
            this.lblTipoEmpleado.AutoSize = true;
            this.lblTipoEmpleado.Location = new System.Drawing.Point(24, 20);
            this.lblTipoEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoEmpleado.Name = "lblTipoEmpleado";
            this.lblTipoEmpleado.Size = new System.Drawing.Size(103, 13);
            this.lblTipoEmpleado.TabIndex = 6;
            this.lblTipoEmpleado.Text = "Tipos de Empleados";
            // 
            // lblTituloReporteEmpleado
            // 
            this.lblTituloReporteEmpleado.AutoSize = true;
            this.lblTituloReporteEmpleado.Location = new System.Drawing.Point(25, 7);
            this.lblTituloReporteEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloReporteEmpleado.Name = "lblTituloReporteEmpleado";
            this.lblTituloReporteEmpleado.Size = new System.Drawing.Size(115, 13);
            this.lblTituloReporteEmpleado.TabIndex = 6;
            this.lblTituloReporteEmpleado.Text = "Reporte de Empleados";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(366, 195);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(114, 46);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 48);
            this.button1.TabIndex = 12;
            this.button1.Text = "Generar Reporte Entrada/Salida";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // InterfazEmpleadosReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTituloReporteEmpleado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnReporteAlfabetico);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button button1;
    }
}