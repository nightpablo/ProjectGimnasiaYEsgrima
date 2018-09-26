using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectGimnasiaYEsgrima.Modelo;


namespace ProjectGimnasiaYEsgrima.BD
{
    public class BDDeporte : INterfaceBD<Deporte>
    {

        public int Crear(Deporte entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                
                context.Deportes.Add(entrada);
                context.SaveChanges();
                return 1;
            }
        }
        
        public int Actualizar(Deporte entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                //var un_deporte = context.Deportes.Find(entrada.IdDeporte);
                // un_deporte.Nombre = entrada.Nombre;
                //un_deporte.Descripcion = entrada.Descripcion;
                context.Entry(entrada).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return 1;
            }
        }

        public int Eliminar(Deporte entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                var un_deporte = context.Deportes.Find(entrada.IdDeporte);
                context.Deportes.Remove(un_deporte);
                context.SaveChanges();
                return 1;
            }
        }
        
        public List<Deporte> ListarTodos()
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Deportes.ToList();
            }
        }

        public List<Deporte> ListarPorFiltro(params object[] parametros)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Deportes.AsEnumerable()
                    .Where(b => b.Nombre.Contains((string)parametros[0]))
                    .Where(b => b.Descripcion.Contains((string)parametros[1]))
                    .ToList();
            }
        }

        public Deporte BuscarPorClavesUnicas(params object[] parametros)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Deportes.AsEnumerable()
                    .FirstOrDefault(b => b.Nombre.Contains((string)parametros[0]));
            }
        }

        public Deporte BuscarPorId(int id)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                Deporte d = context.Deportes.Find(id);
                context.Entry(d).State = System.Data.Entity.EntityState.Unchanged;
                return d;
            }
        }
    }
}
