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
            this.lblTituloProfesor = new System.Windows.Forms.Label();
            this.txtApellidoProfesor = new System.Windows.Forms.TextBox();
            this.txtDNIProfesor = new System.Windows.Forms.TextBox();
            this.lblApellidoProfesor = new System.Windows.Forms.Label();
            this.lblDNIProfesor = new System.Windows.Forms.Label();
            this.dgvEmpleadoProfesor = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblInfoProfesor = new System.Windows.Forms.Label();
            this.modelEmpleadoPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsignarCurso = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EliminarCurso = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadoProfesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelEmpleadoPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelCursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloProfesor
            // 
            this.lblTituloProfesor.AutoSize = true;
            this.lblTituloProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProfesor.Location = new System.Drawing.Point(8, 8);
            this.lblTituloProfesor.Name = "lblTituloProfesor";
            this.lblTituloProfesor.Size = new System.Drawing.Size(256, 32);
            this.lblTituloProfesor.TabIndex = 1;
            this.lblTituloProfesor.Text = "Lista de profesores";
            // 
            // txtApellidoProfesor
            // 
            this.txtApellidoProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoProfesor.Location = new System.Drawing.Point(146, 93);
            this.txtApellidoProfesor.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoProfesor.Name = "txtApellidoProfesor";
            this.txtApellidoProfesor.Size = new System.Drawing.Size(160, 34);
            this.txtApellidoProfesor.TabIndex = 16;
            // 
            // txtDNIProfesor
            // 
            this.txtDNIProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNIProfesor.Location = new System.Drawing.Point(146, 57);
            this.txtDNIProfesor.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNIProfesor.Name = "txtDNIProfesor";
            this.txtDNIProfesor.Size = new System.Drawing.Size(160, 34);
            this.txtDNIProfesor.TabIndex = 17;
            // 
            // lblApellidoProfesor
            // 
            this.lblApellidoProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoProfesor.Location = new System.Drawing.Point(0, 96);
            this.lblApellidoProfesor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoProfesor.Name = "lblApellidoProfesor";
            this.lblApellidoProfesor.Size = new System.Drawing.Size(120, 30);
            this.lblApellidoProfesor.TabIndex = 14;
            this.lblApellidoProfesor.Text = "Apellido";
            this.lblApellidoProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDNIProfesor
            // 
            this.lblDNIProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNIProfesor.Location = new System.Drawing.Point(32, 60);
            this.lblDNIProfesor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDNIProfesor.Name = "lblDNIProfesor";
            this.lblDNIProfesor.Size = new System.Drawing.Size(88, 28);
            this.lblDNIProfesor.TabIndex = 15;
            this.lblDNIProfesor.Text = "DNI";
            this.lblDNIProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvEmpleadoProfesor
            // 
            this.dgvEmpleadoProfesor.AutoGenerateColumns = false;
            this.dgvEmpleadoProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleadoProfesor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.dNIDataGridViewTextBoxColumn,
            this.AsignarCurso,
            this.EliminarCurso});
            this.dgvEmpleadoProfesor.DataSource = this.modelEmpleadoPersonaBindingSource;
            this.dgvEmpleadoProfesor.Location = new System.Drawing.Point(8, 208);
            this.dgvEmpleadoProfesor.Name = "dgvEmpleadoProfesor";
            this.dgvEmpleadoProfesor.RowTemplate.Height = 24;
            this.dgvEmpleadoProfesor.Size = new System.Drawing.Size(816, 150);
            this.dgvEmpleadoProfesor.TabIndex = 18;
            this.dgvEmpleadoProfesor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvEmpleadoProfesor.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEmpleadoProfesor_CellFormatting);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(400, 144);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(173, 48);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(616, 144);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(173, 48);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BotonVolver_Click);
            // 
            // lblInfoProfesor
            // 
            this.lblInfoProfesor.AutoSize = true;
            this.lblInfoProfesor.Font = new System.Drawing.Font("Arial Black", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoProfesor.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblInfoProfesor.Location = new System.Drawing.Point(8, 376);
            this.lblInfoProfesor.Name = "lblInfoProfesor";
            this.lblInfoProfesor.Size = new System.Drawing.Size(199, 24);
            this.lblInfoProfesor.TabIndex = 20;
            this.lblInfoProfesor.Text = "Acá se imprime algo";
            // 
            // modelEmpleadoPersonaBindingSource
            // 
            this.modelEmpleadoPersonaBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.ModelEmpleadoPersona);
            // 
            // modelCursoBindingSource
            // 
            this.modelCursoBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.ModelCurso);
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
            // AsignarCurso
            // 
            this.AsignarCurso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AsignarCurso.HeaderText = "";
            this.AsignarCurso.Name = "AsignarCurso";
            this.AsignarCurso.Text = "Asignar Curso";
            this.AsignarCurso.UseColumnTextForButtonValue = true;
            this.AsignarCurso.Width = 24;
            // 
            // EliminarCurso
            // 
            this.EliminarCurso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EliminarCurso.HeaderText = "";
            this.EliminarCurso.Name = "EliminarCurso";
            this.EliminarCurso.Text = "Eliminar Curso";
            this.EliminarCurso.UseColumnTextForButtonValue = true;
            this.EliminarCurso.Width = 24;
            // 
            // InterfazAgregarCursoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 412);
            this.Controls.Add(this.lblInfoProfesor);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvEmpleadoProfesor);
            this.Controls.Add(this.txtApellidoProfesor);
            this.Controls.Add(this.txtDNIProfesor);
            this.Controls.Add(this.lblApellidoProfesor);
            this.Controls.Add(this.lblDNIProfesor);
            this.Controls.Add(this.lblTituloProfesor);
            this.Name = "InterfazAgregarCursoEmpleado";
            this.Text = "InterfazAgregarCursoEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleadoProfesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelEmpleadoPersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelCursoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource modelCursoBindingSource;
        private System.Windows.Forms.Label lblTituloProfesor;
        private System.Windows.Forms.TextBox txtApellidoProfesor;
        private System.Windows.Forms.TextBox txtDNIProfesor;
        private System.Windows.Forms.Label lblApellidoProfesor;
        private System.Windows.Forms.Label lblDNIProfesor;
        private System.Windows.Forms.DataGridView dgvEmpleadoProfesor;
        private System.Windows.Forms.BindingSource modelEmpleadoPersonaBindingSource;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblInfoProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn AsignarCurso;
        private System.Windows.Forms.DataGridViewButtonColumn EliminarCurso;
    }
}