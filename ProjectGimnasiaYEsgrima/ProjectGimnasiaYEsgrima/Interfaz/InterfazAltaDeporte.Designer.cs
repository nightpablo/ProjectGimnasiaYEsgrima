
namespace ProjectGimnasiaYEsgrima.Interfaz
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTituloDeporte = new System.Windows.Forms.Label();
            this.txtNombreDeporte = new System.Windows.Forms.TextBox();
            this.lblDescripcionDeporte = new System.Windows.Forms.Label();
            this.txtDescripcionDeporte = new System.Windows.Forms.TextBox();
            this.btnGuardarDeporte = new System.Windows.Forms.Button();
            this.lblNombreDeporte = new System.Windows.Forms.Label();
            this.btnCancelarDeporte = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTituloDeporte
            // 
            this.lblTituloDeporte.AutoSize = true;
            this.lblTituloDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDeporte.Location = new System.Drawing.Point(24, 8);
            this.lblTituloDeporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloDeporte.Name = "lblTituloDeporte";
            this.lblTituloDeporte.Size = new System.Drawing.Size(173, 32);
            this.lblTituloDeporte.TabIndex = 0;
            this.lblTituloDeporte.Text = "Alta Deporte";
            // 
            // txtNombreDeporte
            // 
            this.txtNombreDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDeporte.Location = new System.Drawing.Point(176, 56);
            this.txtNombreDeporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreDeporte.Name = "txtNombreDeporte";
            this.txtNombreDeporte.Size = new System.Drawing.Size(197, 34);
            this.txtNombreDeporte.TabIndex = 1;
            // 
            // lblDescripcionDeporte
            // 
            this.lblDescripcionDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionDeporte.Location = new System.Drawing.Point(24, 112);
            this.lblDescripcionDeporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionDeporte.Name = "lblDescripcionDeporte";
            this.lblDescripcionDeporte.Size = new System.Drawing.Size(144, 32);
            this.lblDescripcionDeporte.TabIndex = 2;
            this.lblDescripcionDeporte.Text = "Descripcion ";
            this.lblDescripcionDeporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescripcionDeporte
            // 
            this.txtDescripcionDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionDeporte.Location = new System.Drawing.Point(176, 112);
            this.txtDescripcionDeporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionDeporte.Name = "txtDescripcionDeporte";
            this.txtDescripcionDeporte.Size = new System.Drawing.Size(196, 34);
            this.txtDescripcionDeporte.TabIndex = 3;
            // 
            // btnGuardarDeporte
            // 
            this.btnGuardarDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDeporte.Location = new System.Drawing.Point(56, 160);
            this.btnGuardarDeporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarDeporte.Name = "btnGuardarDeporte";
            this.btnGuardarDeporte.Size = new System.Drawing.Size(141, 38);
            this.btnGuardarDeporte.TabIndex = 4;
            this.btnGuardarDeporte.Text = "Guardar";
            this.btnGuardarDeporte.UseVisualStyleBackColor = true;
            this.btnGuardarDeporte.Click += new System.EventHandler(this.BotonGuardarDeporte_Click);
            // 
            // lblNombreDeporte
            // 
            this.lblNombreDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDeporte.Location = new System.Drawing.Point(48, 56);
            this.lblNombreDeporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreDeporte.Name = "lblNombreDeporte";
            this.lblNombreDeporte.Size = new System.Drawing.Size(120, 32);
            this.lblNombreDeporte.TabIndex = 5;
            this.lblNombreDeporte.Text = "Nombre *";
            this.lblNombreDeporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancelarDeporte
            // 
            this.btnCancelarDeporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelarDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarDeporte.Location = new System.Drawing.Point(256, 160);
            this.btnCancelarDeporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarDeporte.Name = "btnCancelarDeporte";
            this.btnCancelarDeporte.Size = new System.Drawing.Size(149, 42);
            this.btnCancelarDeporte.TabIndex = 6;
            this.btnCancelarDeporte.Text = "Cancelar";
            this.btnCancelarDeporte.UseVisualStyleBackColor = true;
            this.btnCancelarDeporte.Click += new System.EventHandler(this.BotonCancelarDeporte_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "* Los campos son obligatorios";
            // 
            // InterfazAltaDeporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 241);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreDeporte);
            this.Controls.Add(this.txtDescripcionDeporte);
            this.Controls.Add(this.btnCancelarDeporte);
            this.Controls.Add(this.btnGuardarDeporte);
            this.Controls.Add(this.lblNombreDeporte);
            this.Controls.Add(this.lblDescripcionDeporte);
            this.Controls.Add(this.lblTituloDeporte);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InterfazAltaDeporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion Deportes";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloDeporte;
        private System.Windows.Forms.TextBox txtNombreDeporte;
        private System.Windows.Forms.Label lblDescripcionDeporte;
        private System.Windows.Forms.TextBox txtDescripcionDeporte;
        private System.Windows.Forms.Button btnGuardarDeporte;
        private System.Windows.Forms.Label lblNombreDeporte;
        private System.Windows.Forms.Button btnCancelarDeporte;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
    }
}

