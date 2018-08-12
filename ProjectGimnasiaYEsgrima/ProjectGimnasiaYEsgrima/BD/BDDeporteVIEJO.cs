using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProjectGimnasiaYEsgrima.BD;
using ProjectGimnasiaYEsgrima;

namespace ProjectGimnasiaYEsgrima
{
    public class BDDeporteVIEJO : INterfaceBD<Deporte>
    {
        private const string INSERT_INTO = "INSERT INTO deporte (nombre, descripcion) VALUES('{0}','{1}')";
        private const string UPDATE = "UPDATE deporte SET nombre = '{0}', descripcion = '{1}' WHERE iddeporte = '{2}'";
        private const string DELETE = "DELETE FROM deporte WHERE iddeporte = '{0}'";
        private const string SEARCH_ALL = "SELECT * FROM deporte";
        private const string SEARCH_BY_FILTER = "SELECT * FROM deporte WHERE nombre like '%{0}%' AND descripcion like '%{1}%'";
        private const string SEARCH_BY_UNIQUES = SEARCH_ALL + " WHERE nombre = '{0}'";

        public int Crear(Deporte un_deporte)
        {
            var resultado = 0;
            SqlConnection conn = new ConexionBD().Open();
            if (conn != null)
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    INSERT_INTO,
                    un_deporte.Nombre, un_deporte.Descripcion
                    ), conn); 


                resultado = comando.ExecuteNonQuery(); //Ejecutamos el comando a la bd y me retorna un valor distinto a 0 si se ejecuta bien
                conn.Close(); //Cerramos la conexión
            }
            return resultado;
        }

        public int Actualizar(Deporte un_deporte)
        {
            var resultado = 0;
            SqlConnection conn = new ConexionBD().Open();
            if (conn != null)
            {
                SqlCommand comando = new SqlCommand(string.Format(
                UPDATE,
                un_deporte.Nombre, un_deporte.Descripcion, un_deporte.Iddeporte
                ), conn); 


                resultado = comando.ExecuteNonQuery(); //Ejecutamos el comando a la bd y me retorna un valor distinto a 0 si se ejecuta bien
                conn.Close(); //Cerramos la conexión
            }
            return resultado;
        }

        public int Eliminar(Deporte un_deporte)
        {
            var resultado = 0;
            SqlConnection conn = new ConexionBD().Open();
            if (conn != null)
            {
                SqlCommand comando = new SqlCommand(string.Format(
                DELETE,
                un_deporte.Iddeporte
                ), conn); 


                resultado = comando.ExecuteNonQuery(); //Ejecutamos el comando a la bd y me retorna un valor distinto a 0 si se ejecuta bien
                conn.Close(); //Cerramos la conexión
            }
            return resultado;
        }

        public List<Deporte> ListarTodos()
        {
            List<Deporte> lista = null;
            SqlConnection conn = new ConexionBD().Open();
            if (conn != null)
            {
                SqlCommand comando = new SqlCommand(SEARCH_ALL, conn);
                SqlDataReader myReader = comando.ExecuteReader();
                lista = new List<Deporte>();
                while (myReader.Read())
                {
                    lista.Add(new Deporte() { Iddeporte = myReader.GetInt32(0), Nombre = myReader.GetString(1), Descripcion = myReader.GetString(2) });
                }
                conn.Close();
            }
            return lista;
        }

        public List<Deporte> ListarPorFiltro(params Object[] parametros)
        {
            List<Deporte> lista = null;
            SqlConnection conn = new ConexionBD().Open();
            if (conn != null)
            {
                string nombre = (string)parametros[0];
                string descripcion = (string)parametros[1];
                SqlCommand comando = new SqlCommand(string.Format(SEARCH_BY_FILTER, nombre, descripcion), conn);
                SqlDataReader myReader = comando.ExecuteReader();
                lista = new List<Deporte>();
                while (myReader.Read())
                {
                    lista.Add(new Deporte() { Iddeporte = myReader.GetInt32(0), Nombre = myReader.GetString(1), Descripcion = myReader.GetString(2) });
                }
                conn.Close();
            }
            return lista;
        }

        public Deporte BuscarPorClavesUnicas(params object[] parametros)
        {
            Deporte deporte = null;
            SqlConnection conn = new ConexionBD().Open();
            if (conn != null)
            {
                string nombre = (string)parametros[0];
                SqlCommand comando = new SqlCommand(string.Format(SEARCH_BY_UNIQUES, nombre), conn);
                SqlDataReader myReader = comando.ExecuteReader();
                if (myReader.Read())
                    deporte = new Deporte() { Iddeporte = myReader.GetInt32(0), Nombre = myReader.GetString(1), Descripcion = myReader.GetString(2) };
                conn.Close();
            }
            return deporte;
        }
    }
}
