using ProjectGimnasiaYEsgrima.BD;
using ProjectGimnasiaYEsgrima.Modelo;
using System;
using System.Collections.Generic;

namespace ProjectGimnasiaYEsgrima.Controlador
{
    public class ControladorDeporte
    {
        BDDeporte una_bddeporte = new BDDeporte();

        public int CrearDeporte(string nombre, string descripcion) //Falta empezar a generar las condiciones if's para que no fallen
        {
            Deporte UnDeporte = una_bddeporte.BuscarPorClavesUnicas(nombre);
            if (UnDeporte != null && UnDeporte.EstadoDeporte == EnumEstadoDeporte.Baja) {
                UnDeporte.EstadoDeporte = EnumEstadoDeporte.Activo;
                UnDeporte.Descripcion = descripcion;
                una_bddeporte.Actualizar(UnDeporte);
                return -1;
            }
            else if (UnDeporte != null)
                return -2;

            UnDeporte = new Deporte
            {
                Nombre = nombre,
                Descripcion = descripcion,
                EstadoDeporte = EnumEstadoDeporte.Activo
            };
                        
            return una_bddeporte.Crear(UnDeporte);
        }


        public int ModificarDeporte(int id, string nombre, string descripcion) //Falta empezar a generar las condiciones if's para que no fallen
        {
            Deporte buscado = una_bddeporte.BuscarPorClavesUnicas(nombre);
            buscado.Descripcion = descripcion;

            

            return una_bddeporte.Actualizar(buscado);
        }

        public int EliminarDeporte(Deporte deporte)
        {
            Deporte buscado = una_bddeporte.BuscarPorClavesUnicas(deporte.Nombre);
            new BDCategoria().DarBajaPorDeporte(buscado);
            buscado.EstadoDeporte = EnumEstadoDeporte.Baja;
            
            return una_bddeporte.Actualizar(buscado);
            
        }

        public List<ModelDeporte> ListarTodosDeportes()
        {
            return una_bddeporte.ListarTodos();
        }

        public List<ModelDeporte> ListarTodosDeportesPorFiltros(params Object[] parametros)
        {
            if (parametros.Length <= 1)
                return null;
            return una_bddeporte.ListarPorFiltro(parametros);
        }

        public Deporte BuscarDeportePorClavesUnicas(params object[] parametros)
        {
            if (parametros.Length == 0) return null;
            return una_bddeporte.BuscarPorClavesUnicas(parametros);
        }

        public List<ModelDeporte> ListarTodos()
        {
            return una_bddeporte.ListarTodosDeportes();
        }

    }
}
