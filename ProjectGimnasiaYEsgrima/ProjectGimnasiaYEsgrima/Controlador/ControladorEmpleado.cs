using ProjectGimnasiaYEsgrima.BD;
using ProjectGimnasiaYEsgrima.Interfaz;
using ProjectGimnasiaYEsgrima.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.Controlador
{
    class ControladorEmpleado
    {
        BDEmpleado bdEmpleado = new BDEmpleado();
        ControladorPersona controladorPersona = new ControladorPersona();

        public int CrearEmpleado(string nombre,string apellido, DateTime fechaNacimiento, int documento, string descripcion, DateTime fechaInicio, EnumTipoEmpleado tipoEmpleado)
        {
            Persona unaPersona = controladorPersona.BuscarPersonaPorClavesUnicas(documento);
            if (unaPersona==null)
            { 
                unaPersona = new Persona
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        FechaNacimiento = fechaNacimiento,
                        DNI = documento
                    };
            }
            Empleado unEmpleado = null;
            switch (tipoEmpleado)
            {
                case EnumTipoEmpleado.Secretaria:
                    unEmpleado = new Secretaria();
                    break;
                case EnumTipoEmpleado.Profesor:
                    unEmpleado = new Profesor();
                    break;
                default:
                    return -1;
            }

            unEmpleado.FechaInicio = fechaInicio;
            unEmpleado.DescripcionTarea = descripcion;
            unEmpleado.TipoEmpleado = tipoEmpleado;
            unEmpleado.Persona = unaPersona;            

            bdEmpleado.Crear(unEmpleado);
            return 1;
        }


    }
}
