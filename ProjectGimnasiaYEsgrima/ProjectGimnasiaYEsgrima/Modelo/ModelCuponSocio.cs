using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.Modelo
{
    public class ModelCuponSocio
    {
        public int IdCuota { get; set; }
        public System.DateTime FechaEmision { get; set; }
        public System.DateTime? FechaCobro { get; set; }
        public double Importe { get; set; }
        public EnumEstadoCuotaSocio Estado { get; set; }
        public string NombreCurso { get; set; }

        public ValorCuotaInicial ValorCuotaInicial { get; set; }
        public Socio MiSocio { get; set; }
        public CuotaSocio MiCuota { get; set; }
        public Curso MiCurso { get; set; }


        public ModelCuponSocio(){}

        public int NumeroMesEmision()
        {
            switch (FechaEmision.ToString("MMM"))
            {
                case "Jan":
                    return 1;
                case "Feb":
                    return 2;
                case "Mar":
                    return 3;
                case "Apr":
                    return 4;
                case "May":
                    return 5;
                case "Jun":
                    return 6;
                case "Jul":
                    return 7;
                case "Aug":
                    return 8;
                case "Sep":
                    return 9;
                case "Oct":
                    return 10;
                case "Nov":
                    return 11;
                case "Dec":
                    return 12;
                default:
                    return 0;

            }
        }
    }
}
