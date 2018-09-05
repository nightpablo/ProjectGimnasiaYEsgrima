using ProjectGimnasiaYEsgrima.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.BD
{
    public class BDPersona : INterfaceBD<Persona>
    {
        public int Actualizar(Persona entrada)
        {
            throw new NotImplementedException();
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

        public List<Persona> ListarPorFiltro(params object[] parametros)
        {
            throw new NotImplementedException();
        }

        public List<Persona> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
