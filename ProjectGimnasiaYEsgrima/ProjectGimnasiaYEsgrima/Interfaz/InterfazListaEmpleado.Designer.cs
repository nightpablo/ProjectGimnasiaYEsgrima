namespace ProjectGimnasiaYEsgrima.Interfaz
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
            this.LabelInfoEmpleado = new System.Windows.Forms.Label();
            this.botonCrearEmpleado = new System.Windows.Forms.Button();
            this.BotonBuscarEmpleado = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.MaskedTextBox();
            this.labelEmpleadoListarEmpleado = new System.Windows.Forms.Label();
            this.labelDeporteListarEmpleado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.dataGridViewEmpleadoPersona = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.empleadoPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleadoPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoPersonaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelInfoEmpleado
            // 
            this.LabelInfoEmpleado.AutoSize = true;
            this.LabelInfoEmpleado.Font = new System.Drawing.Font("Arial Black", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfoEmpleado.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.LabelInfoEmpleado.Location = new System.Drawing.Point(20, 289);
            this.LabelInfoEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelInfoEmpleado.Name = "LabelInfoEmpleado";
            this.LabelInfoEmpleado.Size = new System.Drawing.Size(165, 19);
            this.LabelInfoEmpleado.TabIndex = 16;
            this.LabelInfoEmpleado.Text = "Acá se imprime algo";
            // 
            // botonCrearEmpleado
            // 
            this.botonCrearEmpleado.Location = new System.Drawing.Point(570, 100);
            this.botonCrearEmpleado.Name = "botonCrearEmpleado";
            this.botonCrearEmpleado.Size = new System.Drawing.Size(102, 23);
            this.botonCrearEmpleado.TabIndex = 15;
            this.botonCrearEmpleado.Text = "Crear Empleado";
            this.botonCrearEmpleado.UseVisualStyleBackColor = true;
            this.botonCrearEmpleado.Click += new System.EventHandler(this.BotonCrearEmpleado_Click);
            // 
            // BotonBuscarEmpleado
            // 
            this.BotonBuscarEmpleado.Location = new System.Drawing.Point(464, 100);
            this.BotonBuscarEmpleado.Name = "BotonBuscarEmpleado";
            this.BotonBuscarEmpleado.Size = new System.Drawing.Size(100, 23);
            this.BotonBuscarEmpleado.TabIndex = 14;
            this.BotonBuscarEmpleado.Text = "Buscar";
            this.BotonBuscarEmpleado.UseVisualStyleBackColor = true;
            this.BotonBuscarEmpleado.Click += new System.EventHandler(this.BotonBuscarEmpleado_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(100, 80);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(121, 20);
            this.txtDNI.TabIndex = 13;
            // 
            // labelEmpleadoListarEmpleado
            // 
            this.labelEmpleadoListarEmpleado.AutoSize = true;
            this.labelEmpleadoListarEmpleado.Location = new System.Drawing.Point(22, 82);
            this.labelEmpleadoListarEmpleado.Name = "labelEmpleadoListarEmpleado";
            this.labelEmpleadoListarEmpleado.Size = new System.Drawing.Size(26, 13);
            this.labelEmpleadoListarEmpleado.TabIndex = 11;
            this.labelEmpleadoListarEmpleado.Text = "DNI";
            // 
            // labelDeporteListarEmpleado
            // 
            this.labelDeporteListarEmpleado.AutoSize = true;
            this.labelDeporteListarEmpleado.Location = new System.Drawing.Point(22, 33);
            this.labelDeporteListarEmpleado.Name = "labelDeporteListarEmpleado";
            this.labelDeporteListarEmpleado.Size = new System.Drawing.Size(44, 13);
            this.labelDeporteListarEmpleado.TabIndex = 10;
            this.labelDeporteListarEmpleado.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(100, 55);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(121, 20);
            this.txtApellido.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tipo de empleado";
            // 
            // ComboBoxTipoEmpleado
            // 
            this.ComboBoxTipoEmpleado.FormattingEnabled = true;
            this.ComboBoxTipoEmpleado.Location = new System.Drawing.Point(350, 31);
            this.ComboBoxTipoEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBoxTipoEmpleado.Name = "ComboBoxTipoEmpleado";
            this.ComboBoxTipoEmpleado.Size = new System.Drawing.Size(140, 21);
            this.ComboBoxTipoEmpleado.TabIndex = 17;
            this.ComboBoxTipoEmpleado.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTipoEmpleado_SelectedIndexChanged);
            // 
            // dataGridViewEmpleadoPersona
            // 
            this.dataGridViewEmpleadoPersona.AutoGenerateColumns = false;
            this.dataGridViewEmpleadoPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleadoPersona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.dNIDataGridViewTextBoxColumn,
            this.tipoEmpleadoDataGridViewTextBoxColumn,
            this.Modificar,
            this.Eliminar});
            this.dataGridViewEmpleadoPersona.DataSource = this.empleadoPersonaBindingSource;
            this.dataGridViewEmpleadoPersona.Location = new System.Drawing.Point(23, 129);
            this.dataGridViewEmpleadoPersona.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewEmpleadoPersona.Name = "dataGridViewEmpleadoPersona";
            this.dataGridViewEmpleadoPersona.RowTemplate.Height = 24;
            this.dataGridViewEmpleadoPersona.Size = new System.Drawing.Size(649, 158);
            this.dataGridViewEmpleadoPersona.TabIndex = 18;
            this.dataGridViewEmpleadoPersona.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpleadoPersona_CellContentClick);
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
            // tipoEmpleadoDataGridViewTextBoxColumn
            // 
            this.tipoEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "TipoEmpleado";
            this.tipoEmpleadoDataGridViewTextBoxColumn.HeaderText = "TipoEmpleado";
            this.tipoEmpleadoDataGridViewTextBoxColumn.Name = "tipoEmpleadoDataGridViewTextBoxColumn";
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
            // empleadoPersonaBindingSource
            // 
            this.empleadoPersonaBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.ModelEmpleadoPersona);
            // 
            // InterfazListaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 336);
            this.Controls.Add(this.dataGridViewEmpleadoPersona);
            this.Controls.Add(this.ComboBoxTipoEmpleado);
            this.Controls.Add(this.LabelInfoEmpleado);
            this.Controls.Add(this.botonCrearEmpleado);
            this.Controls.Add(this.BotonBuscarEmpleado);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEmpleadoListarEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDeporteListarEmpleado);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InterfazListaEmpleado";
            this.Text = "InterfazListaEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleadoPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoPersonaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelInfoEmpleado;
        private System.Windows.Forms.Button botonCrearEmpleado;
        private System.Windows.Forms.Button BotonBuscarEmpleado;
        private System.Windows.Forms.MaskedTextBox txtDNI;
        private System.Windows.Forms.Label labelEmpleadoListarEmpleado;
        private System.Windows.Forms.Label labelDeporteListarEmpleado;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxTipoEmpleado;
        private System.Windows.Forms.DataGridView dataGridViewEmpleadoPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.BindingSource empleadoPersonaBindingSource;
    }
}