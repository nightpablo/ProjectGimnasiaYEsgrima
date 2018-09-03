﻿namespace ProjectGimnasiaYEsgrima.Interfaz
{
    partial class InterfazAltaEmpleado
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
            this.ComboboxTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.textBoxNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeInicioEmpleado = new System.Windows.Forms.DateTimePicker();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelDeportes = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.botonGuardarEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboboxTipoEmpleado
            // 
            this.ComboboxTipoEmpleado.FormattingEnabled = true;
            this.ComboboxTipoEmpleado.Items.AddRange(new object[] {
            "Profesor",
            "Secretaria"});
            this.ComboboxTipoEmpleado.Location = new System.Drawing.Point(118, 203);
            this.ComboboxTipoEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.ComboboxTipoEmpleado.Name = "ComboboxTipoEmpleado";
            this.ComboboxTipoEmpleado.Size = new System.Drawing.Size(189, 21);
            this.ComboboxTipoEmpleado.TabIndex = 0;
            this.ComboboxTipoEmpleado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxNombreEmpleado
            // 
            this.textBoxNombreEmpleado.Location = new System.Drawing.Point(118, 32);
            this.textBoxNombreEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNombreEmpleado.Name = "textBoxNombreEmpleado";
            this.textBoxNombreEmpleado.Size = new System.Drawing.Size(189, 20);
            this.textBoxNombreEmpleado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // textBoxApellidoEmpleado
            // 
            this.textBoxApellidoEmpleado.Location = new System.Drawing.Point(118, 55);
            this.textBoxApellidoEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxApellidoEmpleado.Name = "textBoxApellidoEmpleado";
            this.textBoxApellidoEmpleado.Size = new System.Drawing.Size(189, 20);
            this.textBoxApellidoEmpleado.TabIndex = 1;
            this.textBoxApellidoEmpleado.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(118, 78);
            this.textBoxDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(189, 20);
            this.textBoxDocumento.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // dateTimeNacimiento
            // 
            this.dateTimeNacimiento.Location = new System.Drawing.Point(118, 102);
            this.dateTimeNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeNacimiento.Name = "dateTimeNacimiento";
            this.dateTimeNacimiento.Size = new System.Drawing.Size(189, 20);
            this.dateTimeNacimiento.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tipo de Empleado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fecha de inicio";
            // 
            // dateTimeInicioEmpleado
            // 
            this.dateTimeInicioEmpleado.Location = new System.Drawing.Point(118, 156);
            this.dateTimeInicioEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeInicioEmpleado.Name = "dateTimeInicioEmpleado";
            this.dateTimeInicioEmpleado.Size = new System.Drawing.Size(189, 20);
            this.dateTimeInicioEmpleado.TabIndex = 3;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(118, 180);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(189, 20);
            this.textBoxDescripcion.TabIndex = 1;
            this.textBoxDescripcion.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Descripción Tarea";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Detalle Persona";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(177, 138);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Detalle Empleado";
            // 
            // labelDeportes
            // 
            this.labelDeportes.AutoSize = true;
            this.labelDeportes.Location = new System.Drawing.Point(68, 230);
            this.labelDeportes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDeportes.Name = "labelDeportes";
            this.labelDeportes.Size = new System.Drawing.Size(45, 13);
            this.labelDeportes.TabIndex = 2;
            this.labelDeportes.Text = "Deporte";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(118, 233);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(188, 79);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // botonGuardarEmpleado
            // 
            this.botonGuardarEmpleado.Location = new System.Drawing.Point(118, 346);
            this.botonGuardarEmpleado.Name = "botonGuardarEmpleado";
            this.botonGuardarEmpleado.Size = new System.Drawing.Size(75, 23);
            this.botonGuardarEmpleado.TabIndex = 5;
            this.botonGuardarEmpleado.Text = "Guardar";
            this.botonGuardarEmpleado.UseVisualStyleBackColor = true;
            this.botonGuardarEmpleado.Click += new System.EventHandler(this.botonGuardarEmpleado_Click);
            // 
            // InterfazAltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 393);
            this.Controls.Add(this.botonGuardarEmpleado);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.dateTimeInicioEmpleado);
            this.Controls.Add(this.dateTimeNacimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelDeportes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxDocumento);
            this.Controls.Add(this.textBoxApellidoEmpleado);
            this.Controls.Add(this.textBoxNombreEmpleado);
            this.Controls.Add(this.ComboboxTipoEmpleado);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InterfazAltaEmpleado";
            this.Text = "InterfazAltaEmpleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboboxTipoEmpleado;
        private System.Windows.Forms.TextBox textBoxNombreEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxApellidoEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeNacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeInicioEmpleado;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelDeportes;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button botonGuardarEmpleado;
    }
}