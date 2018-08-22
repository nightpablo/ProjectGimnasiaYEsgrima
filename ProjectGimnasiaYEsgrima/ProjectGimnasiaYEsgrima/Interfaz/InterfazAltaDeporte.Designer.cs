
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
            this.labelAltaDeporte = new System.Windows.Forms.Label();
            this.txtNombreDeporte = new System.Windows.Forms.TextBox();
            this.labelAltaDeporteDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcionDeporte = new System.Windows.Forms.TextBox();
            this.BotonGuardarDeporte = new System.Windows.Forms.Button();
            this.labelAltaDeporteNombbre = new System.Windows.Forms.Label();
            this.BotonCancelarDeporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelAltaDeporte
            // 
            this.labelAltaDeporte.AutoSize = true;
            this.labelAltaDeporte.Location = new System.Drawing.Point(69, 30);
            this.labelAltaDeporte.Name = "labelAltaDeporte";
            this.labelAltaDeporte.Size = new System.Drawing.Size(69, 13);
            this.labelAltaDeporte.TabIndex = 0;
            this.labelAltaDeporte.Text = "Alta  Deporte";
            this.labelAltaDeporte.Click += new System.EventHandler(this.labelAltaDeporte_Click);
            // 
            // txtNombreDeporte
            // 
            this.txtNombreDeporte.Location = new System.Drawing.Point(153, 71);
            this.txtNombreDeporte.Name = "txtNombreDeporte";
            this.txtNombreDeporte.Size = new System.Drawing.Size(149, 20);
            this.txtNombreDeporte.TabIndex = 1;
            // 
            // labelAltaDeporteDescripcion
            // 
            this.labelAltaDeporteDescripcion.AutoSize = true;
            this.labelAltaDeporteDescripcion.Location = new System.Drawing.Point(47, 123);
            this.labelAltaDeporteDescripcion.Name = "labelAltaDeporteDescripcion";
            this.labelAltaDeporteDescripcion.Size = new System.Drawing.Size(66, 13);
            this.labelAltaDeporteDescripcion.TabIndex = 2;
            this.labelAltaDeporteDescripcion.Text = "Descripcion ";
            // 
            // txtDescripcionDeporte
            // 
            this.txtDescripcionDeporte.Location = new System.Drawing.Point(153, 120);
            this.txtDescripcionDeporte.Name = "txtDescripcionDeporte";
            this.txtDescripcionDeporte.Size = new System.Drawing.Size(148, 20);
            this.txtDescripcionDeporte.TabIndex = 3;
            // 
            // BotonGuardarDeporte
            // 
            this.BotonGuardarDeporte.Location = new System.Drawing.Point(50, 167);
            this.BotonGuardarDeporte.Name = "BotonGuardarDeporte";
            this.BotonGuardarDeporte.Size = new System.Drawing.Size(106, 31);
            this.BotonGuardarDeporte.TabIndex = 4;
            this.BotonGuardarDeporte.Text = "Guardar";
            this.BotonGuardarDeporte.UseVisualStyleBackColor = true;
            this.BotonGuardarDeporte.Click += new System.EventHandler(this.BotonGuardarDeporte_Click);
            // 
            // labelAltaDeporteNombbre
            // 
            this.labelAltaDeporteNombbre.AutoSize = true;
            this.labelAltaDeporteNombbre.Location = new System.Drawing.Point(69, 78);
            this.labelAltaDeporteNombbre.Name = "labelAltaDeporteNombbre";
            this.labelAltaDeporteNombbre.Size = new System.Drawing.Size(44, 13);
            this.labelAltaDeporteNombbre.TabIndex = 5;
            this.labelAltaDeporteNombbre.Text = "Nombre";
            // 
            // BotonCancelarDeporte
            // 
            this.BotonCancelarDeporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.BotonCancelarDeporte.Location = new System.Drawing.Point(190, 164);
            this.BotonCancelarDeporte.Name = "BotonCancelarDeporte";
            this.BotonCancelarDeporte.Size = new System.Drawing.Size(112, 34);
            this.BotonCancelarDeporte.TabIndex = 6;
            this.BotonCancelarDeporte.Text = "Cancelar";
            this.BotonCancelarDeporte.UseVisualStyleBackColor = true;
            this.BotonCancelarDeporte.Click += new System.EventHandler(this.BotonCancelarDeporte_Click);
            // 
            // InterfazAltaDeporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonCancelarDeporte);
            this.Controls.Add(this.labelAltaDeporteNombbre);
            this.Controls.Add(this.BotonGuardarDeporte);
            this.Controls.Add(this.txtDescripcionDeporte);
            this.Controls.Add(this.labelAltaDeporteDescripcion);
            this.Controls.Add(this.txtNombreDeporte);
            this.Controls.Add(this.labelAltaDeporte);
            this.Name = "InterfazAltaDeporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion Deportes";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAltaDeporte;
        private System.Windows.Forms.TextBox txtNombreDeporte;
        private System.Windows.Forms.Label labelAltaDeporteDescripcion;
        private System.Windows.Forms.TextBox txtDescripcionDeporte;
        private System.Windows.Forms.Button BotonGuardarDeporte;
        private System.Windows.Forms.Label labelAltaDeporteNombbre;
        private System.Windows.Forms.Button BotonCancelarDeporte;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

