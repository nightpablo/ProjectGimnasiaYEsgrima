using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectGimnasiaYEsgrima.BD;
using ProjectGimnasiaYEsgrima.Interfaz;
using ProjectGimnasiaYEsgrima.Modelo;

namespace ProjectGimnasiaYEsgrima.Controlador
{
    public class ControladorSocio
    {
        BDSocio bdSocio = new BDSocio();
        ControladorPersona controladorPersona = new ControladorPersona();

        public ModelSocioPersona BuscarPorClavesUnicasSocio(int documento)
        {
            return bdSocio.BuscarPorClavesUnicasPorVista(documento);
        }

        public int CrearSocio(string nombre, string apellido, DateTime fechaNacimiento, int nroDocumento, string domicilio, string localidad, string telefono, EnumTipoDocumento tipoDocumento, EnumCategoriaSocio categoria)
        {
            var valorcuotainicial = bdSocio.ValorInicialClub();
            if (valorcuotainicial == null)
                return -3;


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
                buscado.CategoriaSocio = categoria;
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
                using (var ms = new MemoryStream())
                {
                    new Bitmap(global::ProjectGimnasiaYEsgrima.Properties.Resources.Perfil).Save(ms, ImageFormat.Png);
                    pers.Foto = ms.ToArray();
                }
                new BDPersona().Crear(pers);
            }

            Socio unSocio = new Socio {
                Direccion = domicilio,
                Localidad = localidad,
                Telefono = telefono,
                CategoriaSocio = categoria,
                EstadoSocio = EnumEstadoSocio.Activo,
                FechaInicio = System.DateTime.Now,
                TipoDocumento = tipoDocumento
            };
            
            
            

            unSocio.Persona = pers;
            bdSocio.Crear(unSocio);

            
            CrearCupon(DateTime.Now, valorcuotainicial.Importe, valorcuotainicial, unSocio);

            return 1;
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

        public int ModificarSocio(int idPersona, int idSocio, string nombre, string apellido, DateTime fechaNacimiento, int documento, string direccion,string localidad, string telefono, EnumCategoriaSocio categoria)
        {
            Socio socio = bdSocio.BuscarPorClavesUnicas(documento);
            socio.Direccion = direccion;
            socio.Localidad = localidad;
            socio.Telefono = telefono;
            socio.CategoriaSocio = categoria;
            
            Persona buscado = controladorPersona.BuscarPersonaPorClavesUnicas(documento);
            buscado.Nombre = nombre;
            buscado.Apellido = apellido;
            buscado.FechaNacimiento = fechaNacimiento;
            socio.Persona = buscado;
            return bdSocio.Actualizar(socio);

        }

        public List<ModelCuponSocio> ListarCuotaSocios(Socio socio) //Listar todas las cuotas del socio asociados a cada deporte
        {
            return bdSocio.ListarCuota(socio);
        }

        public List<ModelCuponSocio> ListarCuotaSocios(Socio socio, int mes) //Listar todas las cuotas del socio asociados a cada deporte
        {
            return bdSocio.ListarCuota(socio,mes);
        }

        public int CrearValorInicialClub(double monto)
        {
            ValorCuotaInicial valorAnterior = bdSocio.ValorInicialClub();
            ValorCuotaInicial valorNuevo = new ValorCuotaInicial();

            
            valorNuevo.FechaInicio = DateTime.Now;
            valorNuevo.Importe = monto;
            if (valorAnterior != null)
            {
                valorAnterior.FechaFin = DateTime.Now;             
                return bdSocio.CrearValorInicialClub(valorAnterior, valorNuevo);
            }
            else
            {
                return bdSocio.CrearValorInicialClub(valorNuevo);
            }
        }

        public ValorCuotaInicial UltimoValorInicialClub()
        {
            return bdSocio.ValorInicialClub();
            
        }

        public List<ModelCuponSocio> ListarTodasCuotasSocios()
        {
            return bdSocio.ListarTodasCuotas();
        }

        public void EjecutarProcesoCuponesGeneral(int MesSeleccionado)
        {
            List<ModelSocioPersona> socios = ExtraerSociosAVista();
            List<Curso> cursos;
            var valorInicial = bdSocio.ValorInicialClub();
            double MontoTotal;
            DateTime dat;
            foreach (var i in socios) {
                MontoTotal = valorInicial.Importe;
                cursos = bdSocio.ListarCursosInscripto(i.MiSocio);
                MontoTotal += cursos.Select(b => b.Costo).Sum();


                /*
                if (DateTime.Now.Day <= 15)
                {
                    dat = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                    DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Kind);
                }
                else
                {
                    dat = new DateTime(DateTime.Now.Year, DateTime.Now.Month+1, 1,
                    DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Kind);
                }*/
                dat = new DateTime(DateTime.Now.Year, MesSeleccionado+1, 1,
                    DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second, DateTime.Now.Kind);


                CrearCupon(dat, valorInicial.Importe, valorInicial, i.MiSocio);
                foreach(var j in cursos)
                {
                    CrearCupon(dat, j.Costo, valorInicial, i.MiSocio,j);
                }
            }
        }

        public void PagarCuponSocio(List<ModelCuponSocio> lista)
        {
            foreach(var i in lista){
                i.MiCuota.Estado = EnumEstadoCuotaSocio.Pagado;
                i.MiCuota.FechaCobro = DateTime.Now;
                bdSocio.PagarCupon(i.MiCuota);
            }

        }

        private void CrearCupon(DateTime fechaemi, double importe, ValorCuotaInicial valor, Socio MiSocio, Curso MiCurso)
        {
            var cuota = new CuotaSocio
            {
                FechaEmision = fechaemi,
                Estado = EnumEstadoCuotaSocio.NoPagado,
                Importe = importe,
                ValorCuotaInicial = valor,
                Socio = MiSocio,
                Curso = MiCurso
            };
            bdSocio.CrearCupon(cuota);
        }

        private void CrearCupon(DateTime fechaemi, double importe, ValorCuotaInicial valor, Socio MiSocio)
        {

            var cuota = new CuotaSocio
            {
                FechaEmision = fechaemi,
                Estado = EnumEstadoCuotaSocio.NoPagado,
                Importe = importe,
                ValorCuotaInicial = valor,
                Socio = MiSocio
            };
            bdSocio.CrearCupon(cuota);
        }

        public int AnularCuotaSocio(CuotaSocio cuota)
        {
            cuota.Estado = EnumEstadoCuotaSocio.Anulado;
            return bdSocio.AnularCuota(cuota);
        }

        public List<ModelSocioPersona> TraerSocioReporte()
        {
            return bdSocio.ListarTodosSocios();
        }

    }
}
