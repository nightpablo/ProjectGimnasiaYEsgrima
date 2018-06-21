using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima
{
    public class Deporte
    {
        public Deporte(string nombre, string descripcion)
        {
            this.id_deporte = id_deporte;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public int id_deporte { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
    }

}
