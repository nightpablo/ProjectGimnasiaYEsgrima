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
            this.dataGridViewListaCursosEmpleado = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.modelCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BotonAgregarCurso = new System.Windows.Forms.Button();
            this.BotonVolver = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaCursosEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelCursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListaCursosEmpleado
            // 
            this.dataGridViewListaCursosEmpleado.AutoGenerateColumns = false;
            this.dataGridViewListaCursosEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaCursosEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.fechaFinDataGridViewTextBoxColumn,
            this.estadoCursoDataGridViewTextBoxColumn,
            this.Eliminar});
            this.dataGridViewListaCursosEmpleado.DataSource = this.modelCursoBindingSource;
            this.dataGridViewListaCursosEmpleado.Location = new System.Drawing.Point(12, 56);
            this.dataGridViewListaCursosEmpleado.Name = "dataGridViewListaCursosEmpleado";
            this.dataGridViewListaCursosEmpleado.RowTemplate.Height = 24;
            this.dataGridViewListaCursosEmpleado.Size = new System.Drawing.Size(546, 150);
            this.dataGridViewListaCursosEmpleado.TabIndex = 0;
            this.dataGridViewListaCursosEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewListaCursosEmpleado_CellContentClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            // 
            // fechaFinDataGridViewTextBoxColumn
            // 
            this.fechaFinDataGridViewTextBoxColumn.DataPropertyName = "FechaFin";
            this.fechaFinDataGridViewTextBoxColumn.HeaderText = "FechaFin";
            this.fechaFinDataGridViewTextBoxColumn.Name = "fechaFinDataGridViewTextBoxColumn";
            // 
            // estadoCursoDataGridViewTextBoxColumn
            // 
            this.estadoCursoDataGridViewTextBoxColumn.DataPropertyName = "EstadoCurso";
            this.estadoCursoDataGridViewTextBoxColumn.HeaderText = "EstadoCurso";
            this.estadoCursoDataGridViewTextBoxColumn.Name = "estadoCursoDataGridViewTextBoxColumn";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
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
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de cursos";
            // 
            // BotonAgregarCurso
            // 
            this.BotonAgregarCurso.Location = new System.Drawing.Point(564, 87);
            this.BotonAgregarCurso.Name = "BotonAgregarCurso";
            this.BotonAgregarCurso.Size = new System.Drawing.Size(234, 27);
            this.BotonAgregarCurso.TabIndex = 2;
            this.BotonAgregarCurso.Text = "Agregar Curso";
            this.BotonAgregarCurso.UseVisualStyleBackColor = true;
            this.BotonAgregarCurso.Click += new System.EventHandler(this.BotonAgregarCurso_Click);
            // 
            // BotonVolver
            // 
            this.BotonVolver.Location = new System.Drawing.Point(564, 179);
            this.BotonVolver.Name = "BotonVolver";
            this.BotonVolver.Size = new System.Drawing.Size(234, 27);
            this.BotonVolver.TabIndex = 2;
            this.BotonVolver.Text = "Volver";
            this.BotonVolver.UseVisualStyleBackColor = true;
            this.BotonVolver.Click += new System.EventHandler(this.BotonVolver_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.modelCursoBindingSource;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(565, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(233, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "Nombre";
            // 
            // InterfazAgregarCursoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 251);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BotonVolver);
            this.Controls.Add(this.BotonAgregarCurso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewListaCursosEmpleado);
            this.Name = "InterfazAgregarCursoEmpleado";
            this.Text = "InterfazAgregarCursoEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaCursosEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelCursoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListaCursosEmpleado;
        private System.Windows.Forms.BindingSource modelCursoBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonAgregarCurso;
        private System.Windows.Forms.Button BotonVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}