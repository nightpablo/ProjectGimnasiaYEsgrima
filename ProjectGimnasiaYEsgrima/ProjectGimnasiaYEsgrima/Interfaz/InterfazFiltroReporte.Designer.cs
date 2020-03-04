namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazFiltroReporte
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
            this.btnSociosReportes = new System.Windows.Forms.Button();
            this.btnEmpleadosReportes = new System.Windows.Forms.Button();
            this.btnDeportesReportes = new System.Windows.Forms.Button();
            this.btnIngresosReportes = new System.Windows.Forms.Button();
            this.lblTituloReportes = new System.Windows.Forms.Label();
            this.btnCategoriasReportes = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSociosReportes
            // 
            this.btnSociosReportes.Location = new System.Drawing.Point(18, 52);
            this.btnSociosReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnSociosReportes.Name = "btnSociosReportes";
            this.btnSociosReportes.Size = new System.Drawing.Size(138, 39);
            this.btnSociosReportes.TabIndex = 1;
            this.btnSociosReportes.Text = "Socios";
            this.btnSociosReportes.UseVisualStyleBackColor = true;
            this.btnSociosReportes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmpleadosReportes
            // 
            this.btnEmpleadosReportes.Location = new System.Drawing.Point(198, 52);
            this.btnEmpleadosReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpleadosReportes.Name = "btnEmpleadosReportes";
            this.btnEmpleadosReportes.Size = new System.Drawing.Size(138, 39);
            this.btnEmpleadosReportes.TabIndex = 2;
            this.btnEmpleadosReportes.Text = "Empleados";
            this.btnEmpleadosReportes.UseVisualStyleBackColor = true;
            this.btnEmpleadosReportes.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeportesReportes
            // 
            this.btnDeportesReportes.Location = new System.Drawing.Point(18, 130);
            this.btnDeportesReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeportesReportes.Name = "btnDeportesReportes";
            this.btnDeportesReportes.Size = new System.Drawing.Size(138, 39);
            this.btnDeportesReportes.TabIndex = 3;
            this.btnDeportesReportes.Text = "Deportes";
            this.btnDeportesReportes.UseVisualStyleBackColor = true;
            this.btnDeportesReportes.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIngresosReportes
            // 
            this.btnIngresosReportes.Location = new System.Drawing.Point(18, 208);
            this.btnIngresosReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnIngresosReportes.Name = "btnIngresosReportes";
            this.btnIngresosReportes.Size = new System.Drawing.Size(138, 39);
            this.btnIngresosReportes.TabIndex = 5;
            this.btnIngresosReportes.Text = "Ingresos";
            this.btnIngresosReportes.UseVisualStyleBackColor = true;
            this.btnIngresosReportes.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblTituloReportes
            // 
            this.lblTituloReportes.AutoSize = true;
            this.lblTituloReportes.Location = new System.Drawing.Point(30, 20);
            this.lblTituloReportes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloReportes.Name = "lblTituloReportes";
            this.lblTituloReportes.Size = new System.Drawing.Size(104, 13);
            this.lblTituloReportes.TabIndex = 5;
            this.lblTituloReportes.Text = "Gestión de Reportes";
            // 
            // btnCategoriasReportes
            // 
            this.btnCategoriasReportes.Location = new System.Drawing.Point(198, 130);
            this.btnCategoriasReportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnCategoriasReportes.Name = "btnCategoriasReportes";
            this.btnCategoriasReportes.Size = new System.Drawing.Size(144, 39);
            this.btnCategoriasReportes.TabIndex = 4;
            this.btnCategoriasReportes.Text = "Categorías";
            this.btnCategoriasReportes.UseVisualStyleBackColor = true;
            this.btnCategoriasReportes.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(198, 208);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(144, 39);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // InterfazFiltroReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnCategoriasReportes);
            this.Controls.Add(this.lblTituloReportes);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnIngresosReportes);
            this.Controls.Add(this.btnDeportesReportes);
            this.Controls.Add(this.btnEmpleadosReportes);
            this.Controls.Add(this.btnSociosReportes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InterfazFiltroReporte";
            this.Text = "InterfazFiltroReporte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InterfazFiltroReporte_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSociosReportes;
        private System.Windows.Forms.Button btnEmpleadosReportes;
        private System.Windows.Forms.Button btnDeportesReportes;
        private System.Windows.Forms.Button btnIngresosReportes;
        private System.Windows.Forms.Label lblTituloReportes;
        private System.Windows.Forms.Button btnCategoriasReportes;
        private System.Windows.Forms.Button btnVolver;
    }
}