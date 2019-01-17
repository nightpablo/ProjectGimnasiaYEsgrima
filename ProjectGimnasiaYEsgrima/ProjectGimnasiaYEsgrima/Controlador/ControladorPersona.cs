

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

        public int ActualizarFotoPersona(int documento, byte[] foto)
        {
            Persona buscado = BuscarPersonaPorClavesUnicas(documento);
            buscado.Foto = foto;
            return una_bdpersona.Actualizar(buscado);
        }
    }
}