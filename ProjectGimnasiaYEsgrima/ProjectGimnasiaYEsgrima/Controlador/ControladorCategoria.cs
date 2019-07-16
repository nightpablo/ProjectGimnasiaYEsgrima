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
    public class ControladorCategoria
    {
        BDCategoria BdCategoria = new BDCategoria();

        public int CrearCategoria(string unNombre,int importe, DateTime unaFechaInicio, DateTime unaFechaFin, Deporte deporte)
        {
            Categoria buscado = BdCategoria.BuscarPorClavesUnicas(unNombre);
            if (buscado != null && buscado.EstadoCategoria == EnumEstadoCategoria.Cancelado) { 
                buscado.EstadoCategoria = EnumEstadoCategoria.Pendiente;
                buscado.FechaInicio = unaFechaInicio;
                buscado.FechaFin = unaFechaFin;
                buscado.Costo = importe;
                BdCategoria.Actualizar(buscado);
                return -1;
            }
            else if(buscado !=null)
                return -2;

            buscado = new Categoria()
            {
                Nombre = unNombre,
                Costo = importe,
                FechaInicio = unaFechaInicio,
               FechaFin = unaFechaFin,
               EstadoCategoria = EnumEstadoCategoria.Pendiente,
               Deporte = deporte
            };

            BdCategoria.Crear(buscado);

            return 1;
          
        }

        public List<ModelCategoria> ListarTodosCategoriasFiltro(params Object[] parametros)
        {
            if (parametros.Length < 2)
                return null;
            return BdCategoria.ListarPorFiltro(parametros);
        }


        public List<ModelCategoria> ListarTodosCategorias()
        {
            return BdCategoria.ListarTodos();
        }

        public List<ModelCategoria> ListarTodosCategoriasDelEmpleado(Empleado emp)
        {
            return BdCategoria.ListarTodosPorEmpleado(emp);
        }

        public int ModificarCategoria(int id, string unNombre,int importe, DateTime unaFechaInicio, DateTime unaFechaFin, Deporte deporte, EnumEstadoCategoria estadoCategoria)
        {
            Categoria buscado = BdCategoria.BuscarPorClavesUnicas(unNombre);

            if (buscado != null)
            {

                buscado.Costo = importe;
                buscado.FechaInicio = unaFechaInicio;
                buscado.FechaFin = unaFechaFin;
                
            }

            return BdCategoria.Actualizar(buscado);

        }
        
        public int EliminarCategoria(Categoria unCategoria)
        {
            if(unCategoria.EstadoCategoria == EnumEstadoCategoria.Iniciado || unCategoria.EstadoCategoria == EnumEstadoCategoria.Pendiente)
                unCategoria.EstadoCategoria = EnumEstadoCategoria.Cancelado;

            return BdCategoria.Actualizar(unCategoria);
        }

        public Categoria BuscarCategoriaPorClavesUnicas(params object[] parametros)
        {
            if (parametros.Length == 0) return null;
            return BdCategoria.BuscarPorClavesUnicas(parametros);
        }

        public Categoria BuscarCategoriaPorID(int id)
        {
            return BdCategoria.BuscarPorID(id);
        }

        public bool ExisteEmpleadoEnCategoria(Empleado emp, Categoria Categoria)
        {
            return BdCategoria.ListarIdProfesores(Categoria).Contains(emp.IdEmpleado);
        }

        public bool ExisteSocioEnCategoria(Socio soc, Categoria Categoria)
        {
            return BdCategoria.ListarIdSocios(Categoria).Contains(soc.IdSocio);
        }

        public int AsignarEmpleadoAlCategoria(Empleado emp, Categoria Categoria)
        {
            var i = BdCategoria.ListarIdProfesores(Categoria);
            if(i.Contains(emp.IdEmpleado)) return -2;

            return BdCategoria.AsignarEmpleado(emp,Categoria);
        }

        public int EliminarEmpleadoDelCategoria(Empleado emp, Categoria Categoria)
        {
            var i = BdCategoria.ListarIdProfesores(Categoria);
            if (!i.Contains(emp.IdEmpleado)) return -2;

            return BdCategoria.EliminarEmpleado(emp, Categoria);
        }

        public int InscribirSocioAlCategoria(Socio soc, Categoria Categoria)
        {
            var k = BdCategoria.ListarIdSocios(Categoria);
            if (k.Contains(soc.IdSocio)) return -2;


            BdCategoria.InscribirSocio(soc, Categoria);

            BDSocio bdSocio = new BDSocio();
            var valorcuotainicial = bdSocio.ValorInicialClub();
            var cuota = new CuotaSocio
            {
                FechaEmision = DateTime.Now,
                Estado = EnumEstadoCuotaSocio.NoPagado,
                Importe = Categoria.Costo,
                ValorCuotaInicial = valorcuotainicial,
                Socio = soc,
                Categoria = Categoria
            };
            bdSocio.CrearCupon(cuota);

            return 1;
        }

        public int UnsuscribirSocioAlCategoria(Socio soc, Categoria Categoria)
        {
            var k = BdCategoria.ListarIdSocios(Categoria);
            if (!k.Contains(soc.IdSocio)) return -2;
            BdCategoria.UnsuscribirSocio(soc, Categoria);

            return 1;
        }

        public List<ModelCategoria> BuscarCategoriasTodos()
        {
            return BdCategoria.ListarTodosCategorias();
        }


    }
}
