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
    
    public partial class RegistroIngresoEgreso
    {
        public int Id { get; set; }
        public System.DateTime Ingreso { get; set; }
        public System.DateTime Salida { get; set; }
        public int EmpleadoIdEmpleado { get; set; }
        public byte[] EntradaSalida { get; set; }
    
        public virtual Empleado Empleado { get; set; }
    }
}