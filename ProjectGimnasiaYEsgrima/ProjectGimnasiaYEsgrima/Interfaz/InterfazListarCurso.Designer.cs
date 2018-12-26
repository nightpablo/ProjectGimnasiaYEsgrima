using System;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazListarCurso
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
            this.DataGridListarCursos = new System.Windows.Forms.DataGridView();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelDeporteListarCurso = new System.Windows.Forms.Label();
            this.labelCursoListarCurso = new System.Windows.Forms.Label();
            this.comboBoxDeporte = new System.Windows.Forms.ComboBox();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.BotonBuscarCurso = new System.Windows.Forms.Button();
            this.botonCrearCurso = new System.Windows.Forms.Button();
            this.dbGimnasiaYEsgrimaDataSet = new ProjectGimnasiaYEsgrima.dbGimnasiaYEsgrimaDataSet();
            this.LabelInfoCurso = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.modelCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AgregarProfesor = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridListarCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGimnasiaYEsgrimaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelCursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridListarCursos
            // 
            this.DataGridListarCursos.AutoGenerateColumns = false;
            this.DataGridListarCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridListarCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.estadoCursoDataGridViewTextBoxColumn,
            this.Modificar,
            this.Eliminar,
            this.AgregarProfesor});
            this.DataGridListarCursos.DataSource = this.modelCursoBindingSource;
            this.DataGridListarCursos.Location = new System.Drawing.Point(111, 160);
            this.DataGridListarCursos.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridListarCursos.Name = "DataGridListarCursos";
            this.DataGridListarCursos.Size = new System.Drawing.Size(863, 182);
            this.DataGridListarCursos.TabIndex = 0;
            this.DataGridListarCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridListarCursos_CellContentClick);
            // 
            // labelDeporteListarCurso
            // 
            this.labelDeporteListarCurso.AutoSize = true;
            this.labelDeporteListarCurso.Location = new System.Drawing.Point(107, 42);
            this.labelDeporteListarCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeporteListarCurso.Name = "labelDeporteListarCurso";
            this.labelDeporteListarCurso.Size = new System.Drawing.Size(59, 17);
            this.labelDeporteListarCurso.TabIndex = 2;
            this.labelDeporteListarCurso.Text = "Deporte";
            this.labelDeporteListarCurso.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelCursoListarCurso
            // 
            this.labelCursoListarCurso.AutoSize = true;
            this.labelCursoListarCurso.Location = new System.Drawing.Point(107, 90);
            this.labelCursoListarCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCursoListarCurso.Name = "labelCursoListarCurso";
            this.labelCursoListarCurso.Size = new System.Drawing.Size(45, 17);
            this.labelCursoListarCurso.TabIndex = 3;
            this.labelCursoListarCurso.Text = "Curso";
            // 
            // comboBoxDeporte
            // 
            this.comboBoxDeporte.FormattingEnabled = true;
            this.comboBoxDeporte.Location = new System.Drawing.Point(211, 38);
            this.comboBoxDeporte.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDeporte.Name = "comboBoxDeporte";
            this.comboBoxDeporte.Size = new System.Drawing.Size(160, 24);
            this.comboBoxDeporte.TabIndex = 4;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(211, 90);
            this.txtNombreCurso.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(160, 22);
            this.txtNombreCurso.TabIndex = 5;
            // 
            // BotonBuscarCurso
            // 
            this.BotonBuscarCurso.Location = new System.Drawing.Point(465, 90);
            this.BotonBuscarCurso.Margin = new System.Windows.Forms.Padding(4);
            this.BotonBuscarCurso.Name = "BotonBuscarCurso";
            this.BotonBuscarCurso.Size = new System.Drawing.Size(133, 28);
            this.BotonBuscarCurso.TabIndex = 6;
            this.BotonBuscarCurso.Text = "Buscar";
            this.BotonBuscarCurso.UseVisualStyleBackColor = true;
            this.BotonBuscarCurso.Click += new System.EventHandler(this.BotonBuscarCurso_Click);
            // 
            // botonCrearCurso
            // 
            this.botonCrearCurso.Location = new System.Drawing.Point(641, 87);
            this.botonCrearCurso.Margin = new System.Windows.Forms.Padding(4);
            this.botonCrearCurso.Name = "botonCrearCurso";
            this.botonCrearCurso.Size = new System.Drawing.Size(136, 28);
            this.botonCrearCurso.TabIndex = 7;
            this.botonCrearCurso.Text = "Crear Curso";
            this.botonCrearCurso.UseVisualStyleBackColor = true;
            this.botonCrearCurso.Click += new System.EventHandler(this.BotonCrearCurso_Click);
            // 
            // dbGimnasiaYEsgrimaDataSet
            // 
            this.dbGimnasiaYEsgrimaDataSet.DataSetName = "dbGimnasiaYEsgrimaDataSet";
            this.dbGimnasiaYEsgrimaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LabelInfoCurso
            // 
            this.LabelInfoCurso.AutoSize = true;
            this.LabelInfoCurso.Font = new System.Drawing.Font("Arial Black", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfoCurso.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.LabelInfoCurso.Location = new System.Drawing.Point(105, 357);
            this.LabelInfoCurso.Name = "LabelInfoCurso";
            this.LabelInfoCurso.Size = new System.Drawing.Size(199, 24);
            this.LabelInfoCurso.TabIndex = 8;
            this.LabelInfoCurso.Text = "Acá se imprime algo";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Deporte";
            this.dataGridViewTextBoxColumn1.HeaderText = "Deporte";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(799, 85);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(97, 32);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // modelCursoBindingSource
            // 
            this.modelCursoBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.ModelCurso);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FechaInicio";
            this.dataGridViewTextBoxColumn3.HeaderText = "FechaInicio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FechaFin";
            this.dataGridViewTextBoxColumn4.HeaderText = "FechaFin";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // estadoCursoDataGridViewTextBoxColumn
            // 
            this.estadoCursoDataGridViewTextBoxColumn.DataPropertyName = "EstadoCurso";
            this.estadoCursoDataGridViewTextBoxColumn.HeaderText = "EstadoCurso";
            this.estadoCursoDataGridViewTextBoxColumn.Name = "estadoCursoDataGridViewTextBoxColumn";
            // 
            // Modificar
            // 
            this.Modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Modificar.HeaderText = "";
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseColumnTextForButtonValue = true;
            this.Modificar.Width = 24;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 24;
            // 
            // AgregarProfesor
            // 
            this.AgregarProfesor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AgregarProfesor.HeaderText = "";
            this.AgregarProfesor.Name = "AgregarProfesor";
            this.AgregarProfesor.ReadOnly = true;
            this.AgregarProfesor.Text = "Agregar Profesor";
            this.AgregarProfesor.UseColumnTextForButtonValue = true;
            this.AgregarProfesor.Width = 24;
            // 
            // InterfazListarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.LabelInfoCurso);
            this.Controls.Add(this.botonCrearCurso);
            this.Controls.Add(this.BotonBuscarCurso);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.comboBoxDeporte);
            this.Controls.Add(this.labelCursoListarCurso);
            this.Controls.Add(this.labelDeporteListarCurso);
            this.Controls.Add(this.DataGridListarCursos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InterfazListarCurso";
            this.Text = "InterfazListaCurso";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridListarCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGimnasiaYEsgrimaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelCursoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridListarCursos;
        private System.Windows.Forms.Label labelDeporteListarCurso;
        private System.Windows.Forms.Label labelCursoListarCurso;
        private System.Windows.Forms.ComboBox comboBoxDeporte;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Button BotonBuscarCurso;
        private System.Windows.Forms.Button botonCrearCurso;
        private dbGimnasiaYEsgrimaDataSet dbGimnasiaYEsgrimaDataSet;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private System.Windows.Forms.Label LabelInfoCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn AgregarProfesor;
        private System.Windows.Forms.BindingSource modelCursoBindingSource;
    }
}