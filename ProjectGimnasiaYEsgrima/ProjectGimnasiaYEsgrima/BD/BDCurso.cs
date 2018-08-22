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
                context.Entry(entrada).State = System.Data.Entity.EntityState.Added;
                //context.Cursos.Add(entrada);
                context.SaveChanges();
                return 1;
                throw new NotImplementedException();
            }
        }

        public int Actualizar(Curso entrada)
        {
            //var unCurso = context.Cursos.Find(entrada.IdCurso);
            //unCurso.Nombre = entrada.Nombre;
            // unCurso
            using (var context = new DiagramasDeTablasContainer1())
            {
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

        public List<Curso> ListarTodos()
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Cursos.ToList();
            }
        }

        public List<Curso> ListarPorFiltro(params object[] parametros)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                //return context.Cursos.ToList();
                 var j = context.Cursos.AsEnumerable()
                 .Where(b => b.Nombre.Contains((string)parametros[0]))
                                .ToList();
                var iddep = Convert.ToInt32(parametros[1]);
                return iddep==0? j : j.Where(b => b.DeporteIdDeporte == iddep).ToList();

            }
            /* return context.Cursos.AsEnumerable()
                 .Where(b => (b.Deporte.IdDeporte) == Convert.ToInt32(parametros[0])).ToList();

             return context.Cursos.AsEnumerable()
                 .Where(b => b.Nombre.Contains((string)parametros[1]))
                                .ToList();*/
        }

        public Curso BuscarPorClavesUnicas(params object[] parametros)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Cursos.AsEnumerable()
                    .FirstOrDefault(b => b.Nombre.Contains((string)parametros[0]));
            }
        }
    }

}



