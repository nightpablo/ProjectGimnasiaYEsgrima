using ProjectGimnasiaYEsgrima.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGimnasiaYEsgrima.BD
{
    public class BDSocio : InterfaceBD<Socio, ModelSocioPersona>
    {
        public int Actualizar(Socio entrada)
        {
            using(var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(entrada.Persona).State = System.Data.Entity.EntityState.Modified;
                context.Entry(entrada).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return 1;
            }
        }

        public Socio BuscarPorClavesUnicas(params object[] parametros)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Socios.AsEnumerable().FirstOrDefault(b => b.Persona.DNI == (int)parametros[0]);
            }
        }

        public ModelSocioPersona BuscarPorClavesUnicasPorVista(int documento)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Socios
                    .Select(e => new ModelSocioPersona()
                    {
                        Nombre = e.Persona.Nombre,
                        Apellido = e.Persona.Apellido,
                        DNI = e.Persona.DNI,
                        MiSocio = e,
                        MiPersona = e.Persona
                    }).AsEnumerable()
                    .FirstOrDefault(b=>b.DNI==documento);

                
            }
        }

        public int Crear(Socio entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(entrada.Persona).State = System.Data.Entity.EntityState.Modified;
                context.Entry(entrada).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
                return 1;
            }
        }

        public int Migrar(List<Socio> listasocios)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                foreach(var entrada in listasocios)
                {
                    context.Entry(entrada.Persona).State = System.Data.Entity.EntityState.Modified;
                    context.Entry(entrada).State = System.Data.Entity.EntityState.Added;
                    
                }
                context.SaveChanges();
                return 1;
            }
        }

        public Socio DocumentosUnicos(List<int> listadocumentos)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Socios.AsEnumerable().FirstOrDefault(b => listadocumentos.Contains(b.Persona.DNI));
            }
       }

        public void CrearCupon(CuotaSocio cuota)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(cuota.Socio).State = System.Data.Entity.EntityState.Modified;
                context.Entry(cuota.ValorCuotaInicial).State = System.Data.Entity.EntityState.Modified;
                if (cuota.Categoria != null) { 
                    cuota.Categoria = context.Categorias.AsEnumerable().FirstOrDefault(b => b.IdCategoria == cuota.Categoria.IdCategoria);
                    context.Entry(cuota.Categoria).State = System.Data.Entity.EntityState.Modified;
                }
                context.Entry(cuota).State = System.Data.Entity.EntityState.Added;

                context.SaveChanges();
            }
        }

        public void CrearCuponesDelMes(List<CuotaSocio> cupones)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                foreach (var entrada in cupones)
                {
                    context.Entry(entrada.Socio).State = System.Data.Entity.EntityState.Modified;
                    context.Entry(entrada.ValorCuotaInicial).State = System.Data.Entity.EntityState.Modified;
                    if (entrada.Categoria != null)
                    {
                        entrada.Categoria = context.Categorias.AsEnumerable().FirstOrDefault(b => b.IdCategoria == entrada.Categoria.IdCategoria);
                        context.Entry(entrada.Categoria).State = System.Data.Entity.EntityState.Modified;
                    }
                    context.Entry(entrada).State = System.Data.Entity.EntityState.Added;
                }

                context.SaveChanges();
            }
        }

        public void PagarCupon(CuotaSocio cuota)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(cuota.Socio).State = System.Data.Entity.EntityState.Modified;
                context.Entry(cuota.ValorCuotaInicial).State = System.Data.Entity.EntityState.Modified;
                if (cuota.Categoria != null)
                {
                    cuota.Categoria = context.Categorias.AsEnumerable().FirstOrDefault(b => b.IdCategoria == cuota.Categoria.IdCategoria);
                    context.Entry(cuota.Categoria).State = System.Data.Entity.EntityState.Modified;
                }
                context.Entry(cuota).State = System.Data.Entity.EntityState.Modified;

                context.SaveChanges();
            }
        }

        public int Eliminar(Socio entrada)
        {
            throw new NotImplementedException();
        }

        public List<ModelSocioPersona> ListarPorFiltro(params object[] parametros)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                var j = context.Socios                    
                    .Select(e => new ModelSocioPersona()
                     {
                        Nombre = e.Persona.Nombre,
                        Apellido = e.Persona.Apellido,
                        DNI = e.Persona.DNI,
                        MiSocio = e,
                        MiPersona = e.Persona
                    }).AsEnumerable()
                    .Where(b => b.MiSocio.EstadoSocio != EnumEstadoSocio.Baja)
                    .Where(b => b.MiPersona.Nombre.ToLower().Contains(((string)parametros[0]).ToLower()))
                    .Where(b => b.MiPersona.Apellido.ToLower().Contains(((string)parametros[1]).ToLower()))
                    .Where(b => b.MiPersona.DNI.ToString().Contains((string)parametros[2]))
                    .ToList();
                
                return j;
            }
        }

        public List<ModelSocioPersona> ListarTodos()
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                var j = context.Socios
                    .Select(e => new ModelSocioPersona()
                    {
                        Nombre = e.Persona.Nombre,
                        Apellido = e.Persona.Apellido,
                        DNI = e.Persona.DNI,
                        MiSocio = e,
                        MiPersona = e.Persona
                    }).AsEnumerable()
                    .Where(b => b.MiSocio.EstadoSocio != EnumEstadoSocio.Baja)
                    .ToList();

                return j;
            }
        }

        public ModelSocioPersona BuscarSocio(int ID)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Socios
                    .Select(e => new ModelSocioPersona()
                    {
                        Nombre = e.Persona.Nombre,
                        Apellido = e.Persona.Apellido,
                        DNI = e.Persona.DNI,
                        MiSocio = e,
                        MiPersona = e.Persona
                    }).AsEnumerable()
                    .FirstOrDefault(b=>b.MiSocio.IdSocio==ID);
            }
        }

        public List<ModelCuponSocio> ListarCuota(Socio socio)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                var j = context.CuotaSocios
                    .Select(e => new ModelCuponSocio()
                    {
                        IdCuota = e.IdCuota,
                        Estado = e.Estado,
                        FechaCobro = e.FechaCobro,
                        FechaEmision = e.FechaEmision,
                        Importe = e.Importe,
                        ValorCuotaInicial = e.ValorCuotaInicial,
                        MiCuota = e,
                        MiCategoria = e.Categoria,
                        NombreCategoria = e.Categoria.Nombre,
                        MiSocio = new ModelSocioPersona()
                        {
                            Nombre = e.Socio.Persona.Nombre,
                            Apellido = e.Socio.Persona.Apellido,
                            DNI = e.Socio.Persona.DNI,
                            MiSocio = e.Socio,
                            MiPersona = e.Socio.Persona
                        }
                    }).AsEnumerable()
                    .Where(b=> b.MiSocio.MiSocio.IdSocio == socio.IdSocio)
                    .Where(b=>b.MiCategoria != null)
                    .Where(b=>b.EstadoCategoria != EnumEstadoCategoria.Cancelado)
                    .Where(b=>b.EstadoCategoria!= EnumEstadoCategoria.Terminado)
                    .ToList();

                return j;
            }
        }

        public List<ModelCuponSocio> ListarTodasCuotas()
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.CuotaSocios
                    .Select(e => new ModelCuponSocio()
                    {
                        IdCuota = e.IdCuota,
                        Estado = e.Estado,
                        FechaCobro = e.FechaCobro,
                        FechaEmision = e.FechaEmision,
                        Importe = e.Importe,
                        ValorCuotaInicial = e.ValorCuotaInicial,
                        MiCuota = e,
                        MiCategoria = e.Categoria,
                        NombreCategoria = e.Categoria.Nombre,
                        MiSocio = new ModelSocioPersona()
                        {
                            Nombre = e.Socio.Persona.Nombre,
                            Apellido = e.Socio.Persona.Apellido,
                            DNI = e.Socio.Persona.DNI,
                            MiSocio = e.Socio,
                            MiPersona = e.Socio.Persona
                        }
                    })
                    
                    .ToList();
            }
        }

        public List<ModelCuponSocio> ListarCuota(Socio socio, int mes)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                var j = context.CuotaSocios
                    .Select(e => new ModelCuponSocio()
                    {
                        IdCuota = e.IdCuota,
                        Estado = e.Estado,
                        FechaCobro = e.FechaCobro,
                        FechaEmision = e.FechaEmision,
                        Importe = e.Importe,
                        ValorCuotaInicial = e.ValorCuotaInicial,
                        MiCuota = e,
                        MiCategoria = e.Categoria,
                        NombreCategoria = e.Categoria.Nombre,
                        MiSocio = new ModelSocioPersona()
                        {
                            Nombre = e.Socio.Persona.Nombre,
                            Apellido = e.Socio.Persona.Apellido,
                            DNI = e.Socio.Persona.DNI,
                            MiSocio = e.Socio,
                            MiPersona = e.Socio.Persona
                        }
                    }).AsEnumerable()
                    .Where(b => b.MiSocio.MiSocio.IdSocio == socio.IdSocio)
                    .Where(b=> b.MiCuota.FechaEmision.Month==mes)
                    .ToList();

                return j;
            }
        }

        public int CrearValorInicialClub(ValorCuotaInicial nuevo)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(nuevo).State = System.Data.Entity.EntityState.Added;
                return context.SaveChanges();
            }
        }

        public int CrearValorInicialClub(ValorCuotaInicial anterior, ValorCuotaInicial nuevo)
        {     
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(anterior).State = System.Data.Entity.EntityState.Modified;
                context.Entry(nuevo).State = System.Data.Entity.EntityState.Added;
                return context.SaveChanges();
            }
            
        }

        public ValorCuotaInicial ValorInicialClub()
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.ValorCuotaInicials
                    .AsEnumerable()
                    .FirstOrDefault(b => b.FechaFin == null);
            }
        }
        
        public List<Categoria> ListarCategoriasInscripto(Socio socio)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {

                return context.Categorias
                    .AsEnumerable()
                    .Where(b=> b.Socios.Select(c=>c.IdSocio).Contains(socio.IdSocio))
                    .Where(b=>b.EstadoCategoria!=EnumEstadoCategoria.Cancelado && b.EstadoCategoria!=EnumEstadoCategoria.Terminado )
                    .ToList();
            }
        }

        public int AnularCuota(CuotaSocio cuota)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {

                context.Entry(cuota).State = System.Data.Entity.EntityState.Modified;
                return context.SaveChanges();
            }
        }

        public List<ModelSocioPersona> ListarTodosSocios()
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                var j = context.Socios
                    .Select(e => new ModelSocioPersona()
                    {
                        Nombre = e.Persona.Nombre,
                        Apellido = e.Persona.Apellido,
                        DNI = e.Persona.DNI,
                        MiSocio = e,
                        MiPersona = e.Persona,
                        CategoriaSocio =e.CategoriaSocio
                    }).AsEnumerable()
                    .ToList();

                return j;
            }
        }

    }
}
