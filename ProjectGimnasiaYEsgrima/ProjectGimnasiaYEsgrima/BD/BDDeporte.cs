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
        private const string INSERT_INTO = "INSERT INTO deporte (nombre, descripcion) VALUES('{0}','{1}')";
        private const string UPDATE = "UPDATE deporte SET nombre = '{0}', descripcion = '{1}' WHERE iddeporte = '{2}'";
        private const string DELETE = "DELETE FROM deporte WHERE iddeporte = '{0}'";
        private const string SEARCH_ALL = "SELECT * FROM deporte";
        private const string SEARCH_BY_FILTER = "SELECT * FROM deporte WHERE nombre like '%{0}%' AND descripcion like '%{1}%'";
        //          private const string SEARCH_BY_NAME = SEARCH_ALL + " WHERE iddeporte = '{0}'";

        public int Crear(Deporte un_deporte)
        {
            var resultado = 0;
            MySqlConexionBD conexion = new MySqlConexionBD();
            MySqlCommand comando = new MySqlCommand(string.Format(
                INSERT_INTO, 
                un_deporte.Nombre, un_deporte.Descripcion
                ), conexion.Open()); //Comando Query y a la vez abrimos la conexión

            
            resultado = comando.ExecuteNonQuery(); //Ejecutamos el comando a la bd y me retorna un valor distinto a 0 si se ejecuta bien
            conexion.Close(); //Cerramos la conexión
            return resultado;
        }

        public int Actualizar(Deporte un_deporte)
        {
            var resultado = 0;
            MySqlConexionBD conexion = new MySqlConexionBD();
            MySqlCommand comando = new MySqlCommand(string.Format(
                UPDATE,
                un_deporte.Nombre, un_deporte.Descripcion, un_deporte.Id_deporte
                ), conexion.Open()); //Comando Query y a la vez abrimos la conexión


            resultado = comando.ExecuteNonQuery(); //Ejecutamos el comando a la bd y me retorna un valor distinto a 0 si se ejecuta bien
            conexion.Close(); //Cerramos la conexión
            return resultado;
        }

        public int Eliminar(Deporte un_deporte)
        {
            var resultado = 0;
            MySqlConexionBD conexion = new MySqlConexionBD();
            MySqlCommand comando = new MySqlCommand(string.Format(
                DELETE,
                un_deporte.Id_deporte
                ), conexion.Open()); //Comando Query y a la vez abrimos la conexión


            resultado = comando.ExecuteNonQuery(); //Ejecutamos el comando a la bd y me retorna un valor distinto a 0 si se ejecuta bien
            conexion.Close(); //Cerramos la conexión
            return resultado;
        }

        public List<Deporte> ListarTodos()
        {
            List<Deporte> lista = null;
            MySqlConexionBD conexion = new MySqlConexionBD();
            MySqlCommand comando = new MySqlCommand(SEARCH_ALL, conexion.Open());
            MySqlDataReader myReader = comando.ExecuteReader();
            lista = new List<Deporte>();
            while (myReader.Read())
            {
                lista.Add(new Deporte() { Id_deporte = myReader.GetInt32(0), Nombre = myReader.GetString(1), Descripcion = myReader.GetString(2) });
            }
            conexion.Close();
            return lista;
        }

        public List<Deporte> ListarPorFiltro(string nombre, string descripcion)
        {
            List<Deporte> lista = null;
            MySqlConexionBD conexion = new MySqlConexionBD();
            MySqlCommand comando = new MySqlCommand(string.Format(SEARCH_BY_FILTER,nombre,descripcion), conexion.Open());
            MySqlDataReader myReader = comando.ExecuteReader();
            lista = new List<Deporte>();
            while (myReader.Read())
            {
                lista.Add(new Deporte() { Id_deporte = myReader.GetInt32(0), Nombre = myReader.GetString(1), Descripcion = myReader.GetString(2) });
            }
            conexion.Close();
            return lista;
        }


    }
}
