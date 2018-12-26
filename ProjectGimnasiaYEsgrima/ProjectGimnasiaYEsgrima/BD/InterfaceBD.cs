using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.BD
{
    public interface InterfaceBD<T,K>
    {
        int Crear(T entrada);
        int Actualizar(T entrada);
        int Eliminar(T entrada);
        List<K> ListarTodos();
        List<K> ListarPorFiltro(params Object[] parametros);
        T BuscarPorClavesUnicas(params Object[] parametros);
    }
}
