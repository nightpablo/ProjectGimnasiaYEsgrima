namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazCategoriaReporte
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
            this.cbxDeporte = new System.Windows.Forms.ComboBox();
            this.lblDeporte = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.cbxTerminado = new System.Windows.Forms.CheckBox();
            this.cbxCancelado = new System.Windows.Forms.CheckBox();
            this.cbxIniciado = new System.Windows.Forms.CheckBox();
            this.cbxPendiente = new System.Windows.Forms.CheckBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnAlfabetico = new System.Windows.Forms.Button();
            this.lblTituloCategoriasReportes = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxDeporte
            // 
            this.cbxDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDeporte.FormattingEnabled = true;
            this.cbxDeporte.Location = new System.Drawing.Point(102, 39);
            this.cbxDeporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxDeporte.Name = "cbxDeporte";
            this.cbxDeporte.Size = new System.Drawing.Size(92, 21);
            this.cbxDeporte.TabIndex = 1;
            // 
            // lblDeporte
            // 
            this.lblDeporte.AutoSize = true;
            this.lblDeporte.Location = new System.Drawing.Point(24, 39);
            this.lblDeporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeporte.Name = "lblDeporte";
            this.lblDeporte.Size = new System.Drawing.Size(45, 13);
            this.lblDeporte.TabIndex = 2;
            this.lblDeporte.Text = "Deporte";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(18, 6);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(106, 13);
            this.lblFiltro.TabIndex = 3;
            this.lblFiltro.Text = "Fiiltros de Categorías";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblFiltro);
            this.panel1.Controls.Add(this.lblDeporte);
            this.panel1.Controls.Add(this.cbxDeporte);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 293);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFiltro);
            this.panel2.Controls.Add(this.cbxTerminado);
            this.panel2.Controls.Add(this.cbxCancelado);
            this.panel2.Controls.Add(this.cbxIniciado);
            this.panel2.Controls.Add(this.cbxPendiente);
            this.panel2.Controls.Add(this.lblEstado);
            this.panel2.Location = new System.Drawing.Point(12, 84);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 182);
            this.panel2.TabIndex = 6;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(12, 117);
            this.btnFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(246, 39);
            this.btnFiltro.TabIndex = 8;
            this.btnFiltro.Text = "Generar Reporte con filtro";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxTerminado
            // 
            this.cbxTerminado.AutoSize = true;
            this.cbxTerminado.Location = new System.Drawing.Point(174, 39);
            this.cbxTerminado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxTerminado.Name = "cbxTerminado";
            this.cbxTerminado.Size = new System.Drawing.Size(76, 17);
            this.cbxTerminado.TabIndex = 7;
            this.cbxTerminado.Text = "Terminado";
            this.cbxTerminado.UseVisualStyleBackColor = true;
            // 
            // cbxCancelado
            // 
            this.cbxCancelado.AutoSize = true;
            this.cbxCancelado.Location = new System.Drawing.Point(174, 65);
            this.cbxCancelado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxCancelado.Name = "cbxCancelado";
            this.cbxCancelado.Size = new System.Drawing.Size(77, 17);
            this.cbxCancelado.TabIndex = 6;
            this.cbxCancelado.Text = "Cancelado";
            this.cbxCancelado.UseVisualStyleBackColor = true;
            // 
            // cbxIniciado
            // 
            this.cbxIniciado.AutoSize = true;
            this.cbxIniciado.Location = new System.Drawing.Point(42, 65);
            this.cbxIniciado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxIniciado.Name = "cbxIniciado";
            this.cbxIniciado.Size = new System.Drawing.Size(63, 17);
            this.cbxIniciado.TabIndex = 5;
            this.cbxIniciado.Text = "Iniciado";
            this.cbxIniciado.UseVisualStyleBackColor = true;
            // 
            // cbxPendiente
            // 
            this.cbxPendiente.AutoSize = true;
            this.cbxPendiente.Location = new System.Drawing.Point(42, 39);
            this.cbxPendiente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxPendiente.Name = "cbxPendiente";
            this.cbxPendiente.Size = new System.Drawing.Size(74, 17);
            this.cbxPendiente.TabIndex = 4;
            this.cbxPendiente.Text = "Pendiente";
            this.cbxPendiente.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 6);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado";
            // 
            // btnAlfabetico
            // 
            this.btnAlfabetico.Location = new System.Drawing.Point(36, 332);
            this.btnAlfabetico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlfabetico.Name = "btnAlfabetico";
            this.btnAlfabetico.Size = new System.Drawing.Size(246, 39);
            this.btnAlfabetico.TabIndex = 9;
            this.btnAlfabetico.Text = "Generar Reporte Alfabético";
            this.btnAlfabetico.UseVisualStyleBackColor = true;
            this.btnAlfabetico.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblTituloCategoriasReportes
            // 
            this.lblTituloCategoriasReportes.AutoSize = true;
            this.lblTituloCategoriasReportes.Location = new System.Drawing.Point(12, 6);
            this.lblTituloCategoriasReportes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloCategoriasReportes.Name = "lblTituloCategoriasReportes";
            this.lblTituloCategoriasReportes.Size = new System.Drawing.Size(115, 13);
            this.lblTituloCategoriasReportes.TabIndex = 6;
            this.lblTituloCategoriasReportes.Text = "Reporte de Categorías";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(367, 235);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(119, 39);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // InterfazCategoriaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 411);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblTituloCategoriasReportes);
            this.Controls.Add(this.btnAlfabetico);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InterfazCategoriaReporte";
            this.Text = "InterfazCategoriaReporte";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDeporte;
        private System.Windows.Forms.Label lblDeporte;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlfabetico;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.CheckBox cbxTerminado;
        private System.Windows.Forms.CheckBox cbxCancelado;
        private System.Windows.Forms.CheckBox cbxIniciado;
        private System.Windows.Forms.CheckBox cbxPendiente;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTituloCategoriasReportes;
        private System.Windows.Forms.Button btnVolver;
    }
}