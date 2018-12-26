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

            if (buscado != null )
            {
                buscado.Persona.Nombre = nombre;
                buscado.Persona.Apellido = apellido;
                buscado.Persona.FechaNacimiento = fechaNacimiento;
                buscado.TipoDocumento = tipoDocumento;
                buscado.Localidad = localidad;
                buscado.Direccion = domicilio;
                buscado.Telefono = telefono;

                bdSocio.Actualizar(buscado);
                return -1;
            }
            else  return -2;
            Socio unSocio = null;

            unSocio = new Socio {
                Direccion = domicilio,
                Localidad = localidad,
                Telefono = telefono,
                CategoriaSocio = EnumCategoriaSocio.Inactiva,
                EstadoSocio = EnumEstadoSocio.Activo,
                FechaInicio = System.DateTime.Now,
                TipoDocumento = tipoDocumento
            };
            
            Persona unaPersona = new Persona
            {
                Nombre = nombre,
                Apellido = apellido,
                FechaNacimiento = fechaNacimiento,
                DNI = nroDocumento
            };
            new BDPersona().Crear(unaPersona);

           unSocio.Persona = unaPersona;

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


    }
}
