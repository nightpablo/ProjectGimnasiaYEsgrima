using System.Windows.Forms;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazIngresosReporte
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
            this.lblTituloReporteIngreso = new System.Windows.Forms.Label();
            this.lblReportePeriodo = new System.Windows.Forms.Label();
            this.cbxMesInicio = new System.Windows.Forms.ComboBox();
            this.lblMesInicio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpAño1 = new System.Windows.Forms.DateTimePicker();
            this.lblAño1 = new System.Windows.Forms.Label();
            this.btnReporteAnual = new System.Windows.Forms.Button();
            this.cbxMesFin = new System.Windows.Forms.ComboBox();
            this.lblMesFin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpAño2 = new System.Windows.Forms.DateTimePicker();
            this.btnReporteMensual = new System.Windows.Forms.Button();
            this.lblAño2 = new System.Windows.Forms.Label();
            this.cbxMes = new System.Windows.Forms.ComboBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblReporteMensual = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloReporteIngreso
            // 
            this.lblTituloReporteIngreso.AutoSize = true;
            this.lblTituloReporteIngreso.Location = new System.Drawing.Point(56, 16);
            this.lblTituloReporteIngreso.Name = "lblTituloReporteIngreso";
            this.lblTituloReporteIngreso.Size = new System.Drawing.Size(137, 17);
            this.lblTituloReporteIngreso.TabIndex = 0;
            this.lblTituloReporteIngreso.Text = "Reporte de Ingresos";
            // 
            // lblReportePeriodo
            // 
            this.lblReportePeriodo.AutoSize = true;
            this.lblReportePeriodo.Location = new System.Drawing.Point(24, 8);
            this.lblReportePeriodo.Name = "lblReportePeriodo";
            this.lblReportePeriodo.Size = new System.Drawing.Size(137, 17);
            this.lblReportePeriodo.TabIndex = 1;
            this.lblReportePeriodo.Text = "Reporte por Período";
            // 
            // cbxMesInicio
            // 
            this.cbxMesInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMesInicio.FormattingEnabled = true;
            this.cbxMesInicio.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbxMesInicio.Location = new System.Drawing.Point(248, 32);
            this.cbxMesInicio.Name = "cbxMesInicio";
            this.cbxMesInicio.Size = new System.Drawing.Size(121, 24);
            this.cbxMesInicio.TabIndex = 1;
            this.cbxMesInicio.SelectedIndexChanged += new System.EventHandler(this.cbxMesInicio_SelectedIndexChanged);
            // 
            // lblMesInicio
            // 
            this.lblMesInicio.AutoSize = true;
            this.lblMesInicio.Location = new System.Drawing.Point(24, 40);
            this.lblMesInicio.Name = "lblMesInicio";
            this.lblMesInicio.Size = new System.Drawing.Size(163, 17);
            this.lblMesInicio.TabIndex = 3;
            this.lblMesInicio.Text = "Seleccione mes de inicio";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpAño1);
            this.panel1.Controls.Add(this.lblAño1);
            this.panel1.Controls.Add(this.btnReporteAnual);
            this.panel1.Controls.Add(this.cbxMesFin);
            this.panel1.Controls.Add(this.lblMesFin);
            this.panel1.Controls.Add(this.lblMesInicio);
            this.panel1.Controls.Add(this.cbxMesInicio);
            this.panel1.Controls.Add(this.lblReportePeriodo);
            this.panel1.Location = new System.Drawing.Point(24, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 160);
            this.panel1.TabIndex = 2;
            // 
            // dtpAño1
            // 
            this.dtpAño1.CustomFormat = "yyyy";
            this.dtpAño1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAño1.Location = new System.Drawing.Point(248, 120);
            this.dtpAño1.Name = "dtpAño1";
            this.dtpAño1.ShowUpDown = true;
            this.dtpAño1.Size = new System.Drawing.Size(200, 22);
            this.dtpAño1.TabIndex = 3;
            // 
            // lblAño1
            // 
            this.lblAño1.AutoSize = true;
            this.lblAño1.Location = new System.Drawing.Point(24, 128);
            this.lblAño1.Name = "lblAño1";
            this.lblAño1.Size = new System.Drawing.Size(125, 17);
            this.lblAño1.TabIndex = 7;
            this.lblAño1.Text = "Seleccione un año";
            // 
            // btnReporteAnual
            // 
            this.btnReporteAnual.Location = new System.Drawing.Point(480, 104);
            this.btnReporteAnual.Name = "btnReporteAnual";
            this.btnReporteAnual.Size = new System.Drawing.Size(144, 40);
            this.btnReporteAnual.TabIndex = 4;
            this.btnReporteAnual.Text = "Generar Reporte Periodo";
            this.btnReporteAnual.UseVisualStyleBackColor = true;
            this.btnReporteAnual.Click += new System.EventHandler(this.BtnReporteAnual_Click);
            // 
            // cbxMesFin
            // 
            this.cbxMesFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMesFin.FormattingEnabled = true;
            this.cbxMesFin.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbxMesFin.Location = new System.Drawing.Point(248, 80);
            this.cbxMesFin.Name = "cbxMesFin";
            this.cbxMesFin.Size = new System.Drawing.Size(121, 24);
            this.cbxMesFin.TabIndex = 2;
            this.cbxMesFin.SelectedIndexChanged += new System.EventHandler(this.cbxMesFin_SelectedIndexChanged);
            // 
            // lblMesFin
            // 
            this.lblMesFin.AutoSize = true;
            this.lblMesFin.Location = new System.Drawing.Point(24, 88);
            this.lblMesFin.Name = "lblMesFin";
            this.lblMesFin.Size = new System.Drawing.Size(146, 17);
            this.lblMesFin.TabIndex = 4;
            this.lblMesFin.Text = "Seleccione mes de fin";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpAño2);
            this.panel2.Controls.Add(this.btnReporteMensual);
            this.panel2.Controls.Add(this.lblAño2);
            this.panel2.Controls.Add(this.cbxMes);
            this.panel2.Controls.Add(this.lblMes);
            this.panel2.Controls.Add(this.lblReporteMensual);
            this.panel2.Location = new System.Drawing.Point(24, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 144);
            this.panel2.TabIndex = 3;
            // 
            // dtpAño2
            // 
            this.dtpAño2.CustomFormat = "yyyy";
            this.dtpAño2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAño2.Location = new System.Drawing.Point(248, 88);
            this.dtpAño2.Name = "dtpAño2";
            this.dtpAño2.ShowUpDown = true;
            this.dtpAño2.Size = new System.Drawing.Size(200, 22);
            this.dtpAño2.TabIndex = 6;
            // 
            // btnReporteMensual
            // 
            this.btnReporteMensual.Location = new System.Drawing.Point(480, 72);
            this.btnReporteMensual.Name = "btnReporteMensual";
            this.btnReporteMensual.Size = new System.Drawing.Size(128, 40);
            this.btnReporteMensual.TabIndex = 7;
            this.btnReporteMensual.Text = "Generar Reporte Mensual";
            this.btnReporteMensual.UseVisualStyleBackColor = true;
            this.btnReporteMensual.Click += new System.EventHandler(this.BtnReporteMensual_Click);
            // 
            // lblAño2
            // 
            this.lblAño2.AutoSize = true;
            this.lblAño2.Location = new System.Drawing.Point(24, 88);
            this.lblAño2.Name = "lblAño2";
            this.lblAño2.Size = new System.Drawing.Size(125, 17);
            this.lblAño2.TabIndex = 8;
            this.lblAño2.Text = "Seleccione un año";
            // 
            // cbxMes
            // 
            this.cbxMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMes.FormattingEnabled = true;
            this.cbxMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbxMes.Location = new System.Drawing.Point(248, 48);
            this.cbxMes.Name = "cbxMes";
            this.cbxMes.Size = new System.Drawing.Size(121, 24);
            this.cbxMes.TabIndex = 5;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(24, 48);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(107, 17);
            this.lblMes.TabIndex = 4;
            this.lblMes.Text = "Seleccione mes";
            // 
            // lblReporteMensual
            // 
            this.lblReporteMensual.AutoSize = true;
            this.lblReporteMensual.Location = new System.Drawing.Point(24, 16);
            this.lblReporteMensual.Name = "lblReporteMensual";
            this.lblReporteMensual.Size = new System.Drawing.Size(116, 17);
            this.lblReporteMensual.TabIndex = 1;
            this.lblReporteMensual.Text = "Reporte Mensual";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(24, 392);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(128, 48);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // InterfazIngresosReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTituloReporteIngreso);
            this.Name = "InterfazIngresosReporte";
            this.Text = "InterfazIngresosReporte";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloReporteIngreso;
        private System.Windows.Forms.Label lblReportePeriodo;
        private System.Windows.Forms.ComboBox cbxMesInicio;
        private System.Windows.Forms.Label lblMesInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMesFin;
        private System.Windows.Forms.ComboBox cbxMesFin;
        private System.Windows.Forms.Label lblAño1;
        private System.Windows.Forms.Button btnReporteAnual;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReporteMensual;
        private System.Windows.Forms.Label lblAño2;
        private System.Windows.Forms.ComboBox cbxMes;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblReporteMensual;
        private System.Windows.Forms.DateTimePicker dtpAño1;
        private System.Windows.Forms.DateTimePicker dtpAño2;
        private Button btnVolver;
    }
}