namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazSociosReporte
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
            this.btnReporteFiltro = new System.Windows.Forms.Button();
            this.cbxActivo = new System.Windows.Forms.CheckBox();
            this.cbxAdherente = new System.Windows.Forms.CheckBox();
            this.cbxMenor = new System.Windows.Forms.CheckBox();
            this.cbxVitalicio = new System.Windows.Forms.CheckBox();
            this.btnReporteAlfabetico = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTipoSocio = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTituloReporteSocios = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReporteFiltro
            // 
            this.btnReporteFiltro.Location = new System.Drawing.Point(48, 152);
            this.btnReporteFiltro.Name = "btnReporteFiltro";
            this.btnReporteFiltro.Size = new System.Drawing.Size(224, 48);
            this.btnReporteFiltro.TabIndex = 3;
            this.btnReporteFiltro.Text = "Generar Reporte con filtro";
            this.btnReporteFiltro.UseVisualStyleBackColor = true;
            this.btnReporteFiltro.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxActivo
            // 
            this.cbxActivo.AutoSize = true;
            this.cbxActivo.Location = new System.Drawing.Point(56, 56);
            this.cbxActivo.Name = "cbxActivo";
            this.cbxActivo.Size = new System.Drawing.Size(68, 21);
            this.cbxActivo.TabIndex = 4;
            this.cbxActivo.Text = "Activo";
            this.cbxActivo.UseVisualStyleBackColor = true;
            // 
            // cbxAdherente
            // 
            this.cbxAdherente.AutoSize = true;
            this.cbxAdherente.Location = new System.Drawing.Point(248, 56);
            this.cbxAdherente.Name = "cbxAdherente";
            this.cbxAdherente.Size = new System.Drawing.Size(96, 21);
            this.cbxAdherente.TabIndex = 5;
            this.cbxAdherente.Text = "Adherente";
            this.cbxAdherente.UseVisualStyleBackColor = true;
            // 
            // cbxMenor
            // 
            this.cbxMenor.AutoSize = true;
            this.cbxMenor.Location = new System.Drawing.Point(248, 112);
            this.cbxMenor.Name = "cbxMenor";
            this.cbxMenor.Size = new System.Drawing.Size(70, 21);
            this.cbxMenor.TabIndex = 5;
            this.cbxMenor.Text = "Menor";
            this.cbxMenor.UseVisualStyleBackColor = true;
            // 
            // cbxVitalicio
            // 
            this.cbxVitalicio.AutoSize = true;
            this.cbxVitalicio.Location = new System.Drawing.Point(56, 112);
            this.cbxVitalicio.Name = "cbxVitalicio";
            this.cbxVitalicio.Size = new System.Drawing.Size(78, 21);
            this.cbxVitalicio.TabIndex = 5;
            this.cbxVitalicio.Text = "Vitalicio";
            this.cbxVitalicio.UseVisualStyleBackColor = true;
            // 
            // btnReporteAlfabetico
            // 
            this.btnReporteAlfabetico.Location = new System.Drawing.Point(72, 280);
            this.btnReporteAlfabetico.Name = "btnReporteAlfabetico";
            this.btnReporteAlfabetico.Size = new System.Drawing.Size(224, 48);
            this.btnReporteAlfabetico.TabIndex = 6;
            this.btnReporteAlfabetico.Text = "Generar Reporte Alfabetico";
            this.btnReporteAlfabetico.UseVisualStyleBackColor = true;
            this.btnReporteAlfabetico.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTipoSocio);
            this.panel1.Controls.Add(this.cbxActivo);
            this.panel1.Controls.Add(this.btnReporteFiltro);
            this.panel1.Controls.Add(this.cbxAdherente);
            this.panel1.Controls.Add(this.cbxMenor);
            this.panel1.Controls.Add(this.cbxVitalicio);
            this.panel1.Location = new System.Drawing.Point(16, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 216);
            this.panel1.TabIndex = 7;
            // 
            // lblTipoSocio
            // 
            this.lblTipoSocio.AutoSize = true;
            this.lblTipoSocio.Location = new System.Drawing.Point(24, 16);
            this.lblTipoSocio.Name = "lblTipoSocio";
            this.lblTipoSocio.Size = new System.Drawing.Size(102, 17);
            this.lblTipoSocio.TabIndex = 6;
            this.lblTipoSocio.Text = "Tipo de Socios";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(520, 192);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(128, 48);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblTituloReporteSocios
            // 
            this.lblTituloReporteSocios.AutoSize = true;
            this.lblTituloReporteSocios.Location = new System.Drawing.Point(16, 0);
            this.lblTituloReporteSocios.Name = "lblTituloReporteSocios";
            this.lblTituloReporteSocios.Size = new System.Drawing.Size(125, 17);
            this.lblTituloReporteSocios.TabIndex = 9;
            this.lblTituloReporteSocios.Text = "Reporte de Socios";
            // 
            // InterfazSociosReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTituloReporteSocios);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReporteAlfabetico);
            this.Name = "InterfazSociosReporte";
            this.Text = "ReporteSocios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReporteFiltro;
        private System.Windows.Forms.CheckBox cbxActivo;
        private System.Windows.Forms.CheckBox cbxAdherente;
        private System.Windows.Forms.CheckBox cbxMenor;
        private System.Windows.Forms.CheckBox cbxVitalicio;
        private System.Windows.Forms.Button btnReporteAlfabetico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTipoSocio;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTituloReporteSocios;
    }
}