namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazAgregarCursoEmpleado
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
            this.modelCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.txtDNIEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEmpleadoListarEmpleado = new System.Windows.Forms.Label();
            this.dataGridViewEmpleadoProfesor = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsignarCurso = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EliminarCurso = new System.Windows.Forms.DataGridViewButtonColumn();
            this.modelEmpleadoPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modelCursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleadoProfesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelEmpleadoPersonaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // modelCursoBindingSource
            // 
            this.modelCursoBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.ModelCurso);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de profesores";
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(146, 87);
            this.txtApellidoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(160, 22);
            this.txtApellidoEmpleado.TabIndex = 16;
            // 
            // txtDNIEmpleado
            // 
            this.txtDNIEmpleado.Location = new System.Drawing.Point(146, 57);
            this.txtDNIEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNIEmpleado.Name = "txtDNIEmpleado";
            this.txtDNIEmpleado.Size = new System.Drawing.Size(160, 22);
            this.txtDNIEmpleado.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Apellido";
            // 
            // labelEmpleadoListarEmpleado
            // 
            this.labelEmpleadoListarEmpleado.AutoSize = true;
            this.labelEmpleadoListarEmpleado.Location = new System.Drawing.Point(42, 60);
            this.labelEmpleadoListarEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmpleadoListarEmpleado.Name = "labelEmpleadoListarEmpleado";
            this.labelEmpleadoListarEmpleado.Size = new System.Drawing.Size(31, 17);
            this.labelEmpleadoListarEmpleado.TabIndex = 15;
            this.labelEmpleadoListarEmpleado.Text = "DNI";
            // 
            // dataGridViewEmpleadoProfesor
            // 
            this.dataGridViewEmpleadoProfesor.AutoGenerateColumns = false;
            this.dataGridViewEmpleadoProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleadoProfesor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.dNIDataGridViewTextBoxColumn,
            this.AsignarCurso,
            this.EliminarCurso});
            this.dataGridViewEmpleadoProfesor.DataSource = this.modelEmpleadoPersonaBindingSource;
            this.dataGridViewEmpleadoProfesor.Location = new System.Drawing.Point(15, 133);
            this.dataGridViewEmpleadoProfesor.Name = "dataGridViewEmpleadoProfesor";
            this.dataGridViewEmpleadoProfesor.RowTemplate.Height = 24;
            this.dataGridViewEmpleadoProfesor.Size = new System.Drawing.Size(848, 150);
            this.dataGridViewEmpleadoProfesor.TabIndex = 18;
            this.dataGridViewEmpleadoProfesor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // AsignarCurso
            // 
            this.AsignarCurso.HeaderText = "";
            this.AsignarCurso.Name = "AsignarCurso";
            this.AsignarCurso.Text = "Asignar Curso";
            this.AsignarCurso.UseColumnTextForButtonValue = true;
            // 
            // EliminarCurso
            // 
            this.EliminarCurso.HeaderText = "";
            this.EliminarCurso.Name = "EliminarCurso";
            this.EliminarCurso.Text = "Eliminar Curso";
            this.EliminarCurso.UseColumnTextForButtonValue = true;
            // 
            // modelEmpleadoPersonaBindingSource
            // 
            this.modelEmpleadoPersonaBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.ModelEmpleadoPersona);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(314, 77);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(173, 33);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(493, 77);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(173, 33);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BotonVolver_Click);
            // 
            // InterfazAgregarCursoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 296);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridViewEmpleadoProfesor);
            this.Controls.Add(this.txtApellidoEmpleado);
            this.Controls.Add(this.txtDNIEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelEmpleadoListarEmpleado);
            this.Controls.Add(this.label1);
            this.Name = "InterfazAgregarCursoEmpleado";
            this.Text = "InterfazAgregarCursoEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.modelCursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleadoProfesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelEmpleadoPersonaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource modelCursoBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.TextBox txtDNIEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEmpleadoListarEmpleado;
        private System.Windows.Forms.DataGridView dataGridViewEmpleadoProfesor;
        private System.Windows.Forms.BindingSource modelEmpleadoPersonaBindingSource;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn AsignarCurso;
        private System.Windows.Forms.DataGridViewButtonColumn EliminarCurso;
        private System.Windows.Forms.Button btnVolver;
    }
}