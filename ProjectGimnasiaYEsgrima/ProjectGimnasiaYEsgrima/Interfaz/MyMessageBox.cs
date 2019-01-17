using ProjectGimnasiaYEsgrima.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    public partial class MyMessageBox : Form
    {

        static MyMessageBox newMessageBox;
        public Timer msgTimer;
        static string Button_id;
        static int Selected_Text;
        int disposeFormTimer; 

        public MyMessageBox()
        {
            InitializeComponent();
            new InterfazBuena().TransformarVentanaPersonalizado(this);
            new InterfazBuena().TransformarLabelTextoPersonalizadoTodos(lblTitle,lblMessage);
            new InterfazBuena().TransformarBotonPersonalizadoTodos(btnOK,btnCancel);
            new InterfazBuena().TransformarComboBoxPersonalizado(cbxSelectOption);
        }

        public static void Show(Form myForm, string txtMessage, string txtTitle)
        {
            Show(txtMessage, txtTitle, MessageBoxIcon.Information);
        }

        public static void Show(string txtMessage, string txtTitle, MessageBoxIcon Question)
        {
            newMessageBox = new MyMessageBox();
            newMessageBox.btnCancel.Hide();
            newMessageBox.btnOK.Text = "Aceptar";
            newMessageBox.lblTitle.Text = txtTitle;
            newMessageBox.lblMessage.Text = txtMessage;
            newMessageBox.label1.Image = tomarIcono(Question);
            newMessageBox.cbxSelectOption.Visible = false;
            newMessageBox.ShowDialog();
        }

        public static DialogResult Show(string txtMessage, string txtTitle, MessageBoxButtons YesNo, MessageBoxIcon Question)
        {
            newMessageBox = new MyMessageBox();
            newMessageBox.lblTitle.Text = txtTitle;
            newMessageBox.lblMessage.Text = txtMessage;
            newMessageBox.label1.Image = tomarIcono(Question);
            newMessageBox.cbxSelectOption.Visible = false;
            newMessageBox.ShowDialog();
            return (Int32.Parse(Button_id)==1? DialogResult.OK:DialogResult.Cancel);
        }

        public static Object[] ShowComboBox(string txtMessage, string txtTitle, string[] options, MessageBoxButtons YesNo, MessageBoxIcon Question)
        {
            newMessageBox = new MyMessageBox();
            newMessageBox.lblTitle.Text = txtTitle;
            newMessageBox.lblMessage.Text = txtMessage;
            newMessageBox.cbxSelectOption.Visible = true;
            newMessageBox.Size = new Size(newMessageBox.Size.Width, newMessageBox.Size.Height + 70);
            newMessageBox.btnOK.Location = new Point(newMessageBox.btnOK.Location.X, newMessageBox.btnOK.Location.Y + 70);
            newMessageBox.btnCancel.Location = new Point(newMessageBox.btnCancel.Location.X, newMessageBox.btnCancel.Location.Y + 70);
            newMessageBox.lblMessage.Size = new Size(newMessageBox.lblMessage.Size.Width, newMessageBox.lblMessage.Size.Height );
            newMessageBox.cbxSelectOption.Location = new Point(newMessageBox.lblMessage.Location.X, newMessageBox.Location.Y + 80);
            newMessageBox.cbxSelectOption.Size = new Size(newMessageBox.lblMessage.Size.Width, newMessageBox.cbxSelectOption.Size.Height);
            newMessageBox.cbxSelectOption.DropDownStyle = ComboBoxStyle.DropDownList;
            newMessageBox.panel1.Size = new Size(newMessageBox.panel1.Size.Width, newMessageBox.panel1.Size.Height + 70);
            newMessageBox.label1.Image = tomarIcono(Question);
            newMessageBox.ShowDialog();
            Object[] obj = new Object[]
            {
                Int32.Parse(Button_id) == 1 ? DialogResult.OK :DialogResult.Cancel,
                Selected_Text
            };
            return obj;
        }

        private static Image tomarIcono(MessageBoxIcon Icon)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMessageBox));
            if (Icon == MessageBoxIcon.Question)
            {
                return ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            }
            else if(Icon == MessageBoxIcon.Information)
            {
                return ((System.Drawing.Image)(resources.GetObject("Information")));
            }
            else return null;
        }

        public static string ShowBox(string txtMessage)
        {
            newMessageBox = new MyMessageBox();
            newMessageBox.lblMessage.Text = txtMessage;
            newMessageBox.ShowDialog();
            return Button_id;
        }

        public static string ShowBox(string txtMessage, string txtTitle)
        {
            newMessageBox = new MyMessageBox();
            newMessageBox.lblTitle.Text = txtTitle;
            newMessageBox.lblMessage.Text = txtMessage;
            newMessageBox.ShowDialog();
            return Button_id;
        } 

        private void MyMessageBox_Load(object sender, EventArgs e)
        {
            disposeFormTimer = 30;
            newMessageBox.lblTimer.Text = disposeFormTimer.ToString();
            msgTimer = new Timer();
            msgTimer.Interval = 1000;
            msgTimer.Enabled = true;
            msgTimer.Start();
            msgTimer.Tick += new System.EventHandler(this.timer_tick); 
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            newMessageBox.msgTimer.Stop();
            newMessageBox.msgTimer.Dispose();
            Button_id = "1";
            Selected_Text = newMessageBox.cbxSelectOption.SelectedIndex;
            newMessageBox.Dispose(); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            newMessageBox.msgTimer.Stop();
            newMessageBox.msgTimer.Dispose();
            Button_id = "2"; 
            newMessageBox.Dispose();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            disposeFormTimer--;

            if (disposeFormTimer >= 0)
            {
                newMessageBox.lblTimer.Text = disposeFormTimer.ToString();
            }
            else
            {
                Button_id = "2";
                newMessageBox.msgTimer.Stop();
                newMessageBox.msgTimer.Dispose();
                newMessageBox.Dispose();
            }
        }

        private void cbxSelectOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected_Text = cbxSelectOption.SelectedIndex;
        }
    }
}