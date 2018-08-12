using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectGimnasiaYEsgrima.BD
{
    public class ConexionBD
    {
        private const string SERVIDOR_IP = "127.0.0.1";
        private const string DATABASE = "gimesgdb";
        private const string UID = "root";
        private const string PWD = "1234";

        SqlConnection cnn = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=dbGimnasiaYEsgrima;integrated security = true");//User ID=root;Password=1234");
        //MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; database=gimesgdb; Uid=root; pwd=1234;");

        public SqlConnection Open()
        {
            try {
                cnn.Open();
                return cnn;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(null, "Open connection Error [" + ex.Number + "]: " + ex.Message, "SQLSERVER");
                Console.WriteLine("Open connection Error [" + ex.Number + "]: " + ex.Message);
            }

            return null;
        }

        public void Close()
        {
            try
            {
                cnn.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(null, "Close connection Error [" + ex.Number + "]: " + ex.Message, "SQLSERVER");
                Console.WriteLine("Close connection Error [" + ex.Number + "]: " + ex.Message);
            }
        }
    }
}