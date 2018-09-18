namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazRegistrarEntradaSalida
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BotonRegistrarEntrada = new System.Windows.Forms.Button();
            this.BotonRegistrarSalida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Documento Empleado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(297, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 22);
            this.textBox2.TabIndex = 3;
            // 
            // BotonRegistrarEntrada
            // 
            this.BotonRegistrarEntrada.Location = new System.Drawing.Point(154, 166);
            this.BotonRegistrarEntrada.Name = "BotonRegistrarEntrada";
            this.BotonRegistrarEntrada.Size = new System.Drawing.Size(160, 54);
            this.BotonRegistrarEntrada.TabIndex = 4;
            this.BotonRegistrarEntrada.Text = "Registrar Entrada";
            this.BotonRegistrarEntrada.UseVisualStyleBackColor = true;
            this.BotonRegistrarEntrada.Click += new System.EventHandler(this.button1_Click);
            // 
            // BotonRegistrarSalida
            // 
            this.BotonRegistrarSalida.Location = new System.Drawing.Point(373, 166);
            this.BotonRegistrarSalida.Name = "BotonRegistrarSalida";
            this.BotonRegistrarSalida.Size = new System.Drawing.Size(160, 57);
            this.BotonRegistrarSalida.TabIndex = 5;
            this.BotonRegistrarSalida.Text = "Registrar Salida";
            this.BotonRegistrarSalida.UseVisualStyleBackColor = true;
            // 
            // InterfazRegistrarEntradaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.BotonRegistrarSalida);
            this.Controls.Add(this.BotonRegistrarEntrada);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "InterfazRegistrarEntradaSalida";
            this.Text = "Registrar Salida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BotonRegistrarEntrada;
        private System.Windows.Forms.Button BotonRegistrarSalida;
    }
}