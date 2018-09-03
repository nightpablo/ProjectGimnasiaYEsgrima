using ProjectGimnasiaYEsgrima.BD;
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

        public int crearEmpleado(string nombre,string apellido, DateTime fechaNacimiento, int documento, string descripcion, DateTime fechaInicio)
        {
            Persona unaPersona = new Persona
            {
                Nombre = nombre,
                Apellido = apellido,
                FechaNacimiento = fechaNacimiento,
                DNI = documento
            };

            Secretaria unEmpleado = new Secretaria
            {
                FechaInicio = fechaInicio,
                DescripcionTarea = descripcion,
                Persona = unaPersona
            };

            bdEmpleado.Crear(unEmpleado);
                return 0;
        }

        public int crearProfesor(string nombre, string apellido, DateTime fechaNacimiento, int documento, string descripcion, DateTime fechaInicio, List<Deporte> listaEmpleados)
        {
            Persona unaPersona = new Persona
            {
                Nombre = nombre,
                Apellido = apellido,
                FechaNacimiento = fechaNacimiento,
                DNI = documento
            };
¡
                Profesor unEmpleado = new Profesor
                {
                    FechaInicio = fechaInicio,
                    DescripcionTarea = descripcion,
                    Persona = unaPersona
                };
                bdEmpleado.Crear(unEmpleado);
          
            
            return 0;
        }

       
    }
}
