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
                new BDPersona().Crear(unaPersona);
            }
            else if (bdEmpleado.existeEmpleado(unEmpleado, unaPersona)) { 
                return -2;
            }



            unEmpleado.Persona = unaPersona;
            return bdEmpleado.Crear(unEmpleado);
        }

        public List<ModelEmpleadoPersona> ExtraerEmpleadosAVista()
        {
            return bdEmpleado.ListarEmpleadosPersonas();
        }

        public List<ModelEmpleadoPersona> ExtraerEmpleadosAVista(params Object[] parametros)
        {
            if (parametros.Length < 4)
                return null;
            if (parametros[3].ToString().Equals(""))
                parametros[3] = 0;
            else
                parametros[3] = Enum.Parse(typeof(EnumTipoEmpleado), (string)parametros[3]);
            return bdEmpleado.ListarEmpleadosPersonas(parametros);
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


                return bdEmpleado.Actualizar(unEmpleado);
            }

       
        }

        public int EliminarEmpleado(Empleado empleado)
        {
            return bdEmpleado.Eliminar(empleado);
        }

        public List<Empleado> ListarTodosEmpleadosPorFiltros(params Object[] parametros)
        {

            return null;
            
        }
    }
}
