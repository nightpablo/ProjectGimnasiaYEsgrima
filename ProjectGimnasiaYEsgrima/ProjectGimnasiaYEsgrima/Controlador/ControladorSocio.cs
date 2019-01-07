using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectGimnasiaYEsgrima.BD;
using ProjectGimnasiaYEsgrima.Interfaz;
using ProjectGimnasiaYEsgrima.Modelo;

namespace ProjectGimnasiaYEsgrima.Controlador
{
    class ControladorSocio
    {
        BDSocio bdSocio = new BDSocio();
        ControladorPersona controladorPersona = new ControladorPersona();

        public int CrearSocio(string nombre, string apellido, DateTime fechaNacimiento, int nroDocumento, string domicilio, string localidad, string telefono, EnumTipoDocumento tipoDocumento)
        {



            Socio buscado = bdSocio.BuscarPorClavesUnicas(nroDocumento);

            if (buscado != null && buscado.EstadoSocio == EnumEstadoSocio.Baja)
            {
                buscado.Persona.Nombre = nombre;
                buscado.Persona.Apellido = apellido;
                buscado.Persona.FechaNacimiento = fechaNacimiento;
                buscado.Localidad = localidad;
                buscado.Direccion = domicilio;
                buscado.Telefono = telefono;
                buscado.EstadoSocio = EnumEstadoSocio.Activo;
                bdSocio.Actualizar(buscado);
                return -1;
            }
            if (buscado != null)
            {
                return -2;
            }

            Persona pers = controladorPersona.BuscarPersonaPorClavesUnicas(nroDocumento);

            if(pers == null)
            {
                pers = new Persona
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    FechaNacimiento = fechaNacimiento,
                    DNI = nroDocumento
                };
            }

            Socio unSocio = new Socio {
                Direccion = domicilio,
                Localidad = localidad,
                Telefono = telefono,
                CategoriaSocio = EnumCategoriaSocio.Inactiva,
                EstadoSocio = EnumEstadoSocio.Activo,
                FechaInicio = System.DateTime.Now,
                TipoDocumento = tipoDocumento
            };
            
            
            new BDPersona().Crear(pers);

            unSocio.Persona = pers;

            return bdSocio.Crear(unSocio);
        }

        public List<ModelSocioPersona> ExtraerSociosAVista()
        {
            return bdSocio.ListarTodos();
        }

        public List<ModelSocioPersona> ExtraerSociosAVista(params Object[] parametros)
        {
            if (parametros.Length < 3)
                return null;
     
            
            return bdSocio.ListarPorFiltro(parametros);
        }

        public int EliminarSocio(Socio socio)
        {
            socio.EstadoSocio = EnumEstadoSocio.Baja;
            return bdSocio.Actualizar(socio);
        }

        public int ModificarSocio(int idPersona, int idSocio, string nombre, string apellido, DateTime fechaNacimiento, int documento, string direccion,string localidad, string telefono)
        {
            Socio socio = bdSocio.BuscarPorClavesUnicas(documento);
            socio.Direccion = direccion;
            socio.Localidad = localidad;
            socio.Telefono = telefono;
            
            Persona buscado = controladorPersona.BuscarPersonaPorClavesUnicas(documento);
            buscado.Nombre = nombre;
            buscado.Apellido = apellido;
            buscado.FechaNacimiento = fechaNacimiento;
            socio.Persona = buscado;
            return bdSocio.Actualizar(socio);

        }

    }
}
