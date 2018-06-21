using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima
{
    public class Curso
    {
        int id_curso { get; set; }
        string nombre { get; set; }
        DateTime fecha_inicio { get; set; }
        DateTime fecha_fin { get; set; }
        List<Socio> lista_socios { get; set; }
        List<Profesor>lista_profesor { get; set; }

    }
}
