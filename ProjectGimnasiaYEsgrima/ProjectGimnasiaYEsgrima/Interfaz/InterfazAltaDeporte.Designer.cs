
namespace ProjectGimnasiaYEsgrima
{
    partial class InterfazAltaDeporte
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreDeporte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcionDeporte = new System.Windows.Forms.TextBox();
            this.BotonGuardarDeporte = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.botonCancelarDeporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta  Deporte";
            // 
            // txtNombreDeporte
            // 
            this.txtNombreDeporte.Location = new System.Drawing.Point(204, 87);
            this.txtNombreDeporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreDeporte.Name = "txtNombreDeporte";
            this.txtNombreDeporte.Size = new System.Drawing.Size(197, 22);
            this.txtNombreDeporte.TabIndex = 1;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion ";
            // 
            // txtDescripcionDeporte
            // 
            this.txtDescripcionDeporte.Location = new System.Drawing.Point(204, 148);
            this.txtDescripcionDeporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionDeporte.Name = "txtDescripcionDeporte";
            this.txtDescripcionDeporte.Size = new System.Drawing.Size(196, 22);
            this.txtDescripcionDeporte.TabIndex = 3;
            // 
            // BotonGuardarDeporte
            // 
            this.BotonGuardarDeporte.Location = new System.Drawing.Point(67, 206);
            this.BotonGuardarDeporte.Margin = new System.Windows.Forms.Padding(4);
            this.BotonGuardarDeporte.Name = "BotonGuardarDeporte";
            this.BotonGuardarDeporte.Size = new System.Drawing.Size(141, 38);
            this.BotonGuardarDeporte.TabIndex = 4;
            this.BotonGuardarDeporte.Text = "Guardar";
            this.BotonGuardarDeporte.UseVisualStyleBackColor = true;
            this.BotonGuardarDeporte.Click += new System.EventHandler(this.BotonGuardarDeporte_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // botonCancelarDeporte
            // 
            this.botonCancelarDeporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.botonCancelarDeporte.Location = new System.Drawing.Point(253, 202);
            this.botonCancelarDeporte.Margin = new System.Windows.Forms.Padding(4);
            this.botonCancelarDeporte.Name = "botonCancelarDeporte";
            this.botonCancelarDeporte.Size = new System.Drawing.Size(149, 42);
            this.botonCancelarDeporte.TabIndex = 6;
            this.botonCancelarDeporte.Text = "Cancelar";
            this.botonCancelarDeporte.UseVisualStyleBackColor = true;
            this.botonCancelarDeporte.Click += new System.EventHandler(this.BotonCancelarDeporte_Click);
            // 
            // InterfazAltaDeporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.botonCancelarDeporte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BotonGuardarDeporte);
            this.Controls.Add(this.txtDescripcionDeporte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreDeporte);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InterfazAltaDeporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion Deportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreDeporte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcionDeporte;
        private System.Windows.Forms.Button BotonGuardarDeporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botonCancelarDeporte;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

