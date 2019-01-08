using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGimnasiaYEsgrima.Utils
{
    public class InterfazBuena
    {
        private Color ColorFondo = Color.FromArgb(39, 57, 80);
        private Font FuenteLetra = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        private Color ColorLetra = System.Drawing.Color.White;
        private Color ColorMouseFuera = System.Drawing.Color.LightSkyBlue;
        private Color ColorMouseDentro = System.Drawing.Color.LightBlue;
        private Color ColorBoton = Color.FromArgb(63, 94, 135);

        private Color ColorTablaLetra = Color.FromArgb(255, 255, 255);
        private Color ColorTablaCeldas = Color.FromArgb(39, 57, 80);
        private Color ColorTablaBoton = Color.FromArgb(63, 94, 135);
        private Color ColorTablaCabecera = Color.FromArgb(23, 32, 43);
        private Color ColorTabla = Color.FromArgb(39, 57, 80);

        private Font FuenteLabel = new System.Drawing.Font("Century Gothic", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        private Color ColorLabel = System.Drawing.Color.White;

        private Font FuenteTextBox = new System.Drawing.Font("Century Gothic", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        private Color ColorTextBox = Color.Black;

        public void TransformarVentanaPersonalizado(Form form)
        {
            form.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            form.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form.BackColor = ColorFondo;        
            form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            form.PerformLayout();
        }

        public void TransformarTituloVentanaPersonalizado(Label label)
        {
            label.Font = new System.Drawing.Font(FuenteLetra.Name, FuenteLetra.Size + 4, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.ForeColor = ColorLetra;
            label.BackColor = ColorFondo;
            label.BorderStyle = BorderStyle.Fixed3D;
            label.AutoSize = false;
            label.Dock = DockStyle.Fill;
            label.MaximumSize = new Size(99999,24);
            
        }

        public void TransformarBotonPersonalizado(Button button)
        {
            button.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.MouseDownBackColor = ColorMouseFuera;
            button.FlatAppearance.MouseOverBackColor = ColorMouseDentro;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.Font = FuenteLetra;
            button.ForeColor = ColorLetra;
            button.UseVisualStyleBackColor = false;
            button.BackColor = ColorBoton;
            button.AutoSize = true;
            button.AutoSizeMode = AutoSizeMode.GrowOnly;
        }

        public void TransformarTablaPersonalizado(DataGridView tabla)
        {
            //Modifico los colores de todas las celdas
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.ForeColor = ColorTablaLetra;
            style.BackColor = ColorTablaCeldas;
            style.Font = new System.Drawing.Font(FuenteLetra.Name, FuenteLetra.Size-2, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tabla.DefaultCellStyle = style;
            tabla.BackgroundColor = ColorTabla;
            //Modifico las cabeceras de las filas los colores
            tabla.RowHeadersDefaultCellStyle.BackColor = ColorTablaCabecera;
            tabla.RowHeadersDefaultCellStyle.Font = FuenteLetra;
            tabla.RowHeadersDefaultCellStyle.ForeColor = ColorTablaLetra;
            tabla.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //Modifico las cabeceras de las columnas los colores
            tabla.ColumnHeadersDefaultCellStyle.BackColor = ColorTablaCabecera;
            tabla.ColumnHeadersDefaultCellStyle.Font = FuenteLetra;
            tabla.ColumnHeadersDefaultCellStyle.ForeColor = ColorTablaLetra;
            tabla.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tabla.EnableHeadersVisualStyles = false;
            tabla.RowTemplate.Height = 30;
            tabla.BorderStyle = BorderStyle.Fixed3D;
            
        }
        
        public void TransformarTablaBotonesPersonalizados(DataGridViewButtonColumn boton)
        {
            //Modifico los colores de los botones que corresponden a una tabla
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Font = new System.Drawing.Font(FuenteLetra.Name, FuenteLetra.Size - 2, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            style.ForeColor = ColorTablaLetra;
            
            style.BackColor = ColorTablaBoton;
            boton.DefaultCellStyle = style;
            boton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            int i = boton.DataGridView.Columns.IndexOf(boton);
            boton.DataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
        }

        public void TransformarLabelTextoPersonalizado(Label label)
        {
            label.Font = FuenteLabel;
            label.ForeColor = ColorLabel;
        }

        public void TransformarTextBoxTextoPersonalizado(TextBox textBox)
        {
            textBox.Font = FuenteTextBox;
            textBox.ForeColor = ColorTextBox;
        }

        public void TransformarTextBoxTextoNoEditablePersonalizado(TextBox textBox)
        {
            textBox.Font = new System.Drawing.Font("Century Gothic", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox.ForeColor = Color.White;
            textBox.BackColor = Color.DarkGray;
        }

        public void TransformarTextBoxTextoPersonalizadoTodos(params TextBox[] textBoxes)
        {
            foreach (var i in textBoxes)
                TransformarTextBoxTextoPersonalizado(i);
        }

        public void TransformarLabelTextoPersonalizadoTodos(params Label[] textBoxes)
        {
            foreach (var i in textBoxes)
                TransformarLabelTextoPersonalizado(i);
        }

        public void TransformarBotonPersonalizadoTodos(params Button[] textBoxes)
        {
            foreach (var i in textBoxes)
                TransformarBotonPersonalizado(i);
        }

        public void TransformarTablaBotonesPersonalizadosTodos(params DataGridViewButtonColumn[] textBoxes)
        {
            foreach (var i in textBoxes)
                TransformarTablaBotonesPersonalizados(i);
        }

        public void TransformarDateTimePickerPersonalizado(DateTimePicker date)
        {
            date.Font = FuenteTextBox;
            date.ForeColor = ColorTextBox;
        }

        public void TransformarComboBoxPersonalizado(ComboBox cbx)
        {
            cbx.Font = FuenteTextBox;
            cbx.ForeColor = ColorTextBox;
        }
    }
}
