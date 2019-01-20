using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.Modelo
{
    public class ModelSocioPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public EnumTipoDocumento TipoDocumento { get; set; }
        public EnumCategoriaSocio CategoriaSocio { get ; set; }
        public string TextCategoriaSocio { get {return CategoriaSocio.ToString();}}
        public Socio MiSocio { get; set; }
        public Persona MiPersona { get; set; }
        public ModelSocioPersona() { }
        public ModelSocioPersona(Socio entry)
        {
            MiSocio = entry;
            MiPersona = entry.Persona;
            Nombre = entry.Persona.Nombre;
            Apellido = entry.Persona.Apellido;
            DNI = entry.Persona.DNI;
        }
    }
}
