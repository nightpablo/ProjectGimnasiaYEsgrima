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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbxDirectivo = new System.Windows.Forms.CheckBox();
            this.cbxSecretaria = new System.Windows.Forms.CheckBox();
            this.cbxProfesor = new System.Windows.Forms.CheckBox();
            this.cbxMantenimiento = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar Reporte Alfabetico";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Generar Reporte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbxDirectivo
            // 
            this.cbxDirectivo.AutoSize = true;
            this.cbxDirectivo.Location = new System.Drawing.Point(40, 32);
            this.cbxDirectivo.Name = "cbxDirectivo";
            this.cbxDirectivo.Size = new System.Drawing.Size(85, 21);
            this.cbxDirectivo.TabIndex = 2;
            this.cbxDirectivo.Text = "Directivo";
            this.cbxDirectivo.UseVisualStyleBackColor = true;
            // 
            // cbxSecretaria
            // 
            this.cbxSecretaria.AutoSize = true;
            this.cbxSecretaria.Location = new System.Drawing.Point(40, 80);
            this.cbxSecretaria.Name = "cbxSecretaria";
            this.cbxSecretaria.Size = new System.Drawing.Size(95, 21);
            this.cbxSecretaria.TabIndex = 3;
            this.cbxSecretaria.Text = "Secretaria";
            this.cbxSecretaria.UseVisualStyleBackColor = true;
            // 
            // cbxProfesor
            // 
            this.cbxProfesor.AutoSize = true;
            this.cbxProfesor.Location = new System.Drawing.Point(40, 120);
            this.cbxProfesor.Name = "cbxProfesor";
            this.cbxProfesor.Size = new System.Drawing.Size(84, 21);
            this.cbxProfesor.TabIndex = 4;
            this.cbxProfesor.Text = "Profesor";
            this.cbxProfesor.UseVisualStyleBackColor = true;
            // 
            // cbxMantenimiento
            // 
            this.cbxMantenimiento.AutoSize = true;
            this.cbxMantenimiento.Location = new System.Drawing.Point(40, 160);
            this.cbxMantenimiento.Name = "cbxMantenimiento";
            this.cbxMantenimiento.Size = new System.Drawing.Size(122, 21);
            this.cbxMantenimiento.TabIndex = 5;
            this.cbxMantenimiento.Text = "Mantenimiento";
            this.cbxMantenimiento.UseVisualStyleBackColor = true;
            // 
            // InterfazEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxMantenimiento);
            this.Controls.Add(this.cbxProfesor);
            this.Controls.Add(this.cbxSecretaria);
            this.Controls.Add(this.cbxDirectivo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "InterfazEmpleados";
            this.Text = "InterfazEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbxDirectivo;
        private System.Windows.Forms.CheckBox cbxSecretaria;
        private System.Windows.Forms.CheckBox cbxProfesor;
        private System.Windows.Forms.CheckBox cbxMantenimiento;
    }
}