using ProjectGimnasiaYEsgrima;
using ProjectGimnasiaYEsgrima.BD;
using ProjectGimnasiaYEsgrima.Modelo;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGimnasiaYEsgrima.Controlador
{
    public class ControladorCurso
    {
        public int CrearCurso(string unNombre, string unaFechaInicio, string unaFechaFin)
        {
            Curso unCurso = new Curso()
            {
                Nombre = unNombre,
                //FechaInicio = unaFechaInicio,
                //FechaFin = unaFechaFin

            };

            /*BDCurso una_BD_curso = new BDCurso();

            una_BD_curso.Crear(unCurso);*/

            return 1;
        }
    }
}
