namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class bdproyectoContext : DbContext
    {
        public bdproyectoContext()
            : base("name=bdproyectoContext")
        {
        }

        public virtual DbSet<Adjunto> Adjunto { get; set; }
        public virtual DbSet<Alumno> Alumno { get; set; }
        public virtual DbSet<AlumnoCurso> AlumnoCurso { get; set; }
        public virtual DbSet<Curso> Curso { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.Adjunto)
                .WithOptional(e => e.Alumno)
                .HasForeignKey(e => e.Alumno_id);

            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.AlumnoCurso)
                .WithOptional(e => e.Alumno)
                .HasForeignKey(e => e.Alumno_id);

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.AlumnoCurso)
                .WithOptional(e => e.Curso)
                .HasForeignKey(e => e.Curso_id);
        }
    }
}
