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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbxAlta = new System.Windows.Forms.CheckBox();
            this.cbxBaja = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar Reporte Alfabetico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(288, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Generar Reporte con Filltro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbxAlta
            // 
            this.cbxAlta.AutoSize = true;
            this.cbxAlta.Location = new System.Drawing.Point(24, 80);
            this.cbxAlta.Name = "cbxAlta";
            this.cbxAlta.Size = new System.Drawing.Size(68, 21);
            this.cbxAlta.TabIndex = 2;
            this.cbxAlta.Text = "Activo";
            this.cbxAlta.UseVisualStyleBackColor = true;
            // 
            // cbxBaja
            // 
            this.cbxBaja.AutoSize = true;
            this.cbxBaja.Location = new System.Drawing.Point(208, 80);
            this.cbxBaja.Name = "cbxBaja";
            this.cbxBaja.Size = new System.Drawing.Size(58, 21);
            this.cbxBaja.TabIndex = 3;
            this.cbxBaja.Text = "Baja";
            this.cbxBaja.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Estado del Deporte";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cbxBaja);
            this.panel1.Controls.Add(this.cbxAlta);
            this.panel1.Location = new System.Drawing.Point(32, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 288);
            this.panel1.TabIndex = 5;
            // 
            // InterfazDeporteReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "InterfazDeporteReporte";
            this.Text = "InterfazDeporteReporte";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbxAlta;
        private System.Windows.Forms.CheckBox cbxBaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}