using ProjectGimnasiaYEsgrima.BD;
using ProjectGimnasiaYEsgrima.Interfaz;
using ProjectGimnasiaYEsgrima.Modelo;
using System;
using System.Collections;
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

        public List<ModelEmpleadoPersona> ExtraerEmpleadosAVista()
        {
            return bdEmpleado.ListarEmpleadosPersonas();
        }

        public int ModificarEmpleado(int idPersona, int idEmpleado, string nombre, string apellido, DateTime fechaNacimiento, int documento, string descripcion, DateTime fechaInicio, EnumTipoEmpleado tipoEmpleado)
        {

            Persona buscado = controladorPersona.BuscarPersonaPorClavesUnicas(documento);
            if (buscado != null && buscado.IdPersona != idPersona)
            {
                return -2;
            }
            else
            {
                Persona unaPersona = new Persona
                {
                    IdPersona = idPersona,
                    Nombre = nombre,
                    Apellido = apellido,
                    FechaNacimiento = fechaNacimiento,
                    DNI = documento
                };


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
                unEmpleado.IdEmpleado = idEmpleado;

                bdEmpleado.Actualizar(unEmpleado);
            }

       
            return 1;
        }

        public int EliminarEmpleado(Empleado empleado)
        {
            bdEmpleado.Eliminar(empleado);
            return 0;
        }

        public List<Empleado> ListarTodosEmpleadosPorFiltros(params Object[] parametros)
        {
            if (parametros.Length <= 1)
                return null;
            return bdEmpleado.ListarPorFiltro(parametros);
            
        }
    }
}
