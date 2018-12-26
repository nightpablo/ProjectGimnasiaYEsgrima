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
            this.LabelInfoDeporte = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.deporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelDeporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDeporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDeporteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListarDeportes
            // 
            this.labelListarDeportes.AutoSize = true;
            this.labelListarDeportes.Location = new System.Drawing.Point(12, 9);
            this.labelListarDeportes.Name = "labelListarDeportes";
            this.labelListarDeportes.Size = new System.Drawing.Size(123, 17);
            this.labelListarDeportes.TabIndex = 0;
            this.labelListarDeportes.Text = "Consultar Deporte";
            // 
            // labelNombreListarDeportes
            // 
            this.labelNombreListarDeportes.AutoSize = true;
            this.labelNombreListarDeportes.Location = new System.Drawing.Point(29, 38);
            this.labelNombreListarDeportes.Name = "labelNombreListarDeportes";
            this.labelNombreListarDeportes.Size = new System.Drawing.Size(58, 17);
            this.labelNombreListarDeportes.TabIndex = 1;
            this.labelNombreListarDeportes.Text = "Nombre";
            // 
            // labelDescripcionListarDeportes
            // 
            this.labelDescripcionListarDeportes.AutoSize = true;
            this.labelDescripcionListarDeportes.Location = new System.Drawing.Point(29, 71);
            this.labelDescripcionListarDeportes.Name = "labelDescripcionListarDeportes";
            this.labelDescripcionListarDeportes.Size = new System.Drawing.Size(82, 17);
            this.labelDescripcionListarDeportes.TabIndex = 1;
            this.labelDescripcionListarDeportes.Text = "Descripción";
            // 
            // txtNombreDeporte
            // 
            this.txtNombreDeporte.Location = new System.Drawing.Point(128, 38);
            this.txtNombreDeporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreDeporte.Name = "txtNombreDeporte";
            this.txtNombreDeporte.Size = new System.Drawing.Size(183, 22);
            this.txtNombreDeporte.TabIndex = 2;
            // 
            // txtDescripcionDeporte
            // 
            this.txtDescripcionDeporte.Location = new System.Drawing.Point(128, 69);
            this.txtDescripcionDeporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcionDeporte.Name = "txtDescripcionDeporte";
            this.txtDescripcionDeporte.Size = new System.Drawing.Size(183, 22);
            this.txtDescripcionDeporte.TabIndex = 2;
            // 
            // BotonBuscar
            // 
            this.BotonBuscar.Location = new System.Drawing.Point(257, 103);
            this.BotonBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonBuscar.Name = "BotonBuscar";
            this.BotonBuscar.Size = new System.Drawing.Size(75, 32);
            this.BotonBuscar.TabIndex = 3;
            this.BotonBuscar.Text = "Buscar";
            this.BotonBuscar.UseVisualStyleBackColor = true;
            this.BotonBuscar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BotonCrearDeporte
            // 
            this.BotonCrearDeporte.Location = new System.Drawing.Point(361, 103);
            this.BotonCrearDeporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotonCrearDeporte.Name = "BotonCrearDeporte";
            this.BotonCrearDeporte.Size = new System.Drawing.Size(115, 32);
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
            this.estadoDeporteDataGridViewTextBoxColumn,
            this.Modificar,
            this.Eliminar});
            this.dataGridViewDeporte.DataSource = this.modelDeporteBindingSource;
            this.dataGridViewDeporte.Location = new System.Drawing.Point(15, 153);
            this.dataGridViewDeporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDeporte.Name = "dataGridViewDeporte";
            this.dataGridViewDeporte.RowTemplate.Height = 24;
            this.dataGridViewDeporte.Size = new System.Drawing.Size(769, 204);
            this.dataGridViewDeporte.TabIndex = 4;
            this.dataGridViewDeporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // LabelInfoDeporte
            // 
            this.LabelInfoDeporte.AutoSize = true;
            this.LabelInfoDeporte.Font = new System.Drawing.Font("Arial Black", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInfoDeporte.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.LabelInfoDeporte.Location = new System.Drawing.Point(29, 367);
            this.LabelInfoDeporte.Name = "LabelInfoDeporte";
            this.LabelInfoDeporte.Size = new System.Drawing.Size(199, 24);
            this.LabelInfoDeporte.TabIndex = 5;
            this.LabelInfoDeporte.Text = "Acá se imprime algo";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(502, 103);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(97, 32);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // deporteBindingSource
            // 
            this.deporteBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.Deporte);
            // 
            // modelDeporteBindingSource
            // 
            this.modelDeporteBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.ModelDeporte);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // estadoDeporteDataGridViewTextBoxColumn
            // 
            this.estadoDeporteDataGridViewTextBoxColumn.DataPropertyName = "EstadoDeporte";
            this.estadoDeporteDataGridViewTextBoxColumn.HeaderText = "EstadoDeporte";
            this.estadoDeporteDataGridViewTextBoxColumn.Name = "estadoDeporteDataGridViewTextBoxColumn";
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
            // InterfazListaDeportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 400);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.LabelInfoDeporte);
            this.Controls.Add(this.dataGridViewDeporte);
            this.Controls.Add(this.BotonCrearDeporte);
            this.Controls.Add(this.BotonBuscar);
            this.Controls.Add(this.txtNombreDeporte);
            this.Controls.Add(this.txtDescripcionDeporte);
            this.Controls.Add(this.labelDescripcionListarDeportes);
            this.Controls.Add(this.labelNombreListarDeportes);
            this.Controls.Add(this.labelListarDeportes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InterfazListaDeportes";
            this.Text = "InterfazListaDeportes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDeporteBindingSource)).EndInit();
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
        private System.Windows.Forms.Label LabelInfoDeporte;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDeporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.BindingSource modelDeporteBindingSource;
    }
}