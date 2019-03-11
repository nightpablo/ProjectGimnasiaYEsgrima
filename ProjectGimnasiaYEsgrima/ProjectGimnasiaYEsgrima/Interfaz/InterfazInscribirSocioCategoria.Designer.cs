namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazInscribirSocioCategoria
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
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inscribir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Unsuscribir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.modelCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDeporteCategoria = new System.Windows.Forms.Label();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.cbxDeporteCategoria = new System.Windows.Forms.ComboBox();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.btnBuscarCategoria = new System.Windows.Forms.Button();
            this.dbGimnasiaYEsgrimaDataSet = new ProjectGimnasiaYEsgrima.dbGimnasiaYEsgrimaDataSet();
            this.lblInfoCategoria = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTituloCategoria = new System.Windows.Forms.Label();
            this.CategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtvListarCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGimnasiaYEsgrimaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvListarCategorias
            // 
            this.dtvListarCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvListarCategorias.AutoGenerateColumns = false;
            this.dtvListarCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvListarCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.Monto,
            this.dataGridViewTextBoxColumn4,
            this.estadoCategoriaDataGridViewTextBoxColumn,
            this.Inscribir,
            this.Unsuscribir});
            this.dtvListarCategorias.DataSource = this.modelCategoriaBindingSource;
            this.dtvListarCategorias.Location = new System.Drawing.Point(8, 192);
            this.dtvListarCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.dtvListarCategorias.Name = "dtvListarCategorias";
            this.dtvListarCategorias.Size = new System.Drawing.Size(840, 208);
            this.dtvListarCategorias.TabIndex = 5;
            this.dtvListarCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvListarCategorias_CellContentClick);
            this.dtvListarCategorias.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtvListarCategorias_CellFormatting);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FechaInicio";
            this.dataGridViewTextBoxColumn3.HeaderText = "FechaInicio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Monto
            // 
            this.Monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Monto.DataPropertyName = "Monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
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
            // Inscribir
            // 
            this.Inscribir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Inscribir.HeaderText = "";
            this.Inscribir.Name = "Inscribir";
            this.Inscribir.ReadOnly = true;
            this.Inscribir.Text = "Inscribir";
            this.Inscribir.UseColumnTextForButtonValue = true;
            this.Inscribir.Width = 24;
            // 
            // Unsuscribir
            // 
            this.Unsuscribir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Unsuscribir.HeaderText = "";
            this.Unsuscribir.Name = "Unsuscribir";
            this.Unsuscribir.ReadOnly = true;
            this.Unsuscribir.Text = "Unsuscribir";
            this.Unsuscribir.UseColumnTextForButtonValue = true;
            this.Unsuscribir.Width = 24;
            // 
            // modelCategoriaBindingSource
            // 
            this.modelCategoriaBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.ModelCategoria);
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
            this.btnBuscarCategoria.Location = new System.Drawing.Point(345, 136);
            this.btnBuscarCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(133, 40);
            this.btnBuscarCategoria.TabIndex = 3;
            this.btnBuscarCategoria.Text = "Buscar";
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            this.btnBuscarCategoria.Click += new System.EventHandler(this.BotonBuscarCategoria_Click);
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
            this.btnVolver.Location = new System.Drawing.Point(704, 136);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(97, 43);
            this.btnVolver.TabIndex = 4;
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
            this.lblTituloCategoria.Size = new System.Drawing.Size(282, 32);
            this.lblTituloCategoria.TabIndex = 2;
            this.lblTituloCategoria.Text = "Inscripción Categoria";
            // 
            // profesoresBindingSource
            // 
            this.profesoresBindingSource.DataMember = "Profesores";
            this.profesoresBindingSource.DataSource = this.modelCategoriaBindingSource;
            // 
            // InterfazInscribirSocioCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 448);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblInfoCategoria);
            this.Controls.Add(this.btnBuscarCategoria);
            this.Controls.Add(this.txtNombreCategoria);
            this.Controls.Add(this.cbxDeporteCategoria);
            this.Controls.Add(this.lblNombreCategoria);
            this.Controls.Add(this.lblTituloCategoria);
            this.Controls.Add(this.lblDeporteCategoria);
            this.Controls.Add(this.dtvListarCategorias);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InterfazInscribirSocioCategoria";
            this.Text = "InterfazListaCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dtvListarCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbGimnasiaYEsgrimaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private System.Windows.Forms.DataGridView dtvListarCategorias;
        private System.Windows.Forms.Label lblDeporteCategoria;
        private System.Windows.Forms.Label lblNombreCategoria;
        private System.Windows.Forms.ComboBox cbxDeporteCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Button btnBuscarCategoria;
        private dbGimnasiaYEsgrimaDataSet dbGimnasiaYEsgrimaDataSet;
        private System.Windows.Forms.BindingSource CategoriaBindingSource;
        private System.Windows.Forms.Label lblInfoCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.BindingSource modelCategoriaBindingSource;
        private System.Windows.Forms.Label lblTituloCategoria;
        private System.Windows.Forms.BindingSource profesoresBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Inscribir;
        private System.Windows.Forms.DataGridViewButtonColumn Unsuscribir;
    }
}