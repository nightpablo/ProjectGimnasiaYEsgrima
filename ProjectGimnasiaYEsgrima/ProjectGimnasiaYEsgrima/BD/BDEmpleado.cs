using ProjectGimnasiaYEsgrima.Modelo;
using System;
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
            throw new NotImplementedException();
        }

        public Empleado BuscarPorClavesUnicas(params object[] parametros)
        {
            throw new NotImplementedException();
        }

        public int Crear(Empleado entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Empleados.Add(entrada);
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
            throw new NotImplementedException();
        }
    }
}
