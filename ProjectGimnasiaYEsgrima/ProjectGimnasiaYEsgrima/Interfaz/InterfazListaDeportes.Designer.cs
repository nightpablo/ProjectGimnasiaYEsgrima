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
            this.lblTituloDeporte = new System.Windows.Forms.Label();
            this.lblNombreDeporte = new System.Windows.Forms.Label();
            this.lblDescripcionDeporte = new System.Windows.Forms.Label();
            this.txtNombreDeporte = new System.Windows.Forms.TextBox();
            this.txtDescripcionDeporte = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCrearDeporte = new System.Windows.Forms.Button();
            this.dataGridViewDeporte = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDeporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.modelDeporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblInfoDeporte = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.deporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDeporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deporteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloDeporte
            // 
            this.lblTituloDeporte.AutoSize = true;
            this.lblTituloDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloDeporte.Location = new System.Drawing.Point(16, 0);
            this.lblTituloDeporte.Name = "lblTituloDeporte";
            this.lblTituloDeporte.Size = new System.Drawing.Size(236, 32);
            this.lblTituloDeporte.TabIndex = 0;
            this.lblTituloDeporte.Text = "Gestión Deportes";
            // 
            // lblNombreDeporte
            // 
            this.lblNombreDeporte.AutoSize = true;
            this.lblNombreDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDeporte.Location = new System.Drawing.Point(29, 46);
            this.lblNombreDeporte.Name = "lblNombreDeporte";
            this.lblNombreDeporte.Size = new System.Drawing.Size(101, 29);
            this.lblNombreDeporte.TabIndex = 1;
            this.lblNombreDeporte.Text = "Nombre";
            // 
            // lblDescripcionDeporte
            // 
            this.lblDescripcionDeporte.AutoSize = true;
            this.lblDescripcionDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionDeporte.Location = new System.Drawing.Point(29, 87);
            this.lblDescripcionDeporte.Name = "lblDescripcionDeporte";
            this.lblDescripcionDeporte.Size = new System.Drawing.Size(141, 29);
            this.lblDescripcionDeporte.TabIndex = 1;
            this.lblDescripcionDeporte.Text = "Descripción";
            // 
            // txtNombreDeporte
            // 
            this.txtNombreDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDeporte.Location = new System.Drawing.Point(200, 46);
            this.txtNombreDeporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreDeporte.Name = "txtNombreDeporte";
            this.txtNombreDeporte.Size = new System.Drawing.Size(280, 34);
            this.txtNombreDeporte.TabIndex = 2;
            // 
            // txtDescripcionDeporte
            // 
            this.txtDescripcionDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionDeporte.Location = new System.Drawing.Point(200, 88);
            this.txtDescripcionDeporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcionDeporte.Name = "txtDescripcionDeporte";
            this.txtDescripcionDeporte.Size = new System.Drawing.Size(280, 34);
            this.txtDescripcionDeporte.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(296, 136);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 41);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnCrearDeporte
            // 
            this.btnCrearDeporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearDeporte.Location = new System.Drawing.Point(432, 136);
            this.btnCrearDeporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearDeporte.Name = "btnCrearDeporte";
            this.btnCrearDeporte.Size = new System.Drawing.Size(199, 41);
            this.btnCrearDeporte.TabIndex = 3;
            this.btnCrearDeporte.Text = "Crear Deporte";
            this.btnCrearDeporte.UseVisualStyleBackColor = true;
            this.btnCrearDeporte.Click += new System.EventHandler(this.Button2_Click);
            // 
            // dataGridViewDeporte
            // 
            this.dataGridViewDeporte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDeporte.AutoGenerateColumns = false;
            this.dataGridViewDeporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.estadoDeporteDataGridViewTextBoxColumn,
            this.Modificar,
            this.Eliminar});
            this.dataGridViewDeporte.DataSource = this.modelDeporteBindingSource;
            this.dataGridViewDeporte.Location = new System.Drawing.Point(8, 184);
            this.dataGridViewDeporte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDeporte.Name = "dataGridViewDeporte";
            this.dataGridViewDeporte.RowTemplate.Height = 24;
            this.dataGridViewDeporte.Size = new System.Drawing.Size(784, 204);
            this.dataGridViewDeporte.TabIndex = 4;
            this.dataGridViewDeporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // estadoDeporteDataGridViewTextBoxColumn
            // 
            this.estadoDeporteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // modelDeporteBindingSource
            // 
            this.modelDeporteBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.ModelDeporte);
            // 
            // lblInfoDeporte
            // 
            this.lblInfoDeporte.AutoSize = true;
            this.lblInfoDeporte.Font = new System.Drawing.Font("Arial Black", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDeporte.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblInfoDeporte.Location = new System.Drawing.Point(24, 392);
            this.lblInfoDeporte.Name = "lblInfoDeporte";
            this.lblInfoDeporte.Size = new System.Drawing.Size(199, 24);
            this.lblInfoDeporte.TabIndex = 5;
            this.lblInfoDeporte.Text = "Acá se imprime algo";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(672, 136);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(97, 40);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // deporteBindingSource
            // 
            this.deporteBindingSource.DataSource = typeof(ProjectGimnasiaYEsgrima.Modelo.Deporte);
            // 
            // InterfazListaDeportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblInfoDeporte);
            this.Controls.Add(this.dataGridViewDeporte);
            this.Controls.Add(this.btnCrearDeporte);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombreDeporte);
            this.Controls.Add(this.txtDescripcionDeporte);
            this.Controls.Add(this.lblDescripcionDeporte);
            this.Controls.Add(this.lblNombreDeporte);
            this.Controls.Add(this.lblTituloDeporte);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InterfazListaDeportes";
            this.Text = "InterfazListaDeportes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BtnVolver_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDeporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deporteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloDeporte;
        private System.Windows.Forms.Label lblNombreDeporte;
        private System.Windows.Forms.Label lblDescripcionDeporte;
        private System.Windows.Forms.TextBox txtNombreDeporte;
        private System.Windows.Forms.TextBox txtDescripcionDeporte;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCrearDeporte;
        private System.Windows.Forms.DataGridView dataGridViewDeporte;
        private System.Windows.Forms.BindingSource deporteBindingSource;
        private System.Windows.Forms.Label lblInfoDeporte;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.BindingSource modelDeporteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDeporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}