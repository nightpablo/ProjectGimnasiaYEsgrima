using ProjectGimnasiaYEsgrima.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.BD
{
    public class BDEmpleado : InterfaceBD<Empleado>
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
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Empleados.AsEnumerable().FirstOrDefault(b => b.Persona.DNI == (int)parametros[0]);
            }
        }
        public int Crear(Empleado entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(entrada.Persona).State = System.Data.Entity.EntityState.Modified;
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
                return context.Empleados
                    .AsEnumerable()
                    .Where(b=>b.EstadoEmpleado!=EnumEstadoEmpleado.Baja)
                    .Select(e => new ModelEmpleadoPersona()
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

        public List<ModelEmpleadoPersona> ListarEmpleadosPersonas(params object[] parametros)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                var j = context.Empleados
                    .Select(e => new ModelEmpleadoPersona()
                {
                    Nombre = e.Persona.Nombre,
                    Apellido = e.Persona.Apellido,
                    DNI = e.Persona.DNI,
                    TipoEmpleado = e.TipoEmpleado,
                    MiEmpleado = e,
                    MiPersona = e.Persona
                }).AsEnumerable()
                    .Where(b => b.MiPersona.Nombre.Contains((string)parametros[0]))
                    .Where(b => b.MiPersona.Apellido.Contains((string)parametros[1]))
                    .Where(b => b.MiPersona.DNI.ToString().Contains((string)parametros[2]))
                    .Where(b => b.MiEmpleado.EstadoEmpleado != EnumEstadoEmpleado.Baja)
                    .ToList();
                var tipoemp = Convert.ToInt32(parametros[3]);
                return tipoemp==0? j : j.Where(b => (int)b.TipoEmpleado == tipoemp).ToList();
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

        public bool existeEmpleado(Empleado emp, Persona pers)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                var i = context.Empleados.AsEnumerable().FirstOrDefault(b => b.Persona.DNI.Equals(pers.DNI) && b.TipoEmpleado.Equals(emp.TipoEmpleado));

                return i!=null;
            }
        }
    }

}

