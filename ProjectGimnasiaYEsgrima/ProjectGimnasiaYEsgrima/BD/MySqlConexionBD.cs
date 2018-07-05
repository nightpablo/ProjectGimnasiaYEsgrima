using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.BD
{
    public class MySqlConexionBD
    {
        MySqlConnection conexion = new MySqlConnection("server=127.0.0.1; database=gimesgdb; Uid=root; pwd=1234;");

        public MySqlConnection Open()
        {
            try {
                conexion.Open();
                return conexion;
            }
            catch (MySqlException ex)
            {
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
                Console.WriteLine("Close connection Error [" + ex.Number + "]: " + ex.Message);
            }
        }
    }
}