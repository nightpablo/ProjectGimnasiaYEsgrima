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
            throw new NotImplementedException();
        }

        public List<Empleado> ListarPorFiltro(params object[] parametros)
        {
            throw new NotImplementedException();
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
                    MiEmpleado = e
                }).ToList();
            }
        }
    }
}
