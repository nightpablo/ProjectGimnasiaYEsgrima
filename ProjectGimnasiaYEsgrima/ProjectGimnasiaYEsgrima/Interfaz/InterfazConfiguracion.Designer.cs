namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazConfiguracion
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
            this.components = new System.ComponentModel.Container();
            this.lblTituloConfiguracion = new System.Windows.Forms.Label();
            this.lblValorInicialAsociado = new System.Windows.Forms.Label();
            this.txtValorInicialAsociado = new System.Windows.Forms.TextBox();
            this.btnModificarValorInicialAsociado = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloConfiguracion
            // 
            this.lblTituloConfiguracion.AutoSize = true;
            this.lblTituloConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloConfiguracion.Location = new System.Drawing.Point(72, 8);
            this.lblTituloConfiguracion.Name = "lblTituloConfiguracion";
            this.lblTituloConfiguracion.Size = new System.Drawing.Size(192, 32);
            this.lblTituloConfiguracion.TabIndex = 0;
            this.lblTituloConfiguracion.Text = "Configuración";
            // 
            // lblValorInicialAsociado
            // 
            this.lblValorInicialAsociado.AutoSize = true;
            this.lblValorInicialAsociado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorInicialAsociado.Location = new System.Drawing.Point(32, 64);
            this.lblValorInicialAsociado.Name = "lblValorInicialAsociado";
            this.lblValorInicialAsociado.Size = new System.Drawing.Size(243, 29);
            this.lblValorInicialAsociado.TabIndex = 1;
            this.lblValorInicialAsociado.Text = "Valor Inicial Asociado";
            // 
            // txtValorInicialAsociado
            // 
            this.txtValorInicialAsociado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorInicialAsociado.Location = new System.Drawing.Point(288, 64);
            this.txtValorInicialAsociado.Name = "txtValorInicialAsociado";
            this.txtValorInicialAsociado.Size = new System.Drawing.Size(280, 34);
            this.txtValorInicialAsociado.TabIndex = 1;
            // 
            // btnModificarValorInicialAsociado
            // 
            this.btnModificarValorInicialAsociado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarValorInicialAsociado.Location = new System.Drawing.Point(592, 56);
            this.btnModificarValorInicialAsociado.Name = "btnModificarValorInicialAsociado";
            this.btnModificarValorInicialAsociado.Size = new System.Drawing.Size(152, 40);
            this.btnModificarValorInicialAsociado.TabIndex = 2;
            this.btnModificarValorInicialAsociado.Text = "Modificar";
            this.btnModificarValorInicialAsociado.UseVisualStyleBackColor = true;
            this.btnModificarValorInicialAsociado.Click += new System.EventHandler(this.BtnModificarValorInicialAsociado_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(592, 152);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(152, 40);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // InterfazConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnModificarValorInicialAsociado);
            this.Controls.Add(this.txtValorInicialAsociado);
            this.Controls.Add(this.lblValorInicialAsociado);
            this.Controls.Add(this.lblTituloConfiguracion);
            this.Name = "InterfazConfiguracion";
            this.Text = "InterfazConfiguracion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InterfazConfiguracion_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloConfiguracion;
        private System.Windows.Forms.Label lblValorInicialAsociado;
        private System.Windows.Forms.TextBox txtValorInicialAsociado;
        private System.Windows.Forms.Button btnModificarValorInicialAsociado;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}