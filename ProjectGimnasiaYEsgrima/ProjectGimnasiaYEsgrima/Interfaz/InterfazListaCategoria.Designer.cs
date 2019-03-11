using System;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazListaCategoria
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
            this.dtvListarCategorias = new System.Windows.Forms.DataGridView();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AgregarProfesor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDeporteCategoria = new System.Windows.Forms.Label();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.cbxDeporteCategoria = new System.Windows.Forms.ComboBox();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.btnBuscarCategoria = new System.Windows.Forms.Button();
            this.btnCrearCategoria = new System.Windows.Forms.Button();
            this.dbGimnasiaYEsgrimaDataSet = new ProjectGimnasiaYEsgrima.dbGimnasiaYEsgrimaDataSet();
            this.lblInfoCategoria = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTituloCategoria = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtvListarCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGimnasiaYEsgrimaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelCategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvListarCategorias
            // 
            this.dtvListarCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvListarCategorias.AutoGenerateColumns = false;
            this.dtvListarCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvListarCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.estadoCategoriaDataGridViewTextBoxColumn,
            this.Modificar,
            this.Eliminar,
            this.AgregarProfesor});
            this.dtvListarCategorias.DataSource = this.modelCategoriaBindingSource;
            this.dtvListarCategorias.Location = new System.Drawing.Point(8, 192);
            this.dtvListarCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.dtvListarCategorias.Name = "dtvListarCategorias";
            this.dtvListarCategorias.Size = new System.Drawing.Size(840, 208);
            this.dtvListarCategorias.TabIndex = 6;
            this.dtvListarCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridListarCategorias_CellContentClick);
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
            // lblDeporteCategoria
            // 
            this.lblDeporteCategoria.AutoSize = true;
            this.lblDeporteCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeporteCategoria.Location = new System.Drawing.Point(40, 48);
            this.lblDeporteCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeporteCategoria.Name = "lblDeporteCategoria";
            this.lblDeporteCategoria.Size = new System.Drawing.Size(100, 29);
            this.lblDeporteCategoria.TabIndex = 2;
            this.lblDeporteCategoria.Text = "Deporte";
            this.lblDeporteCategoria.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCategoria.Location = new System.Drawing.Point(39, 96);
            this.lblNombreCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(101, 29);
            this.lblNombreCategoria.TabIndex = 3;
            this.lblNombreCategoria.Text = "Nombre";
            // 
            // cbxDeporteCategoria
            // 
            this.cbxDeporteCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDeporteCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDeporteCategoria.FormattingEnabled = true;
            this.cbxDeporteCategoria.Location = new System.Drawing.Point(152, 46);
            this.cbxDeporteCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDeporteCategoria.Name = "cbxDeporteCategoria";
            this.cbxDeporteCategoria.Size = new System.Drawing.Size(248, 37);
            this.cbxDeporteCategoria.TabIndex = 1;
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCategoria.Location = new System.Drawing.Point(152, 88);
            this.txtNombreCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(248, 34);
            this.txtNombreCategoria.TabIndex = 2;
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCategoria.Location = new System.Drawing.Point(272, 136);
            this.btnBuscarCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(133, 40);
            this.btnBuscarCategoria.TabIndex = 3;
            this.btnBuscarCategoria.Text = "Buscar";
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            this.btnBuscarCategoria.Click += new System.EventHandler(this.BotonBuscarCategoria_Click);
            // 
            // btnCrearCategoria
            // 
            this.btnCrearCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCategoria.Location = new System.Drawing.Point(432, 136);
            this.btnCrearCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearCategoria.Name = "btnCrearCategoria";
            this.btnCrearCategoria.Size = new System.Drawing.Size(240, 41);
            this.btnCrearCategoria.TabIndex = 4;
            this.btnCrearCategoria.Text = "Crear Categoria";
            this.btnCrearCategoria.UseVisualStyleBackColor = true;
            this.btnCrearCategoria.Click += new System.EventHandler(this.BotonCrearCategoria_Click);
            // 
            // dbGimnasiaYEsgrimaDataSet
            // 
            this.dbGimnasiaYEsgrimaDataSet.DataSetName = "dbGimnasiaYEsgrimaDataSet";
            this.dbGimnasiaYEsgrimaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblInfoCategoria
            // 
            this.lblInfoCategoria.AutoSize = true;
            this.lblInfoCategoria.Font = new System.Drawing.Font("Arial Black", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoCategoria.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblInfoCategoria.Location = new System.Drawing.Point(16, 408);
            this.lblInfoCategoria.Name = "lblInfoCategoria";
            this.lblInfoCategoria.Size = new System.Drawing.Size(199, 24);
            this.lblInfoCategoria.TabIndex = 8;
            this.lblInfoCategoria.Text = "Acá se imprime algo";
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
            this.btnVolver.Location = new System.Drawing.Point(712, 136);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(97, 43);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // lblTituloCategoria
            // 
            this.lblTituloCategoria.AutoSize = true;
            this.lblTituloCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCategoria.Location = new System.Drawing.Point(96, 0);
            this.lblTituloCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloCategoria.Name = "lblTituloCategoria";
            this.lblTituloCategoria.Size = new System.Drawing.Size(259, 32);
            this.lblTituloCategoria.TabIndex = 2;
            this.lblTituloCategoria.Text = "Gestión Categorias";
            this.lblTituloCategoria.Click += new System.EventHandler(this.label2_Click);
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
            // estadoCategoriaDataGridViewTextBoxColumn
            // 
            this.estadoCategoriaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estadoCategoriaDataGridViewTextBoxColumn.DataPropertyName = "EstadoCategoria";
            this.estadoCategoriaDataGridViewTextBoxColumn.HeaderText = "EstadoCategoria";
            this.estadoCategoriaDataGridViewTextBoxColumn.Name = "estadoCategoriaDataGridViewTextBoxColumn";
            // 
            // modelCategoriaBindingSource
            // 
            this.modelCategoriaBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.ModelCategoria);
            // 
            // InterfazListaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 448);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblInfoCategoria);
            this.Controls.Add(this.btnCrearCategoria);
            this.Controls.Add(this.btnBuscarCategoria);
            this.Controls.Add(this.txtNombreCategoria);
            this.Controls.Add(this.cbxDeporteCategoria);
            this.Controls.Add(this.lblNombreCategoria);
            this.Controls.Add(this.lblTituloCategoria);
            this.Controls.Add(this.lblDeporteCategoria);
            this.Controls.Add(this.dtvListarCategorias);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InterfazListaCategoria";
            this.Text = "InterfazListaCategoria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InterfazListaCategoria_FormClosing);
            this.Load += new System.EventHandler(this.InterfazListaCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvListarCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGimnasiaYEsgrimaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelCategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dtvListarCategorias;
        private System.Windows.Forms.Label lblDeporteCategoria;
        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.ComboBox cbxDeporteCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Button btnBuscarCategoria;
        private System.Windows.Forms.Button btnCrearCategoria;
        private dbGimnasiaYEsgrimaDataSet dbGimnasiaYEsgrimaDataSet;
        private System.Windows.Forms.BindingSource CategoriaBindingSource;
        private System.Windows.Forms.Label lblInfoCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.BindingSource modelCategoriaBindingSource;
        private System.Windows.Forms.Label lblTituloCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn AgregarProfesor;
    }
}