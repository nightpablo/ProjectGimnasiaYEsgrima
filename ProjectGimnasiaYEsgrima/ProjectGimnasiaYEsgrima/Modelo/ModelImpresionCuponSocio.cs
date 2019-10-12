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
        public string ApellidoSocio { get; set; }
        public int DNISocio { get; set; }
        public DateTime FechaEmision { get; set; }
        public int IdCupon { get; set; }
        public string NombreCategoria { get; set; }
        public double ImporteCategoria { get; set; }

        public ModelImpresionCuponSocio(ModelSocioPersona socio, ModelCuponSocio cuota)
        {
            IdSocio = socio.MiSocio.IdSocio;
            NombreSocio = socio.MiPersona.Nombre;
            ApellidoSocio = socio.MiPersona.Apellido;
            DNISocio = socio.MiPersona.DNI;
            FechaEmision = cuota.MiCuota.FechaEmision;
            IdCupon = cuota.MiCuota.IdCuota;
            if (cuota.MiCategoria != null) { 
                NombreCategoria = cuota.MiCategoria.Nombre;
                ImporteCategoria = cuota.MiCategoria.Costo;
            }
            else
            {
                NombreCategoria = "ADHERENTE";
                ImporteCategoria = cuota.ValorCuotaInicial.Importe;
            }
        }

        
    }
}
