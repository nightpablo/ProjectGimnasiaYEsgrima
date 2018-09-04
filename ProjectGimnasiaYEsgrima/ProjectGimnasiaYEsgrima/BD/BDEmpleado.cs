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
                if(entrada is Profesor)             
                    foreach (var item in ((Profesor)entrada).Deportes)
                        context.Entry(item).State = System.Data.Entity.EntityState.Unchanged;
                    
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
            throw new NotImplementedException();
        }
    }
}
