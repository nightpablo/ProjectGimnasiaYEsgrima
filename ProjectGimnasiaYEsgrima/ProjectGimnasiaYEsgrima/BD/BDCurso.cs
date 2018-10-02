using ProjectGimnasiaYEsgrima.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.BD
{
    public class BDCurso : INterfaceBD<Curso>
    {
        public int Crear(Curso entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(entrada.Deporte).State = System.Data.Entity.EntityState.Modified;
                context.Entry(entrada).State = System.Data.Entity.EntityState.Added;

                context.SaveChanges();
                return 1;
            }
        }

        public int Actualizar(Curso entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(entrada.Deporte).State = System.Data.Entity.EntityState.Modified;
                context.Entry(entrada).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return 1;
            }
        }

        public int Eliminar(Curso entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(context.Cursos.Find(entrada.IdCurso)).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                return 1;
            }
        }

        

        public List<ModelCurso> ListarTodos()
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Cursos.Select(e => new ModelCurso()
                {
                    IdCurso = e.IdCurso,
                    Nombre = e.Nombre,
                    FechaInicio = e.FechaInicio,
                    FechaFin = e.FechaFin,
                    EstadoCurso = e.EstadoCurso,
                    Deporte = e.Deporte,
                    Curso = e
                }).ToList();
            }
        }

        public List<ModelCurso> ListarPorFiltro(params object[] parametros)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                var j = context.Cursos.AsEnumerable()
                .Where(b => b.Nombre.Contains((string)parametros[0]))
                               .ToList();
                var iddep = ((Deporte)parametros[1]).IdDeporte;
                var k = j.Select(e => new ModelCurso()
                {
                    IdCurso = e.IdCurso,
                    Nombre = e.Nombre,
                    FechaInicio = e.FechaInicio,
                    FechaFin = e.FechaFin,
                    Profesores = new List<Profesor>(e.Profesores),
                    EstadoCurso = e.EstadoCurso,
                    Deporte = e.Deporte,
                    Curso = e
                }).ToList();
                return iddep == 0 ? k : k.Where(b => b.Deporte.IdDeporte == iddep).ToList();

            }
        }

        public Curso BuscarPorClavesUnicas(params object[] parametros)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Cursos.AsEnumerable()
                    .FirstOrDefault(b => b.Nombre.Contains((string)parametros[0]));
            }
        }

        public Curso BuscarPorID(int id)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Cursos.Find(id);
            }
        }

        List<Curso> INterfaceBD<Curso>.ListarTodos()
        {
            throw new NotImplementedException();
        }

        List<Curso> INterfaceBD<Curso>.ListarPorFiltro(params object[] parametros)
        {
            throw new NotImplementedException();
        }

        public List<ModelCurso> ListarTodosPorEmpleado(Empleado emp)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                return context.Cursos.AsEnumerable().Where(b=>b.Profesores.Contains((Profesor)emp)).
                    Select(e => new ModelCurso()
                {
                    IdCurso = e.IdCurso,
                    Nombre = e.Nombre,
                    FechaInicio = e.FechaInicio,
                    FechaFin = e.FechaFin,
                    EstadoCurso = e.EstadoCurso,
                    Deporte = e.Deporte,
                    Curso = e
                }).ToList();
            }
        }

        public int AsignarEmpleado(Empleado emp, Curso curso)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Empleados.Attach(emp);
                ((Profesor)emp).Cursos.Add(
                    context.Cursos.AsEnumerable().FirstOrDefault(c=>c.IdCurso==curso.IdCurso)
                    );
                context.SaveChanges();
                return 1;


            }
        }
    }

}



