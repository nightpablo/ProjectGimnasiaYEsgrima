using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.Modelo
{
    public class ModelCategoria
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public EnumEstadoCategoria EstadoCategoria { get; set; }
        public string TextEstadoCategoria { get { return EstadoCategoria.ToString(); } }
        public Categoria MiCategoria { get; set; }
        public double Monto { get; set; }
        public string NombreDeporte { get { return Deporte.Nombre; } }
        public List<Profesor> Profesores { get; set; }
        public Deporte Deporte { get; set; }

        public ModelCategoria()
        {
            Profesores = new List<Profesor>();
        }

    }
}
