namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazAltaEmpleado
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
            this.ComboboxTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.textBoxNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeInicioEmpleado = new System.Windows.Forms.DateTimePicker();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.botonGuardarEmpleado = new System.Windows.Forms.Button();
            this.dbGimnasiaYEsgrimaDataSet = new ProjectGimnasiaYEsgrima.dbGimnasiaYEsgrimaDataSet();
            this.dbGimnasiaYEsgrimaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbGimnasiaYEsgrimaDataSet1 = new ProjectGimnasiaYEsgrima.dbGimnasiaYEsgrimaDataSet1();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new ProjectGimnasiaYEsgrima.dbGimnasiaYEsgrimaDataSet1TableAdapters.EmpleadosTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbGimnasiaYEsgrimaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGimnasiaYEsgrimaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGimnasiaYEsgrimaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboboxTipoEmpleado
            // 
            this.ComboboxTipoEmpleado.FormattingEnabled = true;
            this.ComboboxTipoEmpleado.Location = new System.Drawing.Point(157, 250);
            this.ComboboxTipoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboboxTipoEmpleado.Name = "ComboboxTipoEmpleado";
            this.ComboboxTipoEmpleado.Size = new System.Drawing.Size(251, 24);
            this.ComboboxTipoEmpleado.TabIndex = 0;
            this.ComboboxTipoEmpleado.Text = "Seleccione un tipo de empleado";
            this.ComboboxTipoEmpleado.SelectedIndexChanged += new System.EventHandler(this.ComboboxTipoEmpleado_SelectedIndexChanged);
            // 
            // textBoxNombreEmpleado
            // 
            this.textBoxNombreEmpleado.Location = new System.Drawing.Point(157, 39);
            this.textBoxNombreEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombreEmpleado.Name = "textBoxNombreEmpleado";
            this.textBoxNombreEmpleado.Size = new System.Drawing.Size(251, 22);
            this.textBoxNombreEmpleado.TabIndex = 1;
            this.textBoxNombreEmpleado.TextChanged += new System.EventHandler(this.TextBoxNombreEmpleado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre *";
            // 
            // textBoxApellidoEmpleado
            // 
            this.textBoxApellidoEmpleado.Location = new System.Drawing.Point(157, 68);
            this.textBoxApellidoEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxApellidoEmpleado.Name = "textBoxApellidoEmpleado";
            this.textBoxApellidoEmpleado.Size = new System.Drawing.Size(251, 22);
            this.textBoxApellidoEmpleado.TabIndex = 1;
            this.textBoxApellidoEmpleado.TextChanged += new System.EventHandler(this.TextBoxNombreEmpleado_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido *";
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(157, 96);
            this.textBoxDocumento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(251, 22);
            this.textBoxDocumento.TabIndex = 1;
            this.textBoxDocumento.TextChanged += new System.EventHandler(this.TextBoxNombreEmpleado_TextChanged);
            this.textBoxDocumento.Leave += new System.EventHandler(this.TextBoxDocumento_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha de nacimiento *";
            // 
            // dateTimeNacimiento
            // 
            this.dateTimeNacimiento.Location = new System.Drawing.Point(157, 126);
            this.dateTimeNacimiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeNacimiento.Name = "dateTimeNacimiento";
            this.dateTimeNacimiento.Size = new System.Drawing.Size(251, 22);
            this.dateTimeNacimiento.TabIndex = 3;
            this.dateTimeNacimiento.ValueChanged += new System.EventHandler(this.TextBoxNombreEmpleado_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tipo de Empleado *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fecha de inicio *";
            // 
            // dateTimeInicioEmpleado
            // 
            this.dateTimeInicioEmpleado.Location = new System.Drawing.Point(157, 192);
            this.dateTimeInicioEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeInicioEmpleado.Name = "dateTimeInicioEmpleado";
            this.dateTimeInicioEmpleado.Size = new System.Drawing.Size(251, 22);
            this.dateTimeInicioEmpleado.TabIndex = 3;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(157, 222);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(251, 22);
            this.textBoxDescripcion.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Descripción Tarea";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Detalle Persona";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Detalle Empleado";
            // 
            // botonGuardarEmpleado
            // 
            this.botonGuardarEmpleado.Location = new System.Drawing.Point(133, 293);
            this.botonGuardarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.botonGuardarEmpleado.Name = "botonGuardarEmpleado";
            this.botonGuardarEmpleado.Size = new System.Drawing.Size(100, 28);
            this.botonGuardarEmpleado.TabIndex = 5;
            this.botonGuardarEmpleado.Text = "Guardar";
            this.botonGuardarEmpleado.UseVisualStyleBackColor = true;
            this.botonGuardarEmpleado.Click += new System.EventHandler(this.BotonGuardarEmpleado_Click);
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
            this.label10.Location = new System.Drawing.Point(25, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "* Los campos son obligatorios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(267, 291);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 32);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // InterfazAltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 353);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.botonGuardarEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombreEmpleado);
            this.Controls.Add(this.textBoxApellidoEmpleado);
            this.Controls.Add(this.textBoxDocumento);
            this.Controls.Add(this.dateTimeNacimiento);
            this.Controls.Add(this.dateTimeInicioEmpleado);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.ComboboxTipoEmpleado);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InterfazAltaEmpleado";
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

        private System.Windows.Forms.ComboBox ComboboxTipoEmpleado;
        private System.Windows.Forms.TextBox textBoxNombreEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxApellidoEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeNacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeInicioEmpleado;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button botonGuardarEmpleado;
        private System.Windows.Forms.BindingSource dbGimnasiaYEsgrimaDataSetBindingSource;
        private dbGimnasiaYEsgrimaDataSet dbGimnasiaYEsgrimaDataSet;
        private dbGimnasiaYEsgrimaDataSet1 dbGimnasiaYEsgrimaDataSet1;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private dbGimnasiaYEsgrimaDataSet1TableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancelar;
    }
}