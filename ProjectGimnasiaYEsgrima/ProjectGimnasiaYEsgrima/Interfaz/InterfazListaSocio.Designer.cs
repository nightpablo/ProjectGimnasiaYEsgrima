﻿namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazListaSocio
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
            this.labelDeporteListarEmpleado = new System.Windows.Forms.Label();
            this.txtNombreSocio = new System.Windows.Forms.TextBox();
            this.labelEmpleadoListarEmpleado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNISocio = new System.Windows.Forms.TextBox();
            this.txtApellidoSocio = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.botonCrearSocio = new System.Windows.Forms.Button();
            this.BotonBuscarSocio = new System.Windows.Forms.Button();
            this.dataGridViewSocioPersona = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.modelSocioPersonaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.modelSocioPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelInfoSocio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSocioPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelSocioPersonaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelSocioPersonaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDeporteListarEmpleado
            // 
            this.labelDeporteListarEmpleado.AutoSize = true;
            this.labelDeporteListarEmpleado.Location = new System.Drawing.Point(53, 35);
            this.labelDeporteListarEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeporteListarEmpleado.Name = "labelDeporteListarEmpleado";
            this.labelDeporteListarEmpleado.Size = new System.Drawing.Size(58, 17);
            this.labelDeporteListarEmpleado.TabIndex = 16;
            this.labelDeporteListarEmpleado.Text = "Nombre";
            // 
            // txtNombreSocio
            // 
            this.txtNombreSocio.Location = new System.Drawing.Point(157, 32);
            this.txtNombreSocio.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreSocio.Name = "txtNombreSocio";
            this.txtNombreSocio.Size = new System.Drawing.Size(160, 22);
            this.txtNombreSocio.TabIndex = 18;
            // 
            // labelEmpleadoListarEmpleado
            // 
            this.labelEmpleadoListarEmpleado.AutoSize = true;
            this.labelEmpleadoListarEmpleado.Location = new System.Drawing.Point(53, 95);
            this.labelEmpleadoListarEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmpleadoListarEmpleado.Name = "labelEmpleadoListarEmpleado";
            this.labelEmpleadoListarEmpleado.Size = new System.Drawing.Size(31, 17);
            this.labelEmpleadoListarEmpleado.TabIndex = 17;
            this.labelEmpleadoListarEmpleado.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Apellido";
            // 
            // txtDNISocio
            // 
            this.txtDNISocio.Location = new System.Drawing.Point(157, 92);
            this.txtDNISocio.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNISocio.Name = "txtDNISocio";
            this.txtDNISocio.Size = new System.Drawing.Size(160, 22);
            this.txtDNISocio.TabIndex = 20;
            // 
            // txtApellidoSocio
            // 
            this.txtApellidoSocio.Location = new System.Drawing.Point(157, 62);
            this.txtApellidoSocio.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoSocio.Name = "txtApellidoSocio";
            this.txtApellidoSocio.Size = new System.Drawing.Size(160, 22);
            this.txtApellidoSocio.TabIndex = 19;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(736, 376);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(97, 32);
            this.btnVolver.TabIndex = 24;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // botonCrearSocio
            // 
            this.botonCrearSocio.Location = new System.Drawing.Point(697, 92);
            this.botonCrearSocio.Margin = new System.Windows.Forms.Padding(4);
            this.botonCrearSocio.Name = "botonCrearSocio";
            this.botonCrearSocio.Size = new System.Drawing.Size(136, 28);
            this.botonCrearSocio.TabIndex = 22;
            this.botonCrearSocio.Text = "Crear Socio";
            this.botonCrearSocio.UseVisualStyleBackColor = true;
            this.botonCrearSocio.Click += new System.EventHandler(this.botonCrearSocio_Click);
            // 
            // BotonBuscarSocio
            // 
            this.BotonBuscarSocio.Location = new System.Drawing.Point(556, 92);
            this.BotonBuscarSocio.Margin = new System.Windows.Forms.Padding(4);
            this.BotonBuscarSocio.Name = "BotonBuscarSocio";
            this.BotonBuscarSocio.Size = new System.Drawing.Size(133, 28);
            this.BotonBuscarSocio.TabIndex = 21;
            this.BotonBuscarSocio.Text = "Buscar";
            this.BotonBuscarSocio.UseVisualStyleBackColor = true;
            this.BotonBuscarSocio.Click += new System.EventHandler(this.BotonBuscarSocio_Click);
            // 
            // dataGridViewSocioPersona
            // 
            this.dataGridViewSocioPersona.AutoGenerateColumns = false;
            this.dataGridViewSocioPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSocioPersona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.dNIDataGridViewTextBoxColumn,
            this.Modificar,
            this.Eliminar});
            this.dataGridViewSocioPersona.DataSource = this.modelSocioPersonaBindingSource1;
            this.dataGridViewSocioPersona.Location = new System.Drawing.Point(46, 165);
            this.dataGridViewSocioPersona.Name = "dataGridViewSocioPersona";
            this.dataGridViewSocioPersona.RowTemplate.Height = 24;
            this.dataGridViewSocioPersona.Size = new System.Drawing.Size(735, 185);
            this.dataGridViewSocioPersona.TabIndex = 25;
            this.dataGridViewSocioPersona.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSocioPersona_CellContentClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            this.dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // modelSocioPersonaBindingSource1
            // 
            this.modelSocioPersonaBindingSource1.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.ModelSocioPersona);
            // 
            // modelSocioPersonaBindingSource
            // 
            this.modelSocioPersonaBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.ModelSocioPersona);
            // 
            // labelInfoSocio
            // 
            this.labelInfoSocio.AutoSize = true;
            this.labelInfoSocio.Font = new System.Drawing.Font("Arial Black", 9.8F, System.Drawing.FontStyle.Bold);
            this.labelInfoSocio.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.labelInfoSocio.Location = new System.Drawing.Point(48, 360);
            this.labelInfoSocio.Name = "labelInfoSocio";
            this.labelInfoSocio.Size = new System.Drawing.Size(199, 24);
            this.labelInfoSocio.TabIndex = 26;
            this.labelInfoSocio.Text = "Aca se imprime algo";
            // 
            // InterfazListaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.labelInfoSocio);
            this.Controls.Add(this.dataGridViewSocioPersona);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.botonCrearSocio);
            this.Controls.Add(this.BotonBuscarSocio);
            this.Controls.Add(this.txtNombreSocio);
            this.Controls.Add(this.txtApellidoSocio);
            this.Controls.Add(this.txtDNISocio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEmpleadoListarEmpleado);
            this.Controls.Add(this.labelDeporteListarEmpleado);
            this.Name = "InterfazListaSocio";
            this.Text = "InterfazListaSocio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSocioPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelSocioPersonaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelSocioPersonaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeporteListarEmpleado;
        private System.Windows.Forms.TextBox txtNombreSocio;
        private System.Windows.Forms.Label labelEmpleadoListarEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNISocio;
        private System.Windows.Forms.TextBox txtApellidoSocio;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button botonCrearSocio;
        private System.Windows.Forms.Button BotonBuscarSocio;
        private System.Windows.Forms.BindingSource modelSocioPersonaBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewSocioPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.BindingSource modelSocioPersonaBindingSource1;
        private System.Windows.Forms.Label labelInfoSocio;
    }
}