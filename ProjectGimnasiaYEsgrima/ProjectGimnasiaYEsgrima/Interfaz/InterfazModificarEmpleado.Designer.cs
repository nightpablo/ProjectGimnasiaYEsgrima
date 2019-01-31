namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazModificarEmpleado
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
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.lblApellidoEmpleado = new System.Windows.Forms.Label();
            this.txtDNIEmpleado = new System.Windows.Forms.TextBox();
            this.lblDNIEmpleado = new System.Windows.Forms.Label();
            this.lblFechaNacimientoEmpleado = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblTipoEmpleado = new System.Windows.Forms.Label();
            this.lblFechaInicioEmpleado = new System.Windows.Forms.Label();
            this.dtpInicioEmpleado = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcionEmpleado = new System.Windows.Forms.TextBox();
            this.lblDescripcionEmpleado = new System.Windows.Forms.Label();
            this.lblTituloEmpleado = new System.Windows.Forms.Label();
            this.btnGuardarEmpleado = new System.Windows.Forms.Button();
            this.dbGimnasiaYEsgrimaDataSet = new ProjectGimnasiaYEsgrima.dbGimnasiaYEsgrimaDataSet();
            this.dbGimnasiaYEsgrimaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbGimnasiaYEsgrimaDataSet1 = new ProjectGimnasiaYEsgrima.dbGimnasiaYEsgrimaDataSet1();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new ProjectGimnasiaYEsgrima.dbGimnasiaYEsgrimaDataSet1TableAdapters.EmpleadosTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtTipoEmpleado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbGimnasiaYEsgrimaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGimnasiaYEsgrimaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGimnasiaYEsgrimaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpleado.Location = new System.Drawing.Point(296, 39);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(251, 34);
            this.txtNombreEmpleado.TabIndex = 1;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.Location = new System.Drawing.Point(96, 42);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(187, 30);
            this.lblNombreEmpleado.TabIndex = 2;
            this.lblNombreEmpleado.Text = "Nombre *";
            this.lblNombreEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(296, 77);
            this.txtApellidoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(251, 34);
            this.txtApellidoEmpleado.TabIndex = 2;
            // 
            // lblApellidoEmpleado
            // 
            this.lblApellidoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoEmpleado.Location = new System.Drawing.Point(96, 80);
            this.lblApellidoEmpleado.Name = "lblApellidoEmpleado";
            this.lblApellidoEmpleado.Size = new System.Drawing.Size(187, 32);
            this.lblApellidoEmpleado.TabIndex = 2;
            this.lblApellidoEmpleado.Text = "Apellido *";
            this.lblApellidoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDNIEmpleado
            // 
            this.txtDNIEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNIEmpleado.Location = new System.Drawing.Point(296, 120);
            this.txtDNIEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDNIEmpleado.Name = "txtDNIEmpleado";
            this.txtDNIEmpleado.Size = new System.Drawing.Size(251, 34);
            this.txtDNIEmpleado.TabIndex = 10;
            // 
            // lblDNIEmpleado
            // 
            this.lblDNIEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNIEmpleado.Location = new System.Drawing.Point(120, 122);
            this.lblDNIEmpleado.Name = "lblDNIEmpleado";
            this.lblDNIEmpleado.Size = new System.Drawing.Size(155, 30);
            this.lblDNIEmpleado.TabIndex = 2;
            this.lblDNIEmpleado.Text = "DNI";
            this.lblDNIEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaNacimientoEmpleado
            // 
            this.lblFechaNacimientoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimientoEmpleado.Location = new System.Drawing.Point(8, 162);
            this.lblFechaNacimientoEmpleado.Name = "lblFechaNacimientoEmpleado";
            this.lblFechaNacimientoEmpleado.Size = new System.Drawing.Size(267, 30);
            this.lblFechaNacimientoEmpleado.TabIndex = 2;
            this.lblFechaNacimientoEmpleado.Text = "Fecha de nacimiento *";
            this.lblFechaNacimientoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(296, 160);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(251, 34);
            this.dtpFechaNacimiento.TabIndex = 3;
            // 
            // lblTipoEmpleado
            // 
            this.lblTipoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEmpleado.Location = new System.Drawing.Point(24, 284);
            this.lblTipoEmpleado.Name = "lblTipoEmpleado";
            this.lblTipoEmpleado.Size = new System.Drawing.Size(251, 28);
            this.lblTipoEmpleado.TabIndex = 2;
            this.lblTipoEmpleado.Text = "Tipo de Empleado";
            this.lblTipoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaInicioEmpleado
            // 
            this.lblFechaInicioEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicioEmpleado.Location = new System.Drawing.Point(48, 202);
            this.lblFechaInicioEmpleado.Name = "lblFechaInicioEmpleado";
            this.lblFechaInicioEmpleado.Size = new System.Drawing.Size(227, 30);
            this.lblFechaInicioEmpleado.TabIndex = 2;
            this.lblFechaInicioEmpleado.Text = "Fecha de inicio *";
            this.lblFechaInicioEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpInicioEmpleado
            // 
            this.dtpInicioEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicioEmpleado.Location = new System.Drawing.Point(296, 200);
            this.dtpInicioEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpInicioEmpleado.Name = "dtpInicioEmpleado";
            this.dtpInicioEmpleado.Size = new System.Drawing.Size(251, 34);
            this.dtpInicioEmpleado.TabIndex = 4;
            // 
            // txtDescripcionEmpleado
            // 
            this.txtDescripcionEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionEmpleado.Location = new System.Drawing.Point(296, 240);
            this.txtDescripcionEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcionEmpleado.Name = "txtDescripcionEmpleado";
            this.txtDescripcionEmpleado.Size = new System.Drawing.Size(251, 34);
            this.txtDescripcionEmpleado.TabIndex = 5;
            // 
            // lblDescripcionEmpleado
            // 
            this.lblDescripcionEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionEmpleado.Location = new System.Drawing.Point(32, 242);
            this.lblDescripcionEmpleado.Name = "lblDescripcionEmpleado";
            this.lblDescripcionEmpleado.Size = new System.Drawing.Size(243, 30);
            this.lblDescripcionEmpleado.TabIndex = 2;
            this.lblDescripcionEmpleado.Text = "Descripción Tarea";
            this.lblDescripcionEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTituloEmpleado
            // 
            this.lblTituloEmpleado.AutoSize = true;
            this.lblTituloEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEmpleado.Location = new System.Drawing.Point(24, 0);
            this.lblTituloEmpleado.Name = "lblTituloEmpleado";
            this.lblTituloEmpleado.Size = new System.Drawing.Size(311, 32);
            this.lblTituloEmpleado.TabIndex = 2;
            this.lblTituloEmpleado.Text = "Modificación Empleado";
            // 
            // btnGuardarEmpleado
            // 
            this.btnGuardarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarEmpleado.Location = new System.Drawing.Point(144, 327);
            this.btnGuardarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarEmpleado.Name = "btnGuardarEmpleado";
            this.btnGuardarEmpleado.Size = new System.Drawing.Size(139, 49);
            this.btnGuardarEmpleado.TabIndex = 6;
            this.btnGuardarEmpleado.Text = "Guardar";
            this.btnGuardarEmpleado.UseVisualStyleBackColor = true;
            this.btnGuardarEmpleado.Click += new System.EventHandler(this.BotonGuardarEmpleado_Click);
            // 
            // dbGimnasiaYEsgrimaDataSet
            // 
            this.dbGimnasiaYEsgrimaDataSet.DataSetName = "dbGimnasiaYEsgrimaDataSet";
            this.dbGimnasiaYEsgrimaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbGimnasiaYEsgrimaDataSetBindingSource
            // 
            this.dbGimnasiaYEsgrimaDataSetBindingSource.DataSource = this.dbGimnasiaYEsgrimaDataSet;
            this.dbGimnasiaYEsgrimaDataSetBindingSource.Position = 0;
            // 
            // dbGimnasiaYEsgrimaDataSet1
            // 
            this.dbGimnasiaYEsgrimaDataSet1.DataSetName = "dbGimnasiaYEsgrimaDataSet1";
            this.dbGimnasiaYEsgrimaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.dbGimnasiaYEsgrimaDataSet1;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(24, 384);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "* Los campos son obligatorios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(331, 328);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 49);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // txtTipoEmpleado
            // 
            this.txtTipoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoEmpleado.Location = new System.Drawing.Point(296, 280);
            this.txtTipoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTipoEmpleado.Name = "txtTipoEmpleado";
            this.txtTipoEmpleado.Size = new System.Drawing.Size(251, 34);
            this.txtTipoEmpleado.TabIndex = 21;
            // 
            // InterfazModificarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 458);
            this.Controls.Add(this.txtTipoEmpleado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGuardarEmpleado);
            this.Controls.Add(this.lblFechaNacimientoEmpleado);
            this.Controls.Add(this.lblDescripcionEmpleado);
            this.Controls.Add(this.lblDNIEmpleado);
            this.Controls.Add(this.lblTipoEmpleado);
            this.Controls.Add(this.lblApellidoEmpleado);
            this.Controls.Add(this.lblFechaInicioEmpleado);
            this.Controls.Add(this.lblTituloEmpleado);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.txtApellidoEmpleado);
            this.Controls.Add(this.txtDNIEmpleado);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.dtpInicioEmpleado);
            this.Controls.Add(this.txtDescripcionEmpleado);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InterfazModificarEmpleado";
            this.Text = "InterfazAltaEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dbGimnasiaYEsgrimaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGimnasiaYEsgrimaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGimnasiaYEsgrimaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.Label lblApellidoEmpleado;
        private System.Windows.Forms.TextBox txtDNIEmpleado;
        private System.Windows.Forms.Label lblDNIEmpleado;
        private System.Windows.Forms.Label lblFechaNacimientoEmpleado;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblTipoEmpleado;
        private System.Windows.Forms.Label lblFechaInicioEmpleado;
        private System.Windows.Forms.DateTimePicker dtpInicioEmpleado;
        private System.Windows.Forms.TextBox txtDescripcionEmpleado;
        private System.Windows.Forms.Label lblDescripcionEmpleado;
        private System.Windows.Forms.Label lblTituloEmpleado;
        private System.Windows.Forms.Button btnGuardarEmpleado;
        private System.Windows.Forms.BindingSource dbGimnasiaYEsgrimaDataSetBindingSource;
        private dbGimnasiaYEsgrimaDataSet dbGimnasiaYEsgrimaDataSet;
        private dbGimnasiaYEsgrimaDataSet1 dbGimnasiaYEsgrimaDataSet1;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private dbGimnasiaYEsgrimaDataSet1TableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTipoEmpleado;
    }
}