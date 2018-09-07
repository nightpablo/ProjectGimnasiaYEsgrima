using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.Modelo
{
    public class ModelEmpleadoPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public EnumTipoEmpleado TipoEmpleado { get; set; }
        public Empleado MiEmpleado { get; set; }
        public ModelEmpleadoPersona() { }
        public ModelEmpleadoPersona(Empleado entry)
        {
            MiEmpleado = entry;
            Nombre = entry.Persona.Nombre;
            Apellido = entry.Persona.Apellido;
            DNI = entry.Persona.DNI;
            TipoEmpleado = entry.TipoEmpleado;
        }
    }
}
