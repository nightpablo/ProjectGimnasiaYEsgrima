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
                 var j = context.Cursos.AsEnumerable()
                 .Where(b => b.Nombre.Contains((string)parametros[0]))
                                .ToList();
                var iddep = ((Deporte) parametros[1]).IdDeporte;
                return iddep==0? j : j.Where(b => b.Deporte.IdDeporte == iddep).ToList();

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
    }

}



