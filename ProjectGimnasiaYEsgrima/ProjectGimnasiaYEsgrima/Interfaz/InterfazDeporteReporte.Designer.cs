namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazDeporteReporte
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
            this.cbxAlta = new System.Windows.Forms.CheckBox();
            this.cbxBaja = new System.Windows.Forms.CheckBox();
            this.lblEstadoDeporte = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloReporteDeporte = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReporteAlfabetico
            // 
            this.btnReporteAlfabetico.Location = new System.Drawing.Point(56, 296);
            this.btnReporteAlfabetico.Name = "btnReporteAlfabetico";
            this.btnReporteAlfabetico.Size = new System.Drawing.Size(272, 56);
            this.btnReporteAlfabetico.TabIndex = 4;
            this.btnReporteAlfabetico.Text = "Generar Reporte Alfabético";
            this.btnReporteAlfabetico.UseVisualStyleBackColor = true;
            this.btnReporteAlfabetico.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReporteFiltro
            // 
            this.btnReporteFiltro.Location = new System.Drawing.Point(24, 160);
            this.btnReporteFiltro.Name = "btnReporteFiltro";
            this.btnReporteFiltro.Size = new System.Drawing.Size(288, 56);
            this.btnReporteFiltro.TabIndex = 3;
            this.btnReporteFiltro.Text = "Generar Reporte con Filltro";
            this.btnReporteFiltro.UseVisualStyleBackColor = true;
            this.btnReporteFiltro.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbxAlta
            // 
            this.cbxAlta.AutoSize = true;
            this.cbxAlta.Location = new System.Drawing.Point(104, 80);
            this.cbxAlta.Name = "cbxAlta";
            this.cbxAlta.Size = new System.Drawing.Size(68, 21);
            this.cbxAlta.TabIndex = 1;
            this.cbxAlta.Text = "Activo";
            this.cbxAlta.UseVisualStyleBackColor = true;
            // 
            // cbxBaja
            // 
            this.cbxBaja.AutoSize = true;
            this.cbxBaja.Location = new System.Drawing.Point(272, 80);
            this.cbxBaja.Name = "cbxBaja";
            this.cbxBaja.Size = new System.Drawing.Size(58, 21);
            this.cbxBaja.TabIndex = 2;
            this.cbxBaja.Text = "Baja";
            this.cbxBaja.UseVisualStyleBackColor = true;
            // 
            // lblEstadoDeporte
            // 
            this.lblEstadoDeporte.AutoSize = true;
            this.lblEstadoDeporte.Location = new System.Drawing.Point(16, 16);
            this.lblEstadoDeporte.Name = "lblEstadoDeporte";
            this.lblEstadoDeporte.Size = new System.Drawing.Size(130, 17);
            this.lblEstadoDeporte.TabIndex = 4;
            this.lblEstadoDeporte.Text = "Estado del Deporte";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblEstadoDeporte);
            this.panel1.Controls.Add(this.btnReporteFiltro);
            this.panel1.Controls.Add(this.cbxBaja);
            this.panel1.Controls.Add(this.cbxAlta);
            this.panel1.Location = new System.Drawing.Point(32, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 232);
            this.panel1.TabIndex = 5;
            // 
            // lblTituloReporteDeporte
            // 
            this.lblTituloReporteDeporte.AutoSize = true;
            this.lblTituloReporteDeporte.Location = new System.Drawing.Point(33, 17);
            this.lblTituloReporteDeporte.Name = "lblTituloReporteDeporte";
            this.lblTituloReporteDeporte.Size = new System.Drawing.Size(141, 17);
            this.lblTituloReporteDeporte.TabIndex = 4;
            this.lblTituloReporteDeporte.Text = "Reporte de Deportes";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(495, 216);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(129, 47);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, -72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Reporte de Deportes";
            // 
            // InterfazDeporteReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloReporteDeporte);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReporteAlfabetico);
            this.Name = "InterfazDeporteReporte";
            this.Text = "InterfazDeporteReporte";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReporteAlfabetico;
        private System.Windows.Forms.Button btnReporteFiltro;
        private System.Windows.Forms.CheckBox cbxAlta;
        private System.Windows.Forms.CheckBox cbxBaja;
        private System.Windows.Forms.Label lblEstadoDeporte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTituloReporteDeporte;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
    }
}