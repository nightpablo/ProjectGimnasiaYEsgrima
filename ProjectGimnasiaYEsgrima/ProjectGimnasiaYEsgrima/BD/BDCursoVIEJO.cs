using MySql.Data.MySqlClient;
using ProjectGimnasiaYEsgrima;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.BD
{
    public class BDCursoVIEJO : INterfaceBD<Curso>
    {
        private const string INSERT_INTO = "INSERT INTO curso (nombre, fechaInicio, fechaFin) VALUES('{0}',STR_TO_DATE('{1}', '%m/%d/%Y'),STR_TO_DATE('{2}', '%m/%d/%Y'))";

        private const string UPDATE = "UPDATE deporte SET nombre = '{0}', descripcion = '{1}' WHERE iddeporte = '{2}'";
        private const string DELETE = "DELETE FROM deporte WHERE iddeporte = '{0}'";
        private const string SEARCH_ALL = "SELECT * FROM deporte";
        private const string SEARCH_BY_FILTER = "SELECT * FROM deporte WHERE nombre like '%{0}%' AND descripcion like '%{1}%'";
        private const string SEARCH_BY_UNIQUES = SEARCH_ALL + " WHERE nombre = '{0}'";


        public int Actualizar(Curso entrada)
        {
            throw new NotImplementedException();
        }

        public Curso BuscarPorClavesUnicas(params object[] parametros)
        {
            throw new NotImplementedException();
        }

        public int Crear(Curso un_curso)
        {
            var resultado = 0;
            SqlConnection conn = new ConexionBD().Open();
            if (conn != null)
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    INSERT_INTO,
                    un_curso.Nombre, un_curso.FechaInicio, un_curso.FechaFin
                    ), conn);


                resultado = comando.ExecuteNonQuery(); //Ejecutamos el comando a la bd y me retorna un valor distinto a 0 si se ejecuta bien
                conn.Close(); //Cerramos la conexión
            }
            return resultado;
        

        
        }

        public int Eliminar(Curso entrada)
        {
            throw new NotImplementedException();
        }

        public List<Curso> ListarPorFiltro(params object[] parametros)
        {
            throw new NotImplementedException();
        }

        public List<Curso> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
