
using System;
using System.Windows.Forms;

namespace ProjectGimnasiaYEsgrima.Utils
{
    public class CampoConRestriccion
    {

        public void Limitador(object sender, KeyPressEventArgs e, TextBox textBox, int length)
        {
            if (textBox.Text.Length <= length)
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public void PermiteLetrasYNumerosYSeparadorYLimitador(object sender, KeyPressEventArgs e, TextBox textBox, int length)
        {
            if(textBox.Text.Length <= length) {
                PermiteLetrasYNumerosYSeparador(sender, e);
            }
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public void PermiteLetrasYNumeros(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public void PermiteLetrasYNumerosYSeparador(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public void PermiteLetrasYNumerosYLimitador(object sender, KeyPressEventArgs e, TextBox textBox, int length)
        {
            if (textBox.Text.Length <= length)
                PermiteLetrasYNumeros(sender, e);
            else
                e.Handled = true;
        }

        public void PermiteLetrasYSeparador(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public void PermiteLetrasYSeparadorYLimitador(object sender, KeyPressEventArgs e, TextBox textBox, int length)
        {
            if (textBox.Text.Length <= length)
            {
                PermiteLetrasYSeparador(sender, e); //definirlo!!
            }
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public void PermiteLetrasYLimitador(object sender, KeyPressEventArgs e, TextBox textBox, int length)
        {
            if (textBox.Text.Length <= length)
            {
                PermiteLetras(sender,e);
            }
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public void PermiteLetras(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public void PermiteNumerosYLimitador(object sender, KeyPressEventArgs e, TextBox textBox, int length)
        {
            if (textBox.Text.Length <= length)
            {
                PermiteNumeros(sender, e);
            }
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public void PermiteNumeros(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public void EventoEnterFocus(object sender, KeyPressEventArgs e, System.Windows.Forms.TextBox textBox)
        {
            if(e.KeyChar == (char)13)
                textBox.Focus();
        }

        public void EventoEnterFocus(object sender, KeyPressEventArgs e, System.Windows.Forms.Button button)
        {
            if (e.KeyChar == (char)13)
                button.PerformClick();
        }
    }
}
