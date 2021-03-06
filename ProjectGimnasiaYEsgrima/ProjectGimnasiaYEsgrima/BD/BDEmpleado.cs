﻿using ProjectGimnasiaYEsgrima.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.BD
{
    public class BDEmpleado : InterfaceBD<Empleado,ModelEmpleadoPersona>
    {
        public int Actualizar(Empleado entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(entrada.Persona).State = System.Data.Entity.EntityState.Modified;
                context.Entry(entrada).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return 1;
            }
        }

        public Empleado BuscarPorClavesUnicas(params object[] parametros)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Empleados.AsEnumerable().FirstOrDefault(b => b.Persona.DNI == (int)parametros[0]);
            }
        }
        public int Crear(Empleado entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(entrada.Persona).State = System.Data.Entity.EntityState.Modified;
                context.Entry(entrada).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
                return 1;
            }
        }
        public int Migrar(List<Empleado> listaempleados)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                foreach(var entrada in listaempleados)
                {
                    context.Entry(entrada.Persona).State = System.Data.Entity.EntityState.Modified;
                    context.Entry(entrada).State = System.Data.Entity.EntityState.Added;
                    
                }
                context.SaveChanges();
                return 1;
            }
        }

        public Empleado DocumentosUnicos(List<int> listadocumentos)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                foreach (var entrada in listadocumentos)
                {
                    return context.Empleados.AsEnumerable().FirstOrDefault(b => listadocumentos.Contains(b.Persona.DNI));
                }
                return null;
            }
        }

        public int Eliminar(Empleado entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(context.Empleados.Find(entrada.IdEmpleado)).State = System.Data.Entity.EntityState.Deleted;

                context.SaveChanges();
                return 1;
            }
        }

        public ModelEmpleadoPersona BuscarPorClavesUnicasPorVista(int documento)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                
                return context.Empleados
                    .Select(e => new ModelEmpleadoPersona()
                    {
                        Nombre = e.Persona.Nombre,
                        Apellido = e.Persona.Apellido,
                        DNI = e.Persona.DNI,
                        Foto = e.Persona.Foto,
                        TipoEmpleado = e.TipoEmpleado,
                        MiEmpleado = e,
                        MiPersona = e.Persona
                    })
                    .AsEnumerable()
                    .FirstOrDefault(b => b.MiPersona.DNI == documento);
            }
        }

        public List<ModelEmpleadoPersona> ListarTodos()
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Empleados
                    .AsEnumerable()
                    .Where(b=>b.EstadoEmpleado!=EnumEstadoEmpleado.Baja)
                    .Select(e => new ModelEmpleadoPersona()
                {
                    Nombre = e.Persona.Nombre,
                    Apellido = e.Persona.Apellido,
                    DNI = e.Persona.DNI,
                    TipoEmpleado = e.TipoEmpleado,
                    MiEmpleado = e,
                    MiPersona = e.Persona
                }).ToList();
            }
        }

        public List<ModelEmpleadoPersona> ListarPorFiltro(params object[] parametros)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                var j = context.Empleados
                    .Select(e => new ModelEmpleadoPersona()
                {
                    Nombre = e.Persona.Nombre,
                    Apellido = e.Persona.Apellido,
                    DNI = e.Persona.DNI,
                    TipoEmpleado = e.TipoEmpleado,
                    MiEmpleado = e,
                    MiPersona = e.Persona
                }).AsEnumerable()
                    .Where(b => b.MiPersona.Nombre.ToLower().Contains(((string)parametros[0]).ToLower()))
                    .Where(b => b.MiPersona.Apellido.ToLower().Contains(((string)parametros[1]).ToLower()))
                    .Where(b => b.MiPersona.DNI.ToString().Contains((string)parametros[2]))
                    .Where(b => b.MiEmpleado.EstadoEmpleado != EnumEstadoEmpleado.Baja)
                    .ToList();
                var tipoemp = Convert.ToInt32(parametros[3]);
                return tipoemp==0? j : j.Where(b => (int)b.TipoEmpleado == tipoemp).ToList();
            }
        }

        

        public bool existeEmpleado(Empleado emp, Persona pers)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                var i = context.Empleados.AsEnumerable().FirstOrDefault(b => b.Persona.DNI.Equals(pers.DNI) && b.TipoEmpleado.Equals(emp.TipoEmpleado));

                return i!=null;
            }
        }

        public int RegistrarEntradaSalida(int i, RegistroIngresoEgreso registro)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                
                if (i == 0) {
                    context.Entry(registro.Empleado).State = System.Data.Entity.EntityState.Modified;
                    context.Entry(registro).State = System.Data.Entity.EntityState.Added;
                }
                else  
                    context.Entry(registro).State = System.Data.Entity.EntityState.Modified;
                
                return context.SaveChanges();
            }
        }

        public RegistroIngresoEgreso TomarUltimoRegistroEntradaSalida(Empleado emp)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.RegistroIngresoEgresoes
                    .OrderByDescending(b => b.HoraIngreso).FirstOrDefault(b => b.Empleado.IdEmpleado == emp.IdEmpleado);
            }
        }

        public List<RegistroIngresoEgreso> TodosRegistrosEntradaSalida(Empleado emp)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.RegistroIngresoEgresoes
                    .AsEnumerable()
                    .Where(b => b.Empleado.IdEmpleado == emp.IdEmpleado)
                    .ToList();
            }
        }


        public List<ModelEmpleadoPersona> ListarTodosEmpleados()
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Empleados
                    .AsEnumerable()
                    
                    .Select(e => new ModelEmpleadoPersona()
                    {
                        Nombre = e.Persona.Nombre,
                        Apellido = e.Persona.Apellido,
                        DNI = e.Persona.DNI,
                        MiEmpleado = e,
                        MiPersona = e.Persona,
                        TipoEmpleado= e.TipoEmpleado
                    }).ToList();
            }
        }

        public Empleado VerificarLogin(string usuario, string contraseña)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                Login lg = context.Logins.AsEnumerable().FirstOrDefault(b => b.usuario.Equals(usuario) && b.contraseña.Equals(contraseña));
                return lg==null? null:lg.Empleado;
            }
        }

        public List<ModelIngresoEgresoEmpleado> ListarEntradaSalidaEmpleado()
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.RegistroIngresoEgresoes
                    .AsEnumerable()

                    .Select(e => new ModelIngresoEgresoEmpleado()
                    {
                        Registro = e
                    })
                    .OrderByDescending(e=> e.Fecha)
                    .OrderByDescending(e=>e.ApellidoEmpleado)
                    .ToList();
            }
        }
    }

}

