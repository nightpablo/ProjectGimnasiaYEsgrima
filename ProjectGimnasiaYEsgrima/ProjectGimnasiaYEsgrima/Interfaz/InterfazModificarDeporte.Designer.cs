using ProjectGimnasiaYEsgrima.Utils;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazModificarDeporte
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcionDeporte = new System.Windows.Forms.TextBox();
            this.txtNombreDeporte = new System.Windows.Forms.TextBox();
            this.BotonGuardarDeporte = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modificar Deporte";
            // 
            // txtDescripcionDeporte
            // 
            this.txtDescripcionDeporte.Location = new System.Drawing.Point(199, 148);
            this.txtDescripcionDeporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionDeporte.Name = "txtDescripcionDeporte";
            this.txtDescripcionDeporte.Size = new System.Drawing.Size(197, 22);
            this.txtDescripcionDeporte.TabIndex = 5;
            // 
            // txtNombreDeporte
            // 
            this.txtNombreDeporte.Location = new System.Drawing.Point(199, 88);
            this.txtNombreDeporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreDeporte.Name = "txtNombreDeporte";
            this.txtNombreDeporte.Size = new System.Drawing.Size(197, 22);
            this.txtNombreDeporte.TabIndex = 6;
            // 
            // BotonGuardarDeporte
            // 
            this.BotonGuardarDeporte.Location = new System.Drawing.Point(78, 212);
            this.BotonGuardarDeporte.Margin = new System.Windows.Forms.Padding(4);
            this.BotonGuardarDeporte.Name = "BotonGuardarDeporte";
            this.BotonGuardarDeporte.Size = new System.Drawing.Size(141, 38);
            this.BotonGuardarDeporte.TabIndex = 7;
            this.BotonGuardarDeporte.Text = "Guardar";
            this.BotonGuardarDeporte.UseVisualStyleBackColor = true;
            this.BotonGuardarDeporte.Click += new System.EventHandler(this.BotonGuardarDeporte_Click);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(255, 212);
            this.BotonCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(141, 38);
            this.BotonCancelar.TabIndex = 8;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // InterfazModificarDeporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 475);
            this.Controls.Add(this.txtNombreDeporte);
            this.Controls.Add(this.txtDescripcionDeporte);
            this.Controls.Add(this.BotonGuardarDeporte);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "InterfazModificarDeporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InterfazModificarDeporte";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcionDeporte;
        private System.Windows.Forms.TextBox txtNombreDeporte;
        private System.Windows.Forms.Button BotonGuardarDeporte;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}