namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazPrincipal
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
            this.buttonDeportes = new System.Windows.Forms.Button();
            this.buttonCursos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSocio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDeportes
            // 
            this.buttonDeportes.Location = new System.Drawing.Point(259, 121);
            this.buttonDeportes.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeportes.Name = "buttonDeportes";
            this.buttonDeportes.Size = new System.Drawing.Size(199, 59);
            this.buttonDeportes.TabIndex = 0;
            this.buttonDeportes.Text = "Deportes";
            this.buttonDeportes.UseVisualStyleBackColor = true;
            this.buttonDeportes.Click += new System.EventHandler(this.buttonDeportes_Click);
            // 
            // buttonCursos
            // 
            this.buttonCursos.Location = new System.Drawing.Point(259, 214);
            this.buttonCursos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCursos.Name = "buttonCursos";
            this.buttonCursos.Size = new System.Drawing.Size(199, 59);
            this.buttonCursos.TabIndex = 1;
            this.buttonCursos.Text = "Cursos";
            this.buttonCursos.UseVisualStyleBackColor = true;
            this.buttonCursos.Click += new System.EventHandler(this.buttonCursos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "Empleado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 65);
            this.button2.TabIndex = 3;
            this.button2.Text = "Registro entrada/salida";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSocio
            // 
            this.btnSocio.Location = new System.Drawing.Point(259, 309);
            this.btnSocio.Margin = new System.Windows.Forms.Padding(4);
            this.btnSocio.Name = "btnSocio";
            this.btnSocio.Size = new System.Drawing.Size(199, 59);
            this.btnSocio.TabIndex = 4;
            this.btnSocio.Text = "Socios";
            this.btnSocio.UseVisualStyleBackColor = true;
            this.btnSocio.Click += new System.EventHandler(this.button3_Click);
            // 
            // InterfazPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnSocio);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCursos);
            this.Controls.Add(this.buttonDeportes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InterfazPrincipal";
            this.Text = "InterfazPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDeportes;
        private System.Windows.Forms.Button buttonCursos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSocio;
    }
}