using ProjectGimnasiaYEsgrima.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.BD
{
    public class BDSocio : InterfaceBD<Socio, ModelSocioPersona>
    {
        public int Actualizar(Socio entrada)
        {
            using(var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(entrada.Persona).State = System.Data.Entity.EntityState.Modified;
                context.Entry(entrada).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return 1;
            }
        }

        public Socio BuscarPorClavesUnicas(params object[] parametros)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Socios.AsEnumerable().FirstOrDefault(b => b.Persona.DNI == (int)parametros[0]);
            }
        }

        public int Crear(Socio entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(entrada.Persona).State = System.Data.Entity.EntityState.Modified;
                context.Entry(entrada).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
                return 1;
            }
        }

        public int Eliminar(Socio entrada)
        {
            throw new NotImplementedException();
        }

        public List<ModelSocioPersona> ListarPorFiltro(params object[] parametros)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                var j = context.Socios
                    .Select(e => new ModelSocioPersona()
                     {
                        Nombre = e.Persona.Nombre,
                        Apellido = e.Persona.Apellido,
                        DNI = e.Persona.DNI,
                        MiSocio = e,
                        MiPersona = e.Persona
                    }).AsEnumerable()
                    .Where(b => b.MiPersona.Nombre.Contains((string)parametros[0]))
                    .Where(b => b.MiPersona.Apellido.Contains((string)parametros[1]))
                    .Where(b => b.MiPersona.DNI.ToString().Contains((string)parametros[2]))
                    .ToList();
                
                return j;
            }
        }

        public List<ModelSocioPersona> ListarTodos()
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                var j = context.Socios
                    .Select(e => new ModelSocioPersona()
                    {
                        Nombre = e.Persona.Nombre,
                        Apellido = e.Persona.Apellido,
                        DNI = e.Persona.DNI,
                        MiSocio = e,
                        MiPersona = e.Persona
                    }).ToList();

                return j;
            }
        }
    }
}
