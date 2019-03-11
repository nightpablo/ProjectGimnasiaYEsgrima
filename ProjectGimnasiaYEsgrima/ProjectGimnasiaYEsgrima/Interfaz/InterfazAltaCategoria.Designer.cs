using System;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazAltaCategoria
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
            this.lblTituloCategoria = new System.Windows.Forms.Label();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.lblFechaInicioCategoria = new System.Windows.Forms.Label();
            this.lblFechaFinCategoria = new System.Windows.Forms.Label();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.btnGuardarCategoria = new System.Windows.Forms.Button();
            this.btnCancelarCategoria = new System.Windows.Forms.Button();
            this.dtpInicioCategoria = new System.Windows.Forms.DateTimePicker();
            this.dtpFinCategoria = new System.Windows.Forms.DateTimePicker();
            this.lblDeporteCategoria = new System.Windows.Forms.Label();
            this.cbxDeporte = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtImporteMensualCategoria = new System.Windows.Forms.TextBox();
            this.lblImporteMensualCategoria = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloCategoria
            // 
            this.lblTituloCategoria.AutoSize = true;
            this.lblTituloCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCategoria.Location = new System.Drawing.Point(24, 0);
            this.lblTituloCategoria.Name = "lblTituloCategoria";
            this.lblTituloCategoria.Size = new System.Drawing.Size(147, 32);
            this.lblTituloCategoria.TabIndex = 0;
            this.lblTituloCategoria.Text = "Alta Categoria";
            this.lblTituloCategoria.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCategoria.Location = new System.Drawing.Point(147, 96);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(117, 29);
            this.lblNombreCategoria.TabIndex = 1;
            this.lblNombreCategoria.Text = "Nombre *";
            this.lblNombreCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaInicioCategoria
            // 
            this.lblFechaInicioCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicioCategoria.Location = new System.Drawing.Point(16, 208);
            this.lblFechaInicioCategoria.Name = "lblFechaInicioCategoria";
            this.lblFechaInicioCategoria.Size = new System.Drawing.Size(229, 29);
            this.lblFechaInicioCategoria.TabIndex = 3;
            this.lblFechaInicioCategoria.Text = "Fecha Inicio Categoria *";
            // 
            // lblFechaFinCategoria
            // 
            this.lblFechaFinCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinCategoria.Location = new System.Drawing.Point(352, 208);
            this.lblFechaFinCategoria.Name = "lblFechaFinCategoria";
            this.lblFechaFinCategoria.Size = new System.Drawing.Size(206, 29);
            this.lblFechaFinCategoria.TabIndex = 5;
            this.lblFechaFinCategoria.Text = "Fecha Fin Categoria *";
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCategoria.Location = new System.Drawing.Point(320, 96);
            this.txtNombreCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(288, 34);
            this.txtNombreCategoria.TabIndex = 2;
            // 
            // btnGuardarCategoria
            // 
            this.btnGuardarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCategoria.Location = new System.Drawing.Point(117, 288);
            this.btnGuardarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarCategoria.Name = "btnGuardarCategoria";
            this.btnGuardarCategoria.Size = new System.Drawing.Size(147, 48);
            this.btnGuardarCategoria.TabIndex = 6;
            this.btnGuardarCategoria.Text = "Guardar";
            this.btnGuardarCategoria.UseVisualStyleBackColor = true;
            this.btnGuardarCategoria.Click += new System.EventHandler(this.BotonGuardarCategoria_Click);
            // 
            // btnCancelarCategoria
            // 
            this.btnCancelarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCategoria.Location = new System.Drawing.Point(400, 288);
            this.btnCancelarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarCategoria.Name = "btnCancelarCategoria";
            this.btnCancelarCategoria.Size = new System.Drawing.Size(144, 48);
            this.btnCancelarCategoria.TabIndex = 7;
            this.btnCancelarCategoria.Text = "Cancelar";
            this.btnCancelarCategoria.UseVisualStyleBackColor = true;
            this.btnCancelarCategoria.Click += new System.EventHandler(this.BotonCancelarCategoria_Click);
            // 
            // dtpInicioCategoria
            // 
            this.dtpInicioCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicioCategoria.Location = new System.Drawing.Point(40, 240);
            this.dtpInicioCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpInicioCategoria.Name = "dtpInicioCategoria";
            this.dtpInicioCategoria.Size = new System.Drawing.Size(264, 34);
            this.dtpInicioCategoria.TabIndex = 4;
            // 
            // dtpFinCategoria
            // 
            this.dtpFinCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinCategoria.Location = new System.Drawing.Point(384, 240);
            this.dtpFinCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFinCategoria.Name = "dtpFinCategoria";
            this.dtpFinCategoria.Size = new System.Drawing.Size(264, 34);
            this.dtpFinCategoria.TabIndex = 5;
            // 
            // lblDeporteCategoria
            // 
            this.lblDeporteCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporteCategoria.Location = new System.Drawing.Point(148, 48);
            this.lblDeporteCategoria.Name = "lblDeporteCategoria";
            this.lblDeporteCategoria.Size = new System.Drawing.Size(116, 29);
            this.lblDeporteCategoria.TabIndex = 1;
            this.lblDeporteCategoria.Text = "Deporte *";
            this.lblDeporteCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDeporteCategoria.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbxDeporte
            // 
            this.cbxDeporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDeporte.FormattingEnabled = true;
            this.cbxDeporte.Location = new System.Drawing.Point(320, 48);
            this.cbxDeporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxDeporte.Name = "cbxDeporte";
            this.cbxDeporte.Size = new System.Drawing.Size(288, 37);
            this.cbxDeporte.TabIndex = 1;
            this.cbxDeporte.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDeporte_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtImporteMensualCategoria
            // 
            this.txtImporteMensualCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporteMensualCategoria.Location = new System.Drawing.Point(320, 152);
            this.txtImporteMensualCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImporteMensualCategoria.Name = "txtImporteMensualCategoria";
            this.txtImporteMensualCategoria.Size = new System.Drawing.Size(288, 34);
            this.txtImporteMensualCategoria.TabIndex = 3;
            this.txtImporteMensualCategoria.Text = "0";
            // 
            // lblImporteMensualCategoria
            // 
            this.lblImporteMensualCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporteMensualCategoria.Location = new System.Drawing.Point(56, 152);
            this.lblImporteMensualCategoria.Name = "lblImporteMensualCategoria";
            this.lblImporteMensualCategoria.Size = new System.Drawing.Size(208, 29);
            this.lblImporteMensualCategoria.TabIndex = 11;
            this.lblImporteMensualCategoria.Text = "Importe Mensual *";
            this.lblImporteMensualCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblImporteMensualCategoria.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "* Los campos son obligatorios";
            // 
            // InterfazAltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImporteMensualCategoria);
            this.Controls.Add(this.lblImporteMensualCategoria);
            this.Controls.Add(this.cbxDeporte);
            this.Controls.Add(this.txtNombreCategoria);
            this.Controls.Add(this.dtpInicioCategoria);
            this.Controls.Add(this.dtpFinCategoria);
            this.Controls.Add(this.btnGuardarCategoria);
            this.Controls.Add(this.btnCancelarCategoria);
            this.Controls.Add(this.lblFechaFinCategoria);
            this.Controls.Add(this.lblFechaInicioCategoria);
            this.Controls.Add(this.lblDeporteCategoria);
            this.Controls.Add(this.lblNombreCategoria);
            this.Controls.Add(this.lblTituloCategoria);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InterfazAltaCategoria";
            this.Text = "InterfazAltaCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblTituloCategoria;
        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.Label lblFechaInicioCategoria;
        private System.Windows.Forms.Label lblFechaFinCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Button btnGuardarCategoria;
        private System.Windows.Forms.Button btnCancelarCategoria;
        private System.Windows.Forms.DateTimePicker dtpInicioCategoria;
        private System.Windows.Forms.DateTimePicker dtpFinCategoria;
        private System.Windows.Forms.Label lblDeporteCategoria;
        private System.Windows.Forms.ComboBox cbxDeporte;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtImporteMensualCategoria;
        private System.Windows.Forms.Label lblImporteMensualCategoria;
        private System.Windows.Forms.Label label2;
    }
}