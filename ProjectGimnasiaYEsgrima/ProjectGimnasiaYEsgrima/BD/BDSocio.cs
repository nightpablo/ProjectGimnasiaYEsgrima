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

        public void CrearCupon(CuotaSocio cuota)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(cuota.Socio).State = System.Data.Entity.EntityState.Modified;
                context.Entry(cuota.ValorCuotaInicial).State = System.Data.Entity.EntityState.Modified;
                if (cuota.Curso != null) { 
                    cuota.Curso = context.Cursos.AsEnumerable().FirstOrDefault(b => b.IdCurso == cuota.Curso.IdCurso);
                    context.Entry(cuota.Curso).State = System.Data.Entity.EntityState.Modified;
                }
                context.Entry(cuota).State = System.Data.Entity.EntityState.Added;

                context.SaveChanges();
            }
        }

        public void PagarCupon(CuotaSocio cuota)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                context.Entry(cuota.Socio).State = System.Data.Entity.EntityState.Modified;
                context.Entry(cuota.ValorCuotaInicial).State = System.Data.Entity.EntityState.Modified;
                if (cuota.Curso != null)
                {
                    cuota.Curso = context.Cursos.AsEnumerable().FirstOrDefault(b => b.IdCurso == cuota.Curso.IdCurso);
                    context.Entry(cuota.Curso).State = System.Data.Entity.EntityState.Modified;
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
                    .Where(b => b.MiPersona.Nombre.Contains((string)parametros[0]))
                    .Where(b => b.MiPersona.Apellido.Contains((string)parametros[1]))
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
                        MiSocio = e.Socio,
                        MiCuota = e,
                        MiCurso = e.Curso,
                        NombreCurso = e.Curso.Nombre
                    }).AsEnumerable()
                    .Where(b=> b.MiSocio.IdSocio == socio.IdSocio)
                    .ToList();

                return j;
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
                        MiSocio = e.Socio,
                        MiCuota = e,
                        MiCurso = e.Curso,
                        NombreCurso = e.Curso.Nombre
                    }).AsEnumerable()
                    .Where(b => b.MiSocio.IdSocio == socio.IdSocio)
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
        
        public List<Curso> ListarCursosInscripto(Socio socio)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {

                return context.Cursos
                    .AsEnumerable()
                    .Where(b=> b.Socios.Select(c=>c.IdSocio).Contains(socio.IdSocio))
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
