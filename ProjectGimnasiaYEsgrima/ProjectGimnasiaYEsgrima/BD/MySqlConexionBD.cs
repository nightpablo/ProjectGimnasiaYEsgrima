using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ProjectGimnasiaYEsgrima.BD
{
    public class MySqlConexionBD
    {
        private const string SERVIDOR_IP = "127.0.0.1";
        private const string DATABASE = "gimesgdb";
        private const string UID = "root";
        private const string PWD = "1234";


        MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; database=gimesgdb; Uid=root; pwd=1234;");

        public MySqlConnection Open()
        {
            try {
                conexion.Open();
                return conexion;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(null, "Open connection Error [" + ex.Number + "]: " + ex.Message, "MySql");
                Console.WriteLine("Open connection Error [" + ex.Number + "]: " + ex.Message);
            }

            return null;
        }

        public void Close()
        {
            try
            {
                conexion.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(null, "Close connection Error [" + ex.Number + "]: " + ex.Message, "MySql");
                Console.WriteLine("Close connection Error [" + ex.Number + "]: " + ex.Message);
            }
        }
    }
}