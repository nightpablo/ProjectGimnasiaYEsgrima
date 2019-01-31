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
            this.btnCursosReportes = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSociosReportes
            // 
            this.btnSociosReportes.Location = new System.Drawing.Point(24, 64);
            this.btnSociosReportes.Name = "btnSociosReportes";
            this.btnSociosReportes.Size = new System.Drawing.Size(184, 48);
            this.btnSociosReportes.TabIndex = 1;
            this.btnSociosReportes.Text = "Socios";
            this.btnSociosReportes.UseVisualStyleBackColor = true;
            this.btnSociosReportes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmpleadosReportes
            // 
            this.btnEmpleadosReportes.Location = new System.Drawing.Point(264, 64);
            this.btnEmpleadosReportes.Name = "btnEmpleadosReportes";
            this.btnEmpleadosReportes.Size = new System.Drawing.Size(184, 48);
            this.btnEmpleadosReportes.TabIndex = 2;
            this.btnEmpleadosReportes.Text = "Empleados";
            this.btnEmpleadosReportes.UseVisualStyleBackColor = true;
            this.btnEmpleadosReportes.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeportesReportes
            // 
            this.btnDeportesReportes.Location = new System.Drawing.Point(24, 160);
            this.btnDeportesReportes.Name = "btnDeportesReportes";
            this.btnDeportesReportes.Size = new System.Drawing.Size(184, 48);
            this.btnDeportesReportes.TabIndex = 3;
            this.btnDeportesReportes.Text = "Deportes";
            this.btnDeportesReportes.UseVisualStyleBackColor = true;
            this.btnDeportesReportes.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIngresosReportes
            // 
            this.btnIngresosReportes.Location = new System.Drawing.Point(24, 256);
            this.btnIngresosReportes.Name = "btnIngresosReportes";
            this.btnIngresosReportes.Size = new System.Drawing.Size(184, 48);
            this.btnIngresosReportes.TabIndex = 5;
            this.btnIngresosReportes.Text = "Ingresos";
            this.btnIngresosReportes.UseVisualStyleBackColor = true;
            this.btnIngresosReportes.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblTituloReportes
            // 
            this.lblTituloReportes.AutoSize = true;
            this.lblTituloReportes.Location = new System.Drawing.Point(40, 24);
            this.lblTituloReportes.Name = "lblTituloReportes";
            this.lblTituloReportes.Size = new System.Drawing.Size(66, 17);
            this.lblTituloReportes.TabIndex = 5;
            this.lblTituloReportes.Text = "Reportes";
            // 
            // btnCursosReportes
            // 
            this.btnCursosReportes.Location = new System.Drawing.Point(264, 160);
            this.btnCursosReportes.Name = "btnCursosReportes";
            this.btnCursosReportes.Size = new System.Drawing.Size(192, 48);
            this.btnCursosReportes.TabIndex = 4;
            this.btnCursosReportes.Text = "Cursos";
            this.btnCursosReportes.UseVisualStyleBackColor = true;
            this.btnCursosReportes.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(264, 256);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(192, 48);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // InterfazFiltroReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCursosReportes);
            this.Controls.Add(this.lblTituloReportes);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnIngresosReportes);
            this.Controls.Add(this.btnDeportesReportes);
            this.Controls.Add(this.btnEmpleadosReportes);
            this.Controls.Add(this.btnSociosReportes);
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
        private System.Windows.Forms.Button btnCursosReportes;
        private System.Windows.Forms.Button btnVolver;
    }
}