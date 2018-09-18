using ProjectGimnasiaYEsgrima.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.BD
{
    public class BDEmpleado : INterfaceBD<Empleado>
    {
        public int Actualizar(Empleado entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(entrada.Persona).State = System.Data.Entity.EntityState.Modified;
                context.Entry(entrada).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return 1;
            }
        }

        public Empleado BuscarPorClavesUnicas(params object[] parametros)
        {
            throw new NotImplementedException();
        }

        public int Crear(Empleado entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(entrada).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
                return 1;
            }
        }

        public int Eliminar(Empleado entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(context.Empleados.Find(entrada.IdEmpleado)).State = System.Data.Entity.EntityState.Deleted;

                context.SaveChanges();
                return 1;
            }
        }

        public List<Empleado> ListarTodos()
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Empleados.ToList();
            }
        }

        public List<ModelEmpleadoPersona> ListarEmpleadosPersonas()
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Empleados.Select(e => new ModelEmpleadoPersona()
                {
                    Nombre = e.Persona.Nombre,
                    Apellido = e.Persona.Apellido,
                    DNI = e.Persona.DNI,
                    TipoEmpleado = e.TipoEmpleado,
                    MiEmpleado = e,
                    MiPersona = e.Persona
                }).ToList();
            }
        }


        public List<Empleado> ListarPorFiltro(params object[] parametros)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                //return context.Cursos.ToList();
                var i = context.Empleados.AsEnumerable()
                .Where(b => b.Persona.Nombre.Contains((string)parametros[0]))
                               .ToList();
                /* var j = context.Empleados.AsEnumerable()
                 .Where(b => b.Persona.Apellido.Contains((string)parametros[1]))
                                .ToList();*/
                //var iddep = Convert.ToInt32(parametros[2]);

                return i; //ddep == 0 ? i : i.Where(b => b.Persona.IdPersona == iddep).ToList();

            }
        }
    }

}

