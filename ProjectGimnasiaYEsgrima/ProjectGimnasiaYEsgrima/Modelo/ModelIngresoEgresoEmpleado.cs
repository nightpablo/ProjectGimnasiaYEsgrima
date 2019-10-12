using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.Modelo
{
    public class ModelIngresoEgresoEmpleado
    {
        public RegistroIngresoEgreso Registro { get; set; }
        public String NombreEmpleado { get { return Registro.Empleado.Persona.Nombre; } }
        public String ApellidoEmpleado { get { return Registro.Empleado.Persona.Apellido; } }
        public System.DateTime Fecha { get { return Registro.Fecha; } }
        public System.DateTime HoraIngreso { get { return Registro.HoraIngreso; } }
        public System.DateTime? HoraEgreso { get { return Registro.HoraEgreso; } }

        public ModelIngresoEgresoEmpleado() { }

    }
}
