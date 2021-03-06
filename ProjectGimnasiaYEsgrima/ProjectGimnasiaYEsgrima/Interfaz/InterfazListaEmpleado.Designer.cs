﻿namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazListaEmpleado
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
            this.lblInfoEmpleado = new System.Windows.Forms.Label();
            this.btnCrearEmpleado = new System.Windows.Forms.Button();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.txtDNIEmpleado = new System.Windows.Forms.TextBox();
            this.lblDNIEmpleado = new System.Windows.Forms.Label();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.lblApellidoEmpleado = new System.Windows.Forms.Label();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.lblTipoEmpleado = new System.Windows.Forms.Label();
            this.cbxTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.dgvEmpleadoPersona = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EmitirCarnet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTituloEmpleado = new System.Windows.Forms.Label();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadoPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoPersonaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfoEmpleado
            // 
            this.lblInfoEmpleado.AutoSize = true;
            this.lblInfoEmpleado.Font = new System.Drawing.Font("Arial Black", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoEmpleado.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblInfoEmpleado.Location = new System.Drawing.Point(12, 338);
            this.lblInfoEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfoEmpleado.Name = "lblInfoEmpleado";
            this.lblInfoEmpleado.Size = new System.Drawing.Size(165, 19);
            this.lblInfoEmpleado.TabIndex = 16;
            this.lblInfoEmpleado.Text = "Acá se imprime algo";
            // 
            // btnCrearEmpleado
            // 
            this.btnCrearEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEmpleado.Location = new System.Drawing.Point(300, 117);
            this.btnCrearEmpleado.Name = "btnCrearEmpleado";
            this.btnCrearEmpleado.Size = new System.Drawing.Size(162, 38);
            this.btnCrearEmpleado.TabIndex = 6;
            this.btnCrearEmpleado.Text = "Crear Empleado";
            this.btnCrearEmpleado.UseVisualStyleBackColor = true;
            this.btnCrearEmpleado.Click += new System.EventHandler(this.BotonCrearEmpleado_Click);
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(168, 117);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(108, 38);
            this.btnBuscarEmpleado.TabIndex = 5;
            this.btnBuscarEmpleado.Text = "Buscar";
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.BotonBuscarEmpleado_Click);
            // 
            // txtDNIEmpleado
            // 
            this.txtDNIEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNIEmpleado.Location = new System.Drawing.Point(462, 72);
            this.txtDNIEmpleado.Name = "txtDNIEmpleado";
            this.txtDNIEmpleado.Size = new System.Drawing.Size(133, 29);
            this.txtDNIEmpleado.TabIndex = 4;
            // 
            // lblDNIEmpleado
            // 
            this.lblDNIEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNIEmpleado.Location = new System.Drawing.Point(384, 72);
            this.lblDNIEmpleado.Name = "lblDNIEmpleado";
            this.lblDNIEmpleado.Size = new System.Drawing.Size(65, 24);
            this.lblDNIEmpleado.TabIndex = 11;
            this.lblDNIEmpleado.Text = "DNI";
            this.lblDNIEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.Location = new System.Drawing.Point(44, 41);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(88, 24);
            this.lblNombreEmpleado.TabIndex = 10;
            this.lblNombreEmpleado.Text = "Nombre";
            this.lblNombreEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpleado.Location = new System.Drawing.Point(144, 39);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(133, 29);
            this.txtNombreEmpleado.TabIndex = 1;
            // 
            // lblApellidoEmpleado
            // 
            this.lblApellidoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoEmpleado.Location = new System.Drawing.Point(49, 74);
            this.lblApellidoEmpleado.Name = "lblApellidoEmpleado";
            this.lblApellidoEmpleado.Size = new System.Drawing.Size(83, 24);
            this.lblApellidoEmpleado.TabIndex = 10;
            this.lblApellidoEmpleado.Text = "Apellido";
            this.lblApellidoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(144, 72);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(133, 29);
            this.txtApellidoEmpleado.TabIndex = 2;
            // 
            // lblTipoEmpleado
            // 
            this.lblTipoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEmpleado.Location = new System.Drawing.Point(290, 39);
            this.lblTipoEmpleado.Name = "lblTipoEmpleado";
            this.lblTipoEmpleado.Size = new System.Drawing.Size(159, 24);
            this.lblTipoEmpleado.TabIndex = 10;
            this.lblTipoEmpleado.Text = "Tipo de empleado";
            this.lblTipoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxTipoEmpleado
            // 
            this.cbxTipoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipoEmpleado.FormattingEnabled = true;
            this.cbxTipoEmpleado.Location = new System.Drawing.Point(462, 39);
            this.cbxTipoEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxTipoEmpleado.Name = "cbxTipoEmpleado";
            this.cbxTipoEmpleado.Size = new System.Drawing.Size(133, 32);
            this.cbxTipoEmpleado.TabIndex = 3;
            // 
            // dgvEmpleadoPersona
            // 
            this.dgvEmpleadoPersona.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleadoPersona.AutoGenerateColumns = false;
            this.dgvEmpleadoPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadoPersona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.dNIDataGridViewTextBoxColumn,
            this.tipoEmpleadoDataGridViewTextBoxColumn,
            this.Modificar,
            this.Eliminar,
            this.EmitirCarnet});
            this.dgvEmpleadoPersona.DataSource = this.empleadoPersonaBindingSource;
            this.dgvEmpleadoPersona.Location = new System.Drawing.Point(6, 169);
            this.dgvEmpleadoPersona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEmpleadoPersona.Name = "dgvEmpleadoPersona";
            this.dgvEmpleadoPersona.RowTemplate.Height = 24;
            this.dgvEmpleadoPersona.Size = new System.Drawing.Size(612, 158);
            this.dgvEmpleadoPersona.TabIndex = 8;
            this.dgvEmpleadoPersona.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewEmpleadoPersona_CellContentClick);
            // 
            // Modificar
            // 
            this.Modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseColumnTextForButtonValue = true;
            this.Modificar.Width = 21;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 21;
            // 
            // EmitirCarnet
            // 
            this.EmitirCarnet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EmitirCarnet.HeaderText = "";
            this.EmitirCarnet.Name = "EmitirCarnet";
            this.EmitirCarnet.ReadOnly = true;
            this.EmitirCarnet.Text = "EmitirCarnet";
            this.EmitirCarnet.UseColumnTextForButtonValue = true;
            this.EmitirCarnet.Width = 21;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(510, 117);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 37);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // lblTituloEmpleado
            // 
            this.lblTituloEmpleado.AutoSize = true;
            this.lblTituloEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEmpleado.Location = new System.Drawing.Point(24, 6);
            this.lblTituloEmpleado.Name = "lblTituloEmpleado";
            this.lblTituloEmpleado.Size = new System.Drawing.Size(233, 26);
            this.lblTituloEmpleado.TabIndex = 10;
            this.lblTituloEmpleado.Text = "Gestión de Empleados";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            this.dNIDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            // 
            // tipoEmpleadoDataGridViewTextBoxColumn
            // 
            this.tipoEmpleadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "TipoEmpleado";
            this.tipoEmpleadoDataGridViewTextBoxColumn.HeaderText = "TipoEmpleado";
            this.tipoEmpleadoDataGridViewTextBoxColumn.Name = "tipoEmpleadoDataGridViewTextBoxColumn";
            // 
            // empleadoPersonaBindingSource
            // 
            this.empleadoPersonaBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.ModelEmpleadoPersona);
            // 
            // InterfazListaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 367);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvEmpleadoPersona);
            this.Controls.Add(this.cbxTipoEmpleado);
            this.Controls.Add(this.lblInfoEmpleado);
            this.Controls.Add(this.btnCrearEmpleado);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.txtApellidoEmpleado);
            this.Controls.Add(this.txtDNIEmpleado);
            this.Controls.Add(this.lblApellidoEmpleado);
            this.Controls.Add(this.lblDNIEmpleado);
            this.Controls.Add(this.lblTipoEmpleado);
            this.Controls.Add(this.lblTituloEmpleado);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InterfazListaEmpleado";
            this.Text = "InterfazListaEmpleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InterfazListaEmpleado_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadoPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoPersonaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoEmpleado;
        private System.Windows.Forms.Button btnCrearEmpleado;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.TextBox txtDNIEmpleado;
        private System.Windows.Forms.Label lblDNIEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label lblApellidoEmpleado;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.Label lblTipoEmpleado;
        private System.Windows.Forms.ComboBox cbxTipoEmpleado;
        private System.Windows.Forms.DataGridView dgvEmpleadoPersona;
        private System.Windows.Forms.BindingSource empleadoPersonaBindingSource;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTituloEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn EmitirCarnet;
    }
}