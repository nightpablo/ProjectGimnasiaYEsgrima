using System;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazListaCurso
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
            this.dtvListarCursos = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AgregarProfesor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDeporteCurso = new System.Windows.Forms.Label();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.cbxDeporteCurso = new System.Windows.Forms.ComboBox();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.btnBuscarCurso = new System.Windows.Forms.Button();
            this.btnCrearCurso = new System.Windows.Forms.Button();
            this.dbGimnasiaYEsgrimaDataSet = new ProjectGimnasiaYEsgrima.dbGimnasiaYEsgrimaDataSet();
            this.lblInfoCurso = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTituloCurso = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtvListarCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGimnasiaYEsgrimaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelCursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvListarCursos
            // 
            this.dtvListarCursos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvListarCursos.AutoGenerateColumns = false;
            this.dtvListarCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvListarCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.estadoCursoDataGridViewTextBoxColumn,
            this.Modificar,
            this.Eliminar,
            this.AgregarProfesor});
            this.dtvListarCursos.DataSource = this.modelCursoBindingSource;
            this.dtvListarCursos.Location = new System.Drawing.Point(8, 192);
            this.dtvListarCursos.Margin = new System.Windows.Forms.Padding(4);
            this.dtvListarCursos.Name = "dtvListarCursos";
            this.dtvListarCursos.Size = new System.Drawing.Size(840, 208);
            this.dtvListarCursos.TabIndex = 0;
            this.dtvListarCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridListarCursos_CellContentClick);
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
            // lblDeporteCurso
            // 
            this.lblDeporteCurso.AutoSize = true;
            this.lblDeporteCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporteCurso.Location = new System.Drawing.Point(40, 48);
            this.lblDeporteCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeporteCurso.Name = "lblDeporteCurso";
            this.lblDeporteCurso.Size = new System.Drawing.Size(100, 29);
            this.lblDeporteCurso.TabIndex = 2;
            this.lblDeporteCurso.Text = "Deporte";
            this.lblDeporteCurso.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCurso.Location = new System.Drawing.Point(39, 96);
            this.lblNombreCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(101, 29);
            this.lblNombreCurso.TabIndex = 3;
            this.lblNombreCurso.Text = "Nombre";
            // 
            // cbxDeporteCurso
            // 
            this.cbxDeporteCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDeporteCurso.FormattingEnabled = true;
            this.cbxDeporteCurso.Location = new System.Drawing.Point(152, 46);
            this.cbxDeporteCurso.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDeporteCurso.Name = "cbxDeporteCurso";
            this.cbxDeporteCurso.Size = new System.Drawing.Size(248, 37);
            this.cbxDeporteCurso.TabIndex = 4;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCurso.Location = new System.Drawing.Point(152, 88);
            this.txtNombreCurso.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(248, 34);
            this.txtNombreCurso.TabIndex = 5;
            // 
            // btnBuscarCurso
            // 
            this.btnBuscarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCurso.Location = new System.Drawing.Point(345, 136);
            this.btnBuscarCurso.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCurso.Name = "btnBuscarCurso";
            this.btnBuscarCurso.Size = new System.Drawing.Size(133, 40);
            this.btnBuscarCurso.TabIndex = 6;
            this.btnBuscarCurso.Text = "Buscar";
            this.btnBuscarCurso.UseVisualStyleBackColor = true;
            this.btnBuscarCurso.Click += new System.EventHandler(this.BotonBuscarCurso_Click);
            // 
            // btnCrearCurso
            // 
            this.btnCrearCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCurso.Location = new System.Drawing.Point(488, 136);
            this.btnCrearCurso.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearCurso.Name = "btnCrearCurso";
            this.btnCrearCurso.Size = new System.Drawing.Size(176, 41);
            this.btnCrearCurso.TabIndex = 7;
            this.btnCrearCurso.Text = "Crear Curso";
            this.btnCrearCurso.UseVisualStyleBackColor = true;
            this.btnCrearCurso.Click += new System.EventHandler(this.BotonCrearCurso_Click);
            // 
            // dbGimnasiaYEsgrimaDataSet
            // 
            this.dbGimnasiaYEsgrimaDataSet.DataSetName = "dbGimnasiaYEsgrimaDataSet";
            this.dbGimnasiaYEsgrimaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblInfoCurso
            // 
            this.lblInfoCurso.AutoSize = true;
            this.lblInfoCurso.Font = new System.Drawing.Font("Arial Black", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoCurso.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblInfoCurso.Location = new System.Drawing.Point(16, 408);
            this.lblInfoCurso.Name = "lblInfoCurso";
            this.lblInfoCurso.Size = new System.Drawing.Size(199, 24);
            this.lblInfoCurso.TabIndex = 8;
            this.lblInfoCurso.Text = "Acá se imprime algo";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Deporte";
            this.dataGridViewTextBoxColumn1.HeaderText = "Deporte";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(704, 136);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(97, 43);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // lblTituloCurso
            // 
            this.lblTituloCurso.AutoSize = true;
            this.lblTituloCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCurso.Location = new System.Drawing.Point(96, 0);
            this.lblTituloCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloCurso.Name = "lblTituloCurso";
            this.lblTituloCurso.Size = new System.Drawing.Size(210, 32);
            this.lblTituloCurso.TabIndex = 2;
            this.lblTituloCurso.Text = "Gestión Cursos";
            this.lblTituloCurso.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FechaInicio";
            this.dataGridViewTextBoxColumn3.HeaderText = "FechaInicio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FechaFin";
            this.dataGridViewTextBoxColumn4.HeaderText = "FechaFin";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // estadoCursoDataGridViewTextBoxColumn
            // 
            this.estadoCursoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estadoCursoDataGridViewTextBoxColumn.DataPropertyName = "EstadoCurso";
            this.estadoCursoDataGridViewTextBoxColumn.HeaderText = "EstadoCurso";
            this.estadoCursoDataGridViewTextBoxColumn.Name = "estadoCursoDataGridViewTextBoxColumn";
            // 
            // modelCursoBindingSource
            // 
            this.modelCursoBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.ModelCurso);
            // 
            // InterfazListaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 448);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblInfoCurso);
            this.Controls.Add(this.btnCrearCurso);
            this.Controls.Add(this.btnBuscarCurso);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.cbxDeporteCurso);
            this.Controls.Add(this.lblNombreCurso);
            this.Controls.Add(this.lblTituloCurso);
            this.Controls.Add(this.lblDeporteCurso);
            this.Controls.Add(this.dtvListarCursos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InterfazListaCurso";
            this.Text = "InterfazListaCurso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InterfazListaCurso_FormClosing);
            this.Load += new System.EventHandler(this.InterfazListaCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvListarCursos)).EndInit();
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

        private System.Windows.Forms.DataGridView dtvListarCursos;
        private System.Windows.Forms.Label lblDeporteCurso;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.ComboBox cbxDeporteCurso;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.Button btnBuscarCurso;
        private System.Windows.Forms.Button btnCrearCurso;
        private dbGimnasiaYEsgrimaDataSet dbGimnasiaYEsgrimaDataSet;
        private System.Windows.Forms.BindingSource cursoBindingSource;
        private System.Windows.Forms.Label lblInfoCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.BindingSource modelCursoBindingSource;
        private System.Windows.Forms.Label lblTituloCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn AgregarProfesor;
    }
}