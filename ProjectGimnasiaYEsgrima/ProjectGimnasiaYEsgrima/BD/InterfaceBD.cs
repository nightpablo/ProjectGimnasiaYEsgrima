using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.BD
{
    public interface INterfaceBD<T>
    {
        int Crear(T entrada);
        int Actualizar(T entrada);
        int Eliminar(T entrada);
        List<T> ListarTodos();
        List<T> ListarPorFiltro(params Object[] parametros);
        T BuscarPorClavesUnicas(params Object[] parametros);
    }
}
