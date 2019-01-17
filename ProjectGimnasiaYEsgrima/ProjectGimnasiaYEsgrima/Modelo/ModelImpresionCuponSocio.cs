using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.Modelo
{
    public class ModelImpresionCuponSocio
    {
        public int IdSocio { get; set; }
        public string NombreSocio { get; set; }
        public int DNISocio { get; set; }
        public DateTime FechaEmision { get; set; }
        public int IdCupon { get; set; }
        public string NombreCurso { get; set; }
        public double ImporteCurso { get; set; }

        public ModelImpresionCuponSocio(ModelSocioPersona socio, ModelCuponSocio cuota)
        {
            IdSocio = socio.MiSocio.IdSocio;
            NombreSocio = socio.MiPersona.Nombre;
            DNISocio = socio.MiPersona.DNI;
            FechaEmision = cuota.MiCuota.FechaEmision;
            IdCupon = cuota.MiCuota.IdCuota;
            if (cuota.MiCurso != null) { 
                NombreCurso = cuota.MiCurso.Nombre;
                ImporteCurso = cuota.MiCurso.Costo;
            }
            else
            {
                NombreCurso = "ADHERENTE";
                ImporteCurso = cuota.ValorCuotaInicial.Importe;
            }
        }
    }
}
