﻿using ProjectGimnasiaYEsgrima.BD;
using ProjectGimnasiaYEsgrima.Interfaz;
using ProjectGimnasiaYEsgrima.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.Controlador
{
    public class ControladorEmpleado
    {
        BDEmpleado bdEmpleado = new BDEmpleado();
        ControladorPersona controladorPersona = new ControladorPersona();

        public int CrearEmpleado(string nombre,string apellido, DateTime fechaNacimiento, int documento, string descripcion, DateTime fechaInicio, EnumTipoEmpleado tipoEmpleado)
        {
            Empleado buscado = bdEmpleado.BuscarPorClavesUnicas(documento);
            if (buscado != null && buscado.EstadoEmpleado == EnumEstadoEmpleado.Baja)
            {
                buscado.EstadoEmpleado = EnumEstadoEmpleado.Activo;
                buscado.Persona.Nombre = nombre;
                buscado.Persona.Apellido = apellido;
                buscado.Persona.FechaNacimiento = fechaNacimiento;
                buscado.DescripcionTarea = descripcion;
                buscado.TipoEmpleado = tipoEmpleado;
                buscado.FechaInicio = fechaInicio;

                bdEmpleado.Actualizar(buscado);
                return -1;
            }
            else if (buscado != null) return -2;

            Persona pers = controladorPersona.BuscarPersonaPorClavesUnicas(documento);
            if (pers == null)
            {
                pers = new Persona
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    FechaNacimiento = fechaNacimiento,
                    DNI = documento
                };
                using (var ms = new MemoryStream())
                {
                    new Bitmap(global::ProjectGimnasiaYEsgrima.Properties.Resources.Perfil).Save(ms, ImageFormat.Png);
                    pers.Foto = ms.ToArray();
                }
                new BDPersona().Crear(pers);
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
                    unEmpleado = new Empleado();
                    break;
            }

            unEmpleado.FechaInicio = fechaInicio;
            unEmpleado.DescripcionTarea = descripcion;
            unEmpleado.TipoEmpleado = tipoEmpleado;
            unEmpleado.EstadoEmpleado = EnumEstadoEmpleado.Activo;
            

            
            
            unEmpleado.Persona = pers;
            return bdEmpleado.Crear(unEmpleado);
        }

        public ModelEmpleadoPersona BuscarEmpleadoPorClavesUnicasPorVista(int documento)
        {
            return bdEmpleado.BuscarPorClavesUnicasPorVista(documento);
        }

        public List<ModelEmpleadoPersona> ExtraerEmpleadosAVista()
        {
            return bdEmpleado.ListarTodos();
        }

        public List<ModelEmpleadoPersona> ExtraerEmpleadosAVista(params Object[] parametros)
        {
            if (parametros.Length < 4)
                return null;
            if (parametros[3].ToString().Equals(""))
                parametros[3] = 0;
            else
                parametros[3] = Enum.Parse(typeof(EnumTipoEmpleado), (string)parametros[3]);
            return bdEmpleado.ListarPorFiltro(parametros);
        }

        public int ModificarEmpleado(int idPersona, int idEmpleado, string nombre, string apellido, DateTime fechaNacimiento, int documento, string descripcion, DateTime fechaInicio, EnumTipoEmpleado tipoEmpleado, EnumEstadoEmpleado estadoEmpleado)
        {
            Empleado empleado = bdEmpleado.BuscarPorClavesUnicas(documento);
            empleado.DescripcionTarea = descripcion;
            empleado.FechaInicio = fechaInicio;
            Persona buscado = controladorPersona.BuscarPersonaPorClavesUnicas(documento);
            buscado.Nombre = nombre;
            buscado.Apellido = apellido;
            buscado.FechaNacimiento = fechaNacimiento;
            empleado.Persona = buscado;
            return bdEmpleado.Actualizar(empleado);
       
        }

        public int EliminarEmpleado(Empleado empleado)
        {
            empleado.EstadoEmpleado = EnumEstadoEmpleado.Baja;
            return bdEmpleado.Actualizar(empleado);
        }

        public List<Empleado> ListarTodosEmpleadosPorFiltros(params Object[] parametros)
        {
            return null;            
        }

        public int RegistrarEntradaSalidaEmpleado(ModelEmpleadoPersona empleado)
        {
            RegistroIngresoEgreso registro = bdEmpleado.TomarUltimoRegistroEntradaSalida(empleado.MiEmpleado);
            if (registro == null)
            {
                registro = new RegistroIngresoEgreso()
                {
                    Empleado = empleado.MiEmpleado,
                    Fecha = DateTime.Now,
                    HoraIngreso = DateTime.Now
                };
                bdEmpleado.RegistrarEntradaSalida(0,registro);
                return 0;
            }
            else if (registro.HoraEgreso == null)
            {
                registro.HoraEgreso = DateTime.Now;
                bdEmpleado.RegistrarEntradaSalida(1,registro);
                return 1;
            }
            else
            {
                registro = new RegistroIngresoEgreso()
                {
                    Empleado = empleado.MiEmpleado,
                    Fecha = DateTime.Now,
                    HoraIngreso = DateTime.Now
                };
                bdEmpleado.RegistrarEntradaSalida(0,registro);
                return 0;
            }

        }
        public List<ModelEmpleadoPersona> TraerEmpleadoReporte()
        {
            return bdEmpleado.ListarTodosEmpleados();
        }

        public Empleado VerificarLoginEmpleado(string usuario, string contraseña)
        {
            return bdEmpleado.VerificarLogin(usuario, contraseña);
        }
    }
}
