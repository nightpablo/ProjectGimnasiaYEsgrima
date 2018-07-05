using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProjectGimnasiaYEsgrima.BD;

namespace ProjectGimnasiaYEsgrima
{
    public class BDDeporte
    {
        private const string NOMBRE_TABLA = "deporte";
        private const string ID_DEPORTE = "iddeporte";
        private const string NOMBRE = "nombre";
        private const string DESCRIPCION = "descripcion";

        public int Crear(Deporte un_deporte)
        {
            var resultado = 0;
            MySqlConexionBD conexion = new MySqlConexionBD();
            MySqlCommand comando = new MySqlCommand(string.Format(
                "INSERT INTO '{0}' ('{1}', '{2}') VALUES('{3}','{4}')", 
                NOMBRE_TABLA , NOMBRE, DESCRIPCION , un_deporte.Nombre, un_deporte.Descripcion
                ), conexion.Open()); //Comando Query y a la vez abrimos la conexión

            resultado = comando.ExecuteNonQuery(); //Ejecutamos el comando a la bd y me retorna un valor distinto a 0 si se ejecuta bien
            conexion.Close(); //Cerramos la conexión
            return resultado;
        }

    }
}
