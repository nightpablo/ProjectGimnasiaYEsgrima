//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectGimnasiaYEsgrima.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Curso
    {
        public int IdCurso { get; set; }
        public string Nombre { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public int DeporteIdDeporte { get; set; }
    
        public virtual Deporte Deporte { get; set; }
    }
}
