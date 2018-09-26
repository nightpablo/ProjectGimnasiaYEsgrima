using ProjectGimnasiaYEsgrima;
using ProjectGimnasiaYEsgrima.BD;
using ProjectGimnasiaYEsgrima.Modelo;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGimnasiaYEsgrima.Controlador
{
    public class ControladorCurso
    {
        BDCurso BdCurso = new BDCurso();

        public int CrearCurso(string unNombre, DateTime unaFechaInicio, DateTime unaFechaFin, Deporte deporte)
        {
            if (BdCurso.BuscarPorClavesUnicas(unNombre) != null)
                return -2;

            Curso unCurso = new Curso()
            {
                Nombre = unNombre,
                FechaInicio = unaFechaInicio,
               FechaFin = unaFechaFin,
               Deporte = deporte
            };

            BdCurso.Crear(unCurso);

            return 1;
          
        }

        public List<Curso> ListarTodosCursosFiltro(params Object[] parametros)
        {
            if (parametros.Length < 2)
                return null;
            return BdCurso.ListarPorFiltro(parametros);
        }


        public List<Curso> ListarTodosCursos()
        {
            return BdCurso.ListarTodos();
        }

        public int ModificarCurso(int id, string unNombre, DateTime unaFechaInicio, DateTime unaFechaFin, Deporte deporte)
        {
            Curso buscado = BdCurso.BuscarPorClavesUnicas(unNombre);
            if (buscado != null && buscado.IdCurso != id)
                return -2;

            Curso unCurso = new Curso()
            {
                IdCurso = id,
                Nombre = unNombre,
                FechaInicio = unaFechaInicio,
                FechaFin = unaFechaFin,
                Deporte = deporte,
                DeporteIdDeporte = deporte.IdDeporte
            };
            return BdCurso.Actualizar(unCurso);

        }
        
        public int EliminarCurso(Curso unCurso)
        {
            return BdCurso.Eliminar(unCurso);
        }

        public Curso BuscarCursoPorClavesUnicas(params object[] parametros)
        {
            if (parametros.Length == 0) return null;
            return BdCurso.BuscarPorClavesUnicas(parametros);
        }
    }
}
