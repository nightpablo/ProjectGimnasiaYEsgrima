using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.Modelo
{
    public class ModelCurso
    {
        public int IdCurso { get; set; }
        public string Nombre { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public EnumEstadoCurso EstadoCurso { get; set; }
        public string TextEstadoCurso{ get { return EstadoCurso.ToString(); } }
        public Curso Curso { get; set; }
        public double Monto { get; set; }
        public string NombreDeporte { get { return Deporte.Nombre; } }
        public List<Profesor> Profesores { get; set; }
        public Deporte Deporte { get; set; }

        public ModelCurso()
        {
            Profesores = new List<Profesor>();
        }

    }
}
