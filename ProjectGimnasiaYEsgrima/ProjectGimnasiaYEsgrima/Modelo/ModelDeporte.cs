using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.Modelo
{
    public class ModelDeporte
    {
        public int IdDeporte { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public EnumEstadoDeporte EstadoDeporte { get; set; }
        public string TextEstadoDeporte{ get { return EstadoDeporte.ToString(); } }
        public Deporte MiDeporte { get; set; }

        public ModelDeporte(){}
    }
}
