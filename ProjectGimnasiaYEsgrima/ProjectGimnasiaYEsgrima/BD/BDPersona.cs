using ProjectGimnasiaYEsgrima.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.BD
{
    public class BDPersona : InterfaceBD<Persona,ModelPersona>
    {
        public int Actualizar(Persona entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(entrada).State = System.Data.Entity.EntityState.Modified;
                return context.SaveChanges();
            }
        }

        public Persona BuscarPorClavesUnicas(params object[] parametros)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Personas.AsEnumerable()
                    .FirstOrDefault(b => b.DNI==(int)parametros[0]);
            }
        }

        public int Crear(Persona entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                //context.Empleados.Add(entrada);
                context.Entry(entrada).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
                return 1;
            }
        }

        public int Eliminar(Persona entrada)
        {
            throw new NotImplementedException();
        }

        public List<ModelPersona> ListarPorFiltro(params object[] parametros)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Personas
                    .AsEnumerable()
                    .Select(b => new ModelPersona() { })
                    .ToList();
            }
        }

        public List<ModelPersona> ListarTodos()
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Personas
                    .AsEnumerable()
                    .Select(b=>new ModelPersona() { })
                    .ToList();
            }
        }
    }
}
