using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima
{
    public class Deporte
    {
        public Deporte() { }
        public Deporte(int id_deporte, string nombre, string descripcion)
        {
            this.Id_deporte = id_deporte;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public int Id_deporte { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }

}
