using ProjectGimnasiaYEsgrima;
using ProjectGimnasiaYEsgrima.Utils;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazListaDeportes
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
            this.labelListarDeportes = new System.Windows.Forms.Label();
            this.labelNombreListarDeportes = new System.Windows.Forms.Label();
            this.labelDescripcionListarDeportes = new System.Windows.Forms.Label();
            this.txtNombreDeporte = new System.Windows.Forms.TextBox();
            this.txtDescripcionDeporte = new System.Windows.Forms.TextBox();
            this.BotonBuscar = new System.Windows.Forms.Button();
            this.BotonCrearDeporte = new System.Windows.Forms.Button();
            this.dataGridViewDeporte = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabelInfoDeporte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deporteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListarDeportes
            // 
            this.labelListarDeportes.AutoSize = true;
            this.labelListarDeportes.Location = new System.Drawing.Point(9, 7);
            this.labelListarDeportes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelListarDeportes.Name = "labelListarDeportes";
            this.labelListarDeportes.Size = new System.Drawing.Size(92, 13);
            this.labelListarDeportes.TabIndex = 0;
            this.labelListarDeportes.Text = "Consultar Deporte";
            // 
            // labelNombreListarDeportes
            // 
            this.labelNombreListarDeportes.AutoSize = true;
            this.labelNombreListarDeportes.Location = new System.Drawing.Point(22, 31);
            this.labelNombreListarDeportes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreListarDeportes.Name = "labelNombreListarDeportes";
            this.labelNombreListarDeportes.Size = new System.Drawing.Size(44, 13);
            this.labelNombreListarDeportes.TabIndex = 1;
            this.labelNombreListarDeportes.Text = "Nombre";
            // 
            // labelDescripcionListarDeportes
            // 
            this.labelDescripcionListarDeportes.AutoSize = true;
            this.labelDescripcionListarDeportes.Location = new System.Drawing.Point(22, 58);
            this.labelDescripcionListarDeportes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescripcionListarDeportes.Name = "labelDescripcionListarDeportes";
            this.labelDescripcionListarDeportes.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcionListarDeportes.TabIndex = 1;
            this.labelDescripcionListarDeportes.Text = "Descripción";
            // 
            // txtNombreDeporte
            // 
            this.txtNombreDeporte.Location = new System.Drawing.Point(96, 31);
            this.txtNombreDeporte.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreDeporte.Name = "txtNombreDeporte";
            this.txtNombreDeporte.Size = new System.Drawing.Size(138, 20);
            this.txtNombreDeporte.TabIndex = 2;
            // 
            // txtDescripcionDeporte
            // 
            this.txtDescripcionDeporte.Location = new System.Drawing.Point(96, 56);
            this.txtDescripcionDeporte.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionDeporte.Name = "txtDescripcionDeporte";
            this.txtDescripcionDeporte.Size = new System.Drawing.Size(138, 20);
            this.txtDescripcionDeporte.TabIndex = 2;
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Location = new System.Drawing.Point(193, 84);
            this.BotonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(56, 26);
            this.BotonBuscar.TabIndex = 3;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BotonCrearDeporte
            // 
            this.BotonCrearDeporte.Location = new System.Drawing.Point(271, 84);
            this.BotonCrearDeporte.Margin = new System.Windows.Forms.Padding(2);
            this.BotonCrearDeporte.Name = "BotonCrearDeporte";
            this.BotonCrearDeporte.Size = new System.Drawing.Size(86, 26);
            this.BotonCrearDeporte.TabIndex = 3;
            this.BotonCrearDeporte.Text = "Crear Deporte";
            this.BotonCrearDeporte.UseVisualStyleBackColor = true;
            this.BotonCrearDeporte.Click += new System.EventHandler(this.Button2_Click);
            // 
            // dataGridViewDeporte
            // 
            this.dataGridViewDeporte.AutoGenerateColumns = false;
            this.dataGridViewDeporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.Modificar,
            this.Eliminar});
            this.dataGridViewDeporte.DataSource = this.deporteBindingSource;
            this.dataGridViewDeporte.Location = new System.Drawing.Point(11, 124);
            this.dataGridViewDeporte.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDeporte.Name = "dataGridViewDeporte";
            this.dataGridViewDeporte.RowTemplate.Height = 24;
            this.dataGridViewDeporte.Size = new System.Drawing.Size(577, 166);
            this.dataGridViewDeporte.TabIndex = 4;
            this.dataGridViewDeporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 50;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
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
            // deporteBindingSource
            // 
            this.deporteBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.Deporte);
            // 
            // LabelInfoDeporte
            // 
            this.LabelInfoDeporte.AutoSize = true;
            this.LabelInfoDeporte.Font = new System.Drawing.Font("Arial Black", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfoDeporte.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.LabelInfoDeporte.Location = new System.Drawing.Point(22, 298);
            this.LabelInfoDeporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelInfoDeporte.Name = "LabelInfoDeporte";
            this.LabelInfoDeporte.Size = new System.Drawing.Size(165, 19);
            this.LabelInfoDeporte.TabIndex = 5;
            this.LabelInfoDeporte.Text = "Acá se imprime algo";
            // 
            // InterfazListaDeportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 325);
            this.Controls.Add(this.LabelInfoDeporte);
            this.Controls.Add(this.dataGridViewDeporte);
            this.Controls.Add(this.BotonCrearDeporte);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.txtNombreDeporte);
            this.Controls.Add(this.txtDescripcionDeporte);
            this.Controls.Add(this.labelDescripcionListarDeportes);
            this.Controls.Add(this.labelNombreListarDeportes);
            this.Controls.Add(this.labelListarDeportes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InterfazListaDeportes";
            this.Text = "InterfazListaDeportes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deporteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListarDeportes;
        private System.Windows.Forms.Label labelNombreListarDeportes;
        private System.Windows.Forms.Label labelDescripcionListarDeportes;
        private System.Windows.Forms.TextBox txtNombreDeporte;
        private System.Windows.Forms.TextBox txtDescripcionDeporte;
        private System.Windows.Forms.Button BotonBuscar;
        private System.Windows.Forms.Button BotonCrearDeporte;
        private System.Windows.Forms.DataGridView dataGridViewDeporte;
        private System.Windows.Forms.BindingSource deporteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Label LabelInfoDeporte;
    }
}