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

        public int CrearCurso(string unNombre,int importe, DateTime unaFechaInicio, DateTime unaFechaFin, Deporte deporte)
        {
            Curso buscado = BdCurso.BuscarPorClavesUnicas(unNombre);
            if (buscado != null && buscado.EstadoCurso == EnumEstadoCurso.Baja) { 
                buscado.EstadoCurso = EnumEstadoCurso.Activo;
                buscado.FechaInicio = unaFechaInicio;
                buscado.FechaFin = unaFechaFin;
                buscado.Costo = importe;
                BdCurso.Actualizar(buscado);
                return -1;
            }
            else if(buscado !=null)
                return -2;

            buscado = new Curso()
            {
                Nombre = unNombre,
                Costo = importe,
                FechaInicio = unaFechaInicio,
               FechaFin = unaFechaFin,
               EstadoCurso = EnumEstadoCurso.Activo,
               Deporte = deporte
            };

            BdCurso.Crear(buscado);

            return 1;
          
        }

        public List<ModelCurso> ListarTodosCursosFiltro(params Object[] parametros)
        {
            if (parametros.Length < 2)
                return null;
            return BdCurso.ListarPorFiltro(parametros);
        }


        public List<ModelCurso> ListarTodosCursos()
        {
            return BdCurso.ListarTodos();
        }

        public List<ModelCurso> ListarTodosCursosDelEmpleado(Empleado emp)
        {
            return BdCurso.ListarTodosPorEmpleado(emp);
        }

        public int ModificarCurso(int id, string unNombre,int importe, DateTime unaFechaInicio, DateTime unaFechaFin, Deporte deporte, EnumEstadoCurso estadoCurso)
        {
            Curso buscado = BdCurso.BuscarPorClavesUnicas(unNombre);

            if (buscado != null)
            {

                buscado.Costo = importe;
                buscado.FechaInicio = unaFechaInicio;
                buscado.FechaFin = unaFechaFin;
                
            }

            return BdCurso.Actualizar(buscado);

        }
        
        public int EliminarCurso(Curso unCurso)
        {
            if(unCurso.EstadoCurso == EnumEstadoCurso.Activo || unCurso.EstadoCurso == EnumEstadoCurso.Pendiente)
                unCurso.EstadoCurso = EnumEstadoCurso.Baja;
            else if (unCurso.EstadoCurso == EnumEstadoCurso.Iniciado)
                unCurso.EstadoCurso = EnumEstadoCurso.Cancelado;


            return BdCurso.Actualizar(unCurso);
            //return BdCurso.Eliminar(unCurso);
        }

        public Curso BuscarCursoPorClavesUnicas(params object[] parametros)
        {
            if (parametros.Length == 0) return null;
            return BdCurso.BuscarPorClavesUnicas(parametros);
        }

        public Curso BuscarCursoPorID(int id)
        {
            return BdCurso.BuscarPorID(id);
        }

        public int AsignarEmpleadoAlCurso(Empleado emp, Curso curso)
        {
            var i = BdCurso.ListarIdProfesores(curso);
            if(i.Contains(emp.IdEmpleado)) return -2;

            return BdCurso.AsignarEmpleado(emp,curso);
        }

        public int EliminarEmpleadoDelCurso(Empleado emp, Curso curso)
        {
            var i = BdCurso.ListarIdProfesores(curso);
            if (!i.Contains(emp.IdEmpleado)) return -2;

            return BdCurso.EliminarEmpleado(emp, curso);
        }

        public int InscribirSocioAlCurso(Socio soc, Curso curso)
        {
            var k = BdCurso.ListarIdSocios(curso);
            if (k.Contains(soc.IdSocio)) return -2;


            BdCurso.InscribirSocio(soc, curso);

            BDSocio bdSocio = new BDSocio();
            var valorcuotainicial = bdSocio.ValorInicialClub();
            var cuota = new CuotaSocio
            {
                FechaEmision = DateTime.Now,
                Estado = EnumEstadoCuotaSocio.NoPagado,
                Importe = curso.Costo,
                ValorCuotaInicial = valorcuotainicial,
                Socio = soc,
                Curso = curso
            };
            bdSocio.CrearCupon(cuota);

            return 1;
        }

        public int UnsuscribirSocioAlCurso(Socio soc, Curso curso)
        {
            var k = BdCurso.ListarIdSocios(curso);
            if (!k.Contains(soc.IdSocio)) return -2;
            BdCurso.UnsuscribirSocio(soc, curso);

            return 1;
        }

        public List<ModelCurso> BuscarCursosTodos()
        {
            return BdCurso.ListarTodosCursos();
        }


    }
}
