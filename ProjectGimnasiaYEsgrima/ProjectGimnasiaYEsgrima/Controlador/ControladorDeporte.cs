using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima
{
    public class ControladorDeporte
    {
        BDDeporte una_bddeporte = new BDDeporte();

        public int CrearDeporte(string nombre, string descripcion) //Falta empezar a generar las condiciones if's para que no fallen
        {
            if (una_bddeporte.BuscarPorClavesUnicas(nombre) != null)
                return -2;

            Deporte un_deporte = new Deporte
            {
                Nombre = nombre,
                Descripcion = descripcion
            };



            
            return una_bddeporte.Crear(un_deporte);
        }

        public int ModificarDeporte(int id, string nombre, string descripcion) //Falta empezar a generar las condiciones if's para que no fallen
        {
            Deporte buscado = una_bddeporte.BuscarPorClavesUnicas(nombre);
            if ( buscado != null && buscado.Id_deporte!=id)
                return -2;

            Deporte un_deporte = new Deporte
            {
                Id_deporte = id,
                Nombre = nombre,
                Descripcion = descripcion
            };

            return una_bddeporte.Actualizar(un_deporte);
        }

        public int EliminarDeporte(Deporte deporte)
        {
            return una_bddeporte.Eliminar(deporte);
        }

        public List<Deporte> ListarTodosDeportes()
        {
            return una_bddeporte.ListarTodos();
        }

        public List<Deporte> ListarTodosDeportesPorFiltros(params Object[] parametros)
        {
            if (parametros.Length <= 1) return null;
            return una_bddeporte.ListarPorFiltro(parametros);
        }

        public Deporte BuscarDeportePorClavesUnicas(params object[] parametros)
        {
            if (parametros.Length == 0) return null;
            return una_bddeporte.BuscarPorClavesUnicas(parametros);
        }

    }
}
