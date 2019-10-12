namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazEmisionCuponPago
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
            this.lblTituloCuponSocio = new System.Windows.Forms.Label();
            this.dgvListaCuponesSocio = new System.Windows.Forms.DataGridView();
            this.Confirmación = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCobroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anular = new System.Windows.Forms.DataGridViewButtonColumn();
            this.modelCuponSocioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblFechaEmisionInicial = new System.Windows.Forms.Label();
            this.cbxFechaEmisionInicial = new System.Windows.Forms.ComboBox();
            this.cbxFechaEmisionFinal = new System.Windows.Forms.ComboBox();
            this.lblFechaEmisionFinal = new System.Windows.Forms.Label();
            this.cbxPagados = new System.Windows.Forms.CheckBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblPrueba = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCuponesSocio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelCuponSocioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloCuponSocio
            // 
            this.lblTituloCuponSocio.AutoSize = true;
            this.lblTituloCuponSocio.Location = new System.Drawing.Point(48, 6);
            this.lblTituloCuponSocio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloCuponSocio.Name = "lblTituloCuponSocio";
            this.lblTituloCuponSocio.Size = new System.Drawing.Size(116, 13);
            this.lblTituloCuponSocio.TabIndex = 0;
            this.lblTituloCuponSocio.Text = "Cupon de pago - Socio";
            // 
            // dgvListaCuponesSocio
            // 
            this.dgvListaCuponesSocio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaCuponesSocio.AutoGenerateColumns = false;
            this.dgvListaCuponesSocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCuponesSocio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Confirmación,
            this.NombreCategoria,
            this.fechaEmisionDataGridViewTextBoxColumn,
            this.fechaCobroDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.Anular});
            this.dgvListaCuponesSocio.DataSource = this.modelCuponSocioBindingSource;
            this.dgvListaCuponesSocio.Location = new System.Drawing.Point(6, 150);
            this.dgvListaCuponesSocio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvListaCuponesSocio.Name = "dgvListaCuponesSocio";
            this.dgvListaCuponesSocio.RowTemplate.Height = 24;
            this.dgvListaCuponesSocio.Size = new System.Drawing.Size(588, 143);
            this.dgvListaCuponesSocio.TabIndex = 1;
            this.dgvListaCuponesSocio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaCuponesSocio_CellContentClick);
            // 
            // Confirmación
            // 
            this.Confirmación.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Confirmación.HeaderText = "¿Paga?";
            this.Confirmación.Name = "Confirmación";
            this.Confirmación.Width = 50;
            // 
            // NombreCategoria
            // 
            this.NombreCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NombreCategoria.DataPropertyName = "NombreCategoria";
            this.NombreCategoria.HeaderText = "NombreCategoria";
            this.NombreCategoria.Name = "NombreCategoria";
            this.NombreCategoria.Width = 114;
            // 
            // fechaEmisionDataGridViewTextBoxColumn
            // 
            this.fechaEmisionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaEmisionDataGridViewTextBoxColumn.DataPropertyName = "FechaEmision";
            this.fechaEmisionDataGridViewTextBoxColumn.HeaderText = "FechaEmision";
            this.fechaEmisionDataGridViewTextBoxColumn.Name = "fechaEmisionDataGridViewTextBoxColumn";
            // 
            // fechaCobroDataGridViewTextBoxColumn
            // 
            this.fechaCobroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaCobroDataGridViewTextBoxColumn.DataPropertyName = "FechaCobro";
            this.fechaCobroDataGridViewTextBoxColumn.HeaderText = "FechaCobro";
            this.fechaCobroDataGridViewTextBoxColumn.Name = "fechaCobroDataGridViewTextBoxColumn";
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "Importe";
            this.importeDataGridViewTextBoxColumn.HeaderText = "Importe";
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // Anular
            // 
            this.Anular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Anular.HeaderText = "";
            this.Anular.Name = "Anular";
            this.Anular.ReadOnly = true;
            this.Anular.Text = "Anular";
            this.Anular.UseColumnTextForButtonValue = true;
            this.Anular.Width = 21;
            // 
            // modelCuponSocioBindingSource
            // 
            this.modelCuponSocioBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.ModelCuponSocio);
            // 
            // lblFechaEmisionInicial
            // 
            this.lblFechaEmisionInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEmisionInicial.Location = new System.Drawing.Point(24, 52);
            this.lblFechaEmisionInicial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaEmisionInicial.Name = "lblFechaEmisionInicial";
            this.lblFechaEmisionInicial.Size = new System.Drawing.Size(120, 19);
            this.lblFechaEmisionInicial.TabIndex = 2;
            this.lblFechaEmisionInicial.Text = "Fecha desde";
            this.lblFechaEmisionInicial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxFechaEmisionInicial
            // 
            this.cbxFechaEmisionInicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFechaEmisionInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFechaEmisionInicial.FormattingEnabled = true;
            this.cbxFechaEmisionInicial.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbxFechaEmisionInicial.Location = new System.Drawing.Point(162, 52);
            this.cbxFechaEmisionInicial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxFechaEmisionInicial.Name = "cbxFechaEmisionInicial";
            this.cbxFechaEmisionInicial.Size = new System.Drawing.Size(157, 32);
            this.cbxFechaEmisionInicial.TabIndex = 1;
            this.cbxFechaEmisionInicial.SelectedIndexChanged += new System.EventHandler(this.cbxFechaEmisionInicial_SelectedIndexChanged);
            // 
            // cbxFechaEmisionFinal
            // 
            this.cbxFechaEmisionFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFechaEmisionFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFechaEmisionFinal.FormattingEnabled = true;
            this.cbxFechaEmisionFinal.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbxFechaEmisionFinal.Location = new System.Drawing.Point(162, 84);
            this.cbxFechaEmisionFinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxFechaEmisionFinal.Name = "cbxFechaEmisionFinal";
            this.cbxFechaEmisionFinal.Size = new System.Drawing.Size(157, 32);
            this.cbxFechaEmisionFinal.TabIndex = 2;
            this.cbxFechaEmisionFinal.SelectedIndexChanged += new System.EventHandler(this.cbxFechaEmisionFinal_SelectedIndexChanged);
            // 
            // lblFechaEmisionFinal
            // 
            this.lblFechaEmisionFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEmisionFinal.Location = new System.Drawing.Point(30, 84);
            this.lblFechaEmisionFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaEmisionFinal.Name = "lblFechaEmisionFinal";
            this.lblFechaEmisionFinal.Size = new System.Drawing.Size(114, 19);
            this.lblFechaEmisionFinal.TabIndex = 4;
            this.lblFechaEmisionFinal.Text = "Fecha hasta";
            this.lblFechaEmisionFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbxPagados
            // 
            this.cbxPagados.AutoSize = true;
            this.cbxPagados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPagados.Location = new System.Drawing.Point(6, 117);
            this.cbxPagados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxPagados.Name = "cbxPagados";
            this.cbxPagados.Size = new System.Drawing.Size(236, 28);
            this.cbxPagados.TabIndex = 3;
            this.cbxPagados.Text = "¿Ver cupones pagados?";
            this.cbxPagados.UseVisualStyleBackColor = true;
            this.cbxPagados.CheckedChanged += new System.EventHandler(this.cbxPagados_CheckedChanged);
            // 
            // btnPagar
            // 
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(324, 104);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(126, 39);
            this.btnPagar.TabIndex = 4;
            this.btnPagar.Text = "Pagar y emitir";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(480, 104);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(90, 39);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblPrueba
            // 
            this.lblPrueba.AutoSize = true;
            this.lblPrueba.Location = new System.Drawing.Point(336, 52);
            this.lblPrueba.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(55, 13);
            this.lblPrueba.TabIndex = 8;
            this.lblPrueba.Text = "Texto aca";
            // 
            // InterfazEmisionCuponPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblPrueba);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.cbxPagados);
            this.Controls.Add(this.lblFechaEmisionFinal);
            this.Controls.Add(this.cbxFechaEmisionFinal);
            this.Controls.Add(this.cbxFechaEmisionInicial);
            this.Controls.Add(this.lblFechaEmisionInicial);
            this.Controls.Add(this.dgvListaCuponesSocio);
            this.Controls.Add(this.lblTituloCuponSocio);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "InterfazEmisionCuponPago";
            this.Text = "InterfazEmisionCuponPago";
            this.Load += new System.EventHandler(this.InterfazEmisionCuponPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCuponesSocio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelCuponSocioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloCuponSocio;
        private System.Windows.Forms.DataGridView dgvListaCuponesSocio;
        private System.Windows.Forms.BindingSource modelCuponSocioBindingSource;
        private System.Windows.Forms.Label lblFechaEmisionInicial;
        private System.Windows.Forms.ComboBox cbxFechaEmisionInicial;
        private System.Windows.Forms.ComboBox cbxFechaEmisionFinal;
        private System.Windows.Forms.Label lblFechaEmisionFinal;
        private System.Windows.Forms.CheckBox cbxPagados;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblPrueba;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Confirmación;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCobroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Anular;
    }
}