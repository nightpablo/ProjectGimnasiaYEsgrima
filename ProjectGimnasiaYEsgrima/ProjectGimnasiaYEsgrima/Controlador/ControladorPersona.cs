

using ProjectGimnasiaYEsgrima.BD;
using ProjectGimnasiaYEsgrima.Modelo;

namespace ProjectGimnasiaYEsgrima.Interfaz
{
    public class ControladorPersona
    {
        BDPersona una_bdpersona = new BDPersona();

        public Persona BuscarPersonaPorClavesUnicas(params object[] parametros)
        {
            if (parametros.Length == 0) return null;
            return una_bdpersona.BuscarPorClavesUnicas(parametros);
        }
    }
}