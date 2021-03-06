﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectGimnasiaYEsgrima.Modelo;


namespace ProjectGimnasiaYEsgrima.BD
{
    public class BDDeporte : InterfaceBD<Deporte,ModelDeporte>
    {

        public int Crear(Deporte entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {

                context.Deportes.Add(entrada);
                context.SaveChanges();
                return 1;
            }
        }

        public int Actualizar(Deporte entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                //var un_deporte = context.Deportes.Find(entrada.IdDeporte);
                // un_deporte.Nombre = entrada.Nombre;
                //un_deporte.Descripcion = entrada.Descripcion;
                context.Entry(entrada).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return 1;
            }
        }

        public int Eliminar(Deporte entrada)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                var un_deporte = context.Deportes.Find(entrada.IdDeporte);
                context.Deportes.Remove(un_deporte);
                context.SaveChanges();
                return 1;
            }
        }

        public List<ModelDeporte> ListarTodos()
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Deportes
                    .AsEnumerable()
                    .Where(b => b.EstadoDeporte != EnumEstadoDeporte.Baja)
                    .Select(b => new ModelDeporte()
                    {
                        IdDeporte = b.IdDeporte,
                        Nombre = b.Nombre,
                        Descripcion = b.Descripcion,
                        EstadoDeporte = b.EstadoDeporte,
                        MiDeporte = b

                    })
                    
                    .ToList();
            }
        }

        public List<ModelDeporte> ListarPorFiltro(params object[] parametros)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Deportes.AsEnumerable()
                    .Where(b => b.Nombre.ToLower().Contains(((string)parametros[0]).ToLower()))
                    .Where(b => b.Descripcion.ToLower().Contains(((string)parametros[1]).ToLower()))
                    .Where(b => b.EstadoDeporte != EnumEstadoDeporte.Baja)
                    .Select(b => new ModelDeporte()
                    {
                        IdDeporte = b.IdDeporte,
                        Nombre = b.Nombre,
                        Descripcion = b.Descripcion,
                        EstadoDeporte = b.EstadoDeporte,
                        MiDeporte = b

                    })
                    .ToList();
            }
        }

        public Deporte BuscarPorClavesUnicas(params object[] parametros)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Deportes.AsEnumerable()
                    .FirstOrDefault(b => b.Nombre.ToLower().Contains(((string)parametros[0]).ToLower()));
            }
        }

        public Deporte BuscarPorId(int id)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                Deporte d = context.Deportes.Find(id);
                context.Entry(d).State = System.Data.Entity.EntityState.Unchanged;
                return d;
            }
        }

        public bool PerteneceAlgunCategoria(Deporte deporte)
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                Categoria c = context.Categorias.AsEnumerable().FirstOrDefault(b => b.Deporte.IdDeporte == deporte.IdDeporte);
                return c != null;
            }

        }

        public List<ModelDeporte> ListarTodosDeportes()
        {
            using (var context = new DiagramasDeTablasContainer1())
            {
                return context.Deportes
                    .AsEnumerable()
                    //.Where(b => b.EstadoDeporte != EnumEstadoDeporte.Baja)
                    .Select(b => new ModelDeporte()
                    {
                        IdDeporte = b.IdDeporte,
                        Nombre = b.Nombre,
                        Descripcion = b.Descripcion,
                        EstadoDeporte = b.EstadoDeporte,
                        MiDeporte = b

                    })

                    .ToList();
            }
        }
    }
}