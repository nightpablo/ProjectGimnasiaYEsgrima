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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxActivo = new System.Windows.Forms.CheckBox();
            this.cbxAdherente = new System.Windows.Forms.CheckBox();
            this.cbxMenor = new System.Windows.Forms.CheckBox();
            this.cbxVitalicio = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Socios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generar Reporte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxActivo
            // 
            this.cbxActivo.AutoSize = true;
            this.cbxActivo.Location = new System.Drawing.Point(32, 32);
            this.cbxActivo.Name = "cbxActivo";
            this.cbxActivo.Size = new System.Drawing.Size(68, 21);
            this.cbxActivo.TabIndex = 4;
            this.cbxActivo.Text = "Activo";
            this.cbxActivo.UseVisualStyleBackColor = true;
            // 
            // cbxAdherente
            // 
            this.cbxAdherente.AutoSize = true;
            this.cbxAdherente.Location = new System.Drawing.Point(32, 72);
            this.cbxAdherente.Name = "cbxAdherente";
            this.cbxAdherente.Size = new System.Drawing.Size(96, 21);
            this.cbxAdherente.TabIndex = 5;
            this.cbxAdherente.Text = "Adherente";
            this.cbxAdherente.UseVisualStyleBackColor = true;
            // 
            // cbxMenor
            // 
            this.cbxMenor.AutoSize = true;
            this.cbxMenor.Location = new System.Drawing.Point(32, 152);
            this.cbxMenor.Name = "cbxMenor";
            this.cbxMenor.Size = new System.Drawing.Size(70, 21);
            this.cbxMenor.TabIndex = 5;
            this.cbxMenor.Text = "Menor";
            this.cbxMenor.UseVisualStyleBackColor = true;
            // 
            // cbxVitalicio
            // 
            this.cbxVitalicio.AutoSize = true;
            this.cbxVitalicio.Location = new System.Drawing.Point(32, 112);
            this.cbxVitalicio.Name = "cbxVitalicio";
            this.cbxVitalicio.Size = new System.Drawing.Size(78, 21);
            this.cbxVitalicio.TabIndex = 5;
            this.cbxVitalicio.Text = "Vitalicio";
            this.cbxVitalicio.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "Generar Reporte Alfabetico";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InterfazfiltroReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbxVitalicio);
            this.Controls.Add(this.cbxMenor);
            this.Controls.Add(this.cbxAdherente);
            this.Controls.Add(this.cbxActivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "InterfazfiltroReporte";
            this.Text = "ReporteSocios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbxActivo;
        private System.Windows.Forms.CheckBox cbxAdherente;
        private System.Windows.Forms.CheckBox cbxMenor;
        private System.Windows.Forms.CheckBox cbxVitalicio;
        private System.Windows.Forms.Button button2;
    }
}