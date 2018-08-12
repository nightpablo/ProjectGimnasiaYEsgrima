using System;
using System.Data.Entity;
using ProjectGimnasiaYEsgrima;


namespace ProjectGimnasiaYEsgrima
{
    

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Curso> Cursos { get; set; }
        public virtual DbSet<Deporte> Deportes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Deporte>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Deporte>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);
        }
    }
}
