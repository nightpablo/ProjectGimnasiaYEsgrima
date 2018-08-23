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
            this.SuspendLayout();
            // 
            // buttonDeportes
            // 
            this.buttonDeportes.Location = new System.Drawing.Point(194, 98);
            this.buttonDeportes.Name = "buttonDeportes";
            this.buttonDeportes.Size = new System.Drawing.Size(149, 48);
            this.buttonDeportes.TabIndex = 0;
            this.buttonDeportes.Text = "Deportes";
            this.buttonDeportes.UseVisualStyleBackColor = true;
            this.buttonDeportes.Click += new System.EventHandler(this.buttonDeportes_Click);
            // 
            // buttonCursos
            // 
            this.buttonCursos.Location = new System.Drawing.Point(194, 174);
            this.buttonCursos.Name = "buttonCursos";
            this.buttonCursos.Size = new System.Drawing.Size(149, 48);
            this.buttonCursos.TabIndex = 1;
            this.buttonCursos.Text = "Cursos";
            this.buttonCursos.UseVisualStyleBackColor = true;
            this.buttonCursos.Click += new System.EventHandler(this.buttonCursos_Click);
            // 
            // InterfazPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCursos);
            this.Controls.Add(this.buttonDeportes);
            this.Name = "InterfazPrincipal";
            this.Text = "InterfazPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDeportes;
        private System.Windows.Forms.Button buttonCursos;
    }
}