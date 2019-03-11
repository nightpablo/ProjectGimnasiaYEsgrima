using ProjectGimnasiaYEsgrima.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectGimnasiaYEsgrima.BD
{
    public class BDCategoria : InterfaceBD<Categoria,ModelCategoria>
    {
        public int Crear(Categoria entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(entrada.Deporte).State = System.Data.Entity.EntityState.Modified;
                context.Entry(entrada).State = System.Data.Entity.EntityState.Added;

                context.SaveChanges();
                return 1;
            }
        }

        public int Actualizar(Categoria entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(entrada).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return 1;
            }
        }

        public int Eliminar(Categoria entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(context.Categorias.Find(entrada.IdCategoria)).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
                return 1;
            }
        }

        

        public List<ModelCategoria> ListarTodos()
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Categorias
                    .AsEnumerable()
                    .Where(b=>b.EstadoCategoria != EnumEstadoCategoria.Baja)
                    .Where(b => b.EstadoCategoria != EnumEstadoCategoria.Cancelado)
                    .Where(b => b.EstadoCategoria != EnumEstadoCategoria.Terminado)
                    .Select(e => new ModelCategoria()
                {
                    IdCategoria = e.IdCategoria,
                    Nombre = e.Nombre,
                    FechaInicio = e.FechaInicio,
                    FechaFin = e.FechaFin,
                    EstadoCategoria = e.EstadoCategoria,
                    Monto = e.Costo,
                    Deporte = e.Deporte,
                    MiCategoria = e
                })
                .ToList();
            }
        }

        public List<ModelCategoria> ListarPorFiltro(params object[] parametros)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                var j = context.Categorias.AsEnumerable()
                .Where(b => b.Nombre.Contains((string)parametros[0]))
                               .ToList();
                var iddep = 0;
                if (parametros[1]!=null)
                    iddep = ((Deporte)parametros[1]).IdDeporte;
                var k = j
                    .AsEnumerable()
                    .Where(b => b.EstadoCategoria != EnumEstadoCategoria.Baja)
                    .Where(b => b.EstadoCategoria != EnumEstadoCategoria.Cancelado)
                    .Where(b => b.EstadoCategoria != EnumEstadoCategoria.Terminado)
                    .Select(e => new ModelCategoria()
                {
                    IdCategoria = e.IdCategoria,
                    Nombre = e.Nombre,
                    FechaInicio = e.FechaInicio,
                    FechaFin = e.FechaFin,
                    Profesores = new List<Profesor>(e.Profesores),
                    EstadoCategoria = e.EstadoCategoria,
                    Monto = e.Costo,
                    Deporte = e.Deporte,
                        MiCategoria = e
                }).ToList();
                return iddep == 0 ? k : k.Where(b => b.Deporte.IdDeporte == iddep).ToList();

            }
        }

        public Categoria BuscarPorClavesUnicas(params object[] parametros)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Categorias.AsEnumerable()
                    .FirstOrDefault(b => b.Nombre.Contains((string)parametros[0]));
            }
        }

        public Categoria BuscarPorID(int id)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Categorias.Find(id);
            }
        }

        public List<ModelCategoria> ListarTodosPorEmpleado(Empleado emp)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                return context.Categorias.AsEnumerable().Where(b=>b.Profesores.Contains((Profesor)emp))
                    .AsEnumerable()
                    .Where(b => b.EstadoCategoria != EnumEstadoCategoria.Baja)
                    .Where(b => b.EstadoCategoria != EnumEstadoCategoria.Cancelado)
                    .Where(b => b.EstadoCategoria != EnumEstadoCategoria.Terminado)
                    .Select(e => new ModelCategoria()
                {
                    IdCategoria = e.IdCategoria,
                    Nombre = e.Nombre,
                    FechaInicio = e.FechaInicio,
                    FechaFin = e.FechaFin,
                    EstadoCategoria = e.EstadoCategoria,
                    Monto = e.Costo,
                    Deporte = e.Deporte,
                        MiCategoria = e
                }).ToList();
            }
        }

        public int AsignarEmpleado(Empleado emp, Categoria Categoria)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Empleados.Attach(emp);
                ((Profesor)emp).Categorias.Add(
                    context.Categorias.AsEnumerable().FirstOrDefault(c=>c.IdCategoria==Categoria.IdCategoria)
                    );
                context.SaveChanges();
                return 1;


            }
        }
        

        public int EliminarEmpleado(Empleado emp, Categoria Categoria)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Empleados.Attach(emp);
                ((Profesor)emp).Categorias.Remove(
                    context.Categorias.AsEnumerable().FirstOrDefault(c => c.IdCategoria == Categoria.IdCategoria)
                    );
                context.SaveChanges();
                return 1;


            }
        }

        public int InscribirSocio(Socio soc, Categoria Categoria)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Socios.Attach(soc);
                soc.Categorias.Add(
                    context.Categorias.AsEnumerable().FirstOrDefault(c => c.IdCategoria == Categoria.IdCategoria)
                    );
                context.SaveChanges();
                return 1;


            }
        }


        public int UnsuscribirSocio(Socio soc, Categoria Categoria)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Socios.Attach(soc);
                soc.Categorias.Remove(
                    context.Categorias.AsEnumerable().FirstOrDefault(c => c.IdCategoria == Categoria.IdCategoria)
                    );
                context.SaveChanges();
                return 1;


            }
        }

        public List<int> ListarIdProfesores(Categoria Categoria)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {

                Categoria buscado = context.Categorias.AsEnumerable().FirstOrDefault(b => b.IdCategoria==Categoria.IdCategoria);
                return buscado.Profesores.AsEnumerable().Select(b => b.IdEmpleado).ToList();

                }
        }

        public List<int> ListarIdSocios(Categoria Categoria)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {

                Categoria buscado = context.Categorias.AsEnumerable().FirstOrDefault(b => b.IdCategoria == Categoria.IdCategoria);
                return buscado.Socios.AsEnumerable().Select(b => b.IdSocio).ToList();

            }
        }

        public int DarBajaPorDeporte(Deporte deporte)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                List<Categoria> Categorias = context.Categorias.AsEnumerable()
                    .Where(b => b.Deporte.IdDeporte == deporte.IdDeporte)
                    .Where(b => b.EstadoCategoria != EnumEstadoCategoria.Baja)
                    .Where(b => b.EstadoCategoria != EnumEstadoCategoria.Cancelado)
                    .Where(b => b.EstadoCategoria != EnumEstadoCategoria.Terminado)
                    .ToList();

                foreach (var i in Categorias)
                {
                    if (i.EstadoCategoria == EnumEstadoCategoria.Activo || i.EstadoCategoria == EnumEstadoCategoria.Pendiente)
                        i.EstadoCategoria = EnumEstadoCategoria.Baja;
                    else
                        i.EstadoCategoria = EnumEstadoCategoria.Cancelado;
                    context.Entry(i).State = System.Data.Entity.EntityState.Modified;

                }
                context.SaveChanges();
                return 1;
            }
        }

        public List<ModelCategoria> ListarTodosCategorias()
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Categorias
                    .AsEnumerable()
                     .Select(e => new ModelCategoria()
                    {
                        IdCategoria = e.IdCategoria,
                        Nombre = e.Nombre,
                        FechaInicio = e.FechaInicio,
                        FechaFin = e.FechaFin,
                        EstadoCategoria = e.EstadoCategoria,
                        Monto = e.Costo,
                        Deporte = e.Deporte,
                         MiCategoria = e
                    })
                .ToList();
            }
        }
    }

}



