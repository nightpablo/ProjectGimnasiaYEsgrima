using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima
{
    public class Profesor : Empleado
    {
        public int id_profesor { get; set; }
        public string descripcion { get; set; }
        public List<Deporte> lista_deportes_dictados { get; set; }
        

    }
}
