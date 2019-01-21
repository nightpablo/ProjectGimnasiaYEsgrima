namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazCursoReporte
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbdBaja = new System.Windows.Forms.CheckBox();
            this.cxbActivo = new System.Windows.Forms.CheckBox();
            this.cxbPendiente = new System.Windows.Forms.CheckBox();
            this.cxbInciado = new System.Windows.Forms.CheckBox();
            this.cxbCancelado = new System.Windows.Forms.CheckBox();
            this.cxbTerminado = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deporte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fiiltros de Cursos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 360);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 48);
            this.button2.TabIndex = 5;
            this.button2.Text = "Generar Reporte Alfabetico";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Estado";
            // 
            // cbdBaja
            // 
            this.cbdBaja.AutoSize = true;
            this.cbdBaja.Location = new System.Drawing.Point(24, 40);
            this.cbdBaja.Name = "cbdBaja";
            this.cbdBaja.Size = new System.Drawing.Size(58, 21);
            this.cbdBaja.TabIndex = 6;
            this.cbdBaja.Text = "Baja";
            this.cbdBaja.UseVisualStyleBackColor = true;
            // 
            // cxbActivo
            // 
            this.cxbActivo.AutoSize = true;
            this.cxbActivo.Location = new System.Drawing.Point(136, 40);
            this.cxbActivo.Name = "cxbActivo";
            this.cxbActivo.Size = new System.Drawing.Size(68, 21);
            this.cxbActivo.TabIndex = 7;
            this.cxbActivo.Text = "Activo";
            this.cxbActivo.UseVisualStyleBackColor = true;
            // 
            // cxbPendiente
            // 
            this.cxbPendiente.AutoSize = true;
            this.cxbPendiente.Location = new System.Drawing.Point(240, 40);
            this.cxbPendiente.Name = "cxbPendiente";
            this.cxbPendiente.Size = new System.Drawing.Size(94, 21);
            this.cxbPendiente.TabIndex = 8;
            this.cxbPendiente.Text = "Pendiente";
            this.cxbPendiente.UseVisualStyleBackColor = true;
            // 
            // cxbInciado
            // 
            this.cxbInciado.AutoSize = true;
            this.cxbInciado.Location = new System.Drawing.Point(24, 80);
            this.cxbInciado.Name = "cxbInciado";
            this.cxbInciado.Size = new System.Drawing.Size(78, 21);
            this.cxbInciado.TabIndex = 9;
            this.cxbInciado.Text = "Iniciado";
            this.cxbInciado.UseVisualStyleBackColor = true;
            // 
            // cxbCancelado
            // 
            this.cxbCancelado.AutoSize = true;
            this.cxbCancelado.Location = new System.Drawing.Point(136, 80);
            this.cxbCancelado.Name = "cxbCancelado";
            this.cxbCancelado.Size = new System.Drawing.Size(97, 21);
            this.cxbCancelado.TabIndex = 10;
            this.cxbCancelado.Text = "Cancelado";
            this.cxbCancelado.UseVisualStyleBackColor = true;
            // 
            // cxbTerminado
            // 
            this.cxbTerminado.AutoSize = true;
            this.cxbTerminado.Location = new System.Drawing.Point(240, 80);
            this.cxbTerminado.Name = "cxbTerminado";
            this.cxbTerminado.Size = new System.Drawing.Size(98, 21);
            this.cxbTerminado.TabIndex = 11;
            this.cxbTerminado.Text = "Terminado";
            this.cxbTerminado.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 48);
            this.button1.TabIndex = 12;
            this.button1.Text = "Generar Reporte con filtro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cxbTerminado);
            this.panel2.Controls.Add(this.cxbCancelado);
            this.panel2.Controls.Add(this.cxbInciado);
            this.panel2.Controls.Add(this.cxbPendiente);
            this.panel2.Controls.Add(this.cxbActivo);
            this.panel2.Controls.Add(this.cbdBaja);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(16, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 224);
            this.panel2.TabIndex = 6;
            // 
            // InterfazCursoReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "InterfazCursoReporte";
            this.Text = "InterfazCursoReporte";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cxbTerminado;
        private System.Windows.Forms.CheckBox cxbCancelado;
        private System.Windows.Forms.CheckBox cxbInciado;
        private System.Windows.Forms.CheckBox cxbPendiente;
        private System.Windows.Forms.CheckBox cxbActivo;
        private System.Windows.Forms.CheckBox cbdBaja;
        private System.Windows.Forms.Label label4;
    }
}