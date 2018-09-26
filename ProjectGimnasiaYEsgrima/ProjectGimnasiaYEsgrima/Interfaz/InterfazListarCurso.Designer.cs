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
            this.labelDeporteListarCurso = new System.Windows.Forms.Label();
            this.labelCursoListarCurso = new System.Windows.Forms.Label();
            this.comboBoxDeporte = new System.Windows.Forms.ComboBox();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.BotonBuscarCurso = new System.Windows.Forms.Button();
            this.botonCrearCurso = new System.Windows.Forms.Button();
            this.dbGimnasiaYEsgrimaDataSet = new ProjectGimnasiaYEsgrima.dbGimnasiaYEsgrimaDataSet();
            this.LabelInfoCurso = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AgregarSocio = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AgregarProfesor = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridListarCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGimnasiaYEsgrimaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridListarCursos
            // 
            this.DataGridListarCursos.AutoGenerateColumns = false;
            this.DataGridListarCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridListarCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.fechaFinDataGridViewTextBoxColumn,
            this.Modificar,
            this.Eliminar,
            this.AgregarSocio,
            this.AgregarProfesor});
            this.DataGridListarCursos.DataSource = this.cursoBindingSource;
            this.DataGridListarCursos.Location = new System.Drawing.Point(83, 130);
            this.DataGridListarCursos.Name = "DataGridListarCursos";
            this.DataGridListarCursos.Size = new System.Drawing.Size(647, 148);
            this.DataGridListarCursos.TabIndex = 0;
            this.DataGridListarCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridListarCursos_CellContentClick);
            // 
            // labelDeporteListarCurso
            // 
            this.labelDeporteListarCurso.AutoSize = true;
            this.labelDeporteListarCurso.Location = new System.Drawing.Point(80, 34);
            this.labelDeporteListarCurso.Name = "labelDeporteListarCurso";
            this.labelDeporteListarCurso.Size = new System.Drawing.Size(45, 13);
            this.labelDeporteListarCurso.TabIndex = 2;
            this.labelDeporteListarCurso.Text = "Deporte";
            this.labelDeporteListarCurso.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelCursoListarCurso
            // 
            this.labelCursoListarCurso.AutoSize = true;
            this.labelCursoListarCurso.Location = new System.Drawing.Point(80, 73);
            this.labelCursoListarCurso.Name = "labelCursoListarCurso";
            this.labelCursoListarCurso.Size = new System.Drawing.Size(34, 13);
            this.labelCursoListarCurso.TabIndex = 3;
            this.labelCursoListarCurso.Text = "Curso";
            // 
            // comboBoxDeporte
            // 
            this.comboBoxDeporte.FormattingEnabled = true;
            this.comboBoxDeporte.Location = new System.Drawing.Point(158, 31);
            this.comboBoxDeporte.Name = "comboBoxDeporte";
            this.comboBoxDeporte.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeporte.TabIndex = 4;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(158, 73);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(121, 20);
            this.txtNombreCurso.TabIndex = 5;
            // 
            // BotonBuscarCurso
            // 
            this.BotonBuscarCurso.Location = new System.Drawing.Point(349, 73);
            this.BotonBuscarCurso.Name = "BotonBuscarCurso";
            this.BotonBuscarCurso.Size = new System.Drawing.Size(100, 23);
            this.BotonBuscarCurso.TabIndex = 6;
            this.BotonBuscarCurso.Text = "Buscar";
            this.BotonBuscarCurso.UseVisualStyleBackColor = true;
            this.BotonBuscarCurso.Click += new System.EventHandler(this.BotonBuscarCurso_Click);
            // 
            // botonCrearCurso
            // 
            this.botonCrearCurso.Location = new System.Drawing.Point(481, 71);
            this.botonCrearCurso.Name = "botonCrearCurso";
            this.botonCrearCurso.Size = new System.Drawing.Size(102, 23);
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
            // cursoTableAdapter
            // 
            // 
            // LabelInfoCurso
            // 
            this.LabelInfoCurso.AutoSize = true;
            this.LabelInfoCurso.Font = new System.Drawing.Font("Arial Black", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfoCurso.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.LabelInfoCurso.Location = new System.Drawing.Point(79, 290);
            this.LabelInfoCurso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelInfoCurso.Name = "LabelInfoCurso";
            this.LabelInfoCurso.Size = new System.Drawing.Size(165, 19);
            this.LabelInfoCurso.TabIndex = 8;
            this.LabelInfoCurso.Text = "Acá se imprime algo";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Deporte";
            this.dataGridViewTextBoxColumn1.HeaderText = "Deporte";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // cursoBindingSource
            // 
            this.cursoBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.Curso);
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
            // AgregarSocio
            // 
            this.AgregarSocio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AgregarSocio.HeaderText = "";
            this.AgregarSocio.Name = "AgregarSocio";
            this.AgregarSocio.ReadOnly = true;
            this.AgregarSocio.Text = "Agregar Socio";
            this.AgregarSocio.UseColumnTextForButtonValue = true;
            this.AgregarSocio.Width = 21;
            // 
            // AgregarProfesor
            // 
            this.AgregarProfesor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AgregarProfesor.HeaderText = "";
            this.AgregarProfesor.Name = "AgregarProfesor";
            this.AgregarProfesor.ReadOnly = true;
            this.AgregarProfesor.Text = "Agregar Profesor";
            this.AgregarProfesor.UseColumnTextForButtonValue = true;
            this.AgregarProfesor.Width = 21;
            // 
            // InterfazListarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelInfoCurso);
            this.Controls.Add(this.botonCrearCurso);
            this.Controls.Add(this.BotonBuscarCurso);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.comboBoxDeporte);
            this.Controls.Add(this.labelCursoListarCurso);
            this.Controls.Add(this.labelDeporteListarCurso);
            this.Controls.Add(this.DataGridListarCursos);
            this.Name = "InterfazListarCurso";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridListarCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGimnasiaYEsgrimaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn AgregarSocio;
        private System.Windows.Forms.DataGridViewButtonColumn AgregarProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}