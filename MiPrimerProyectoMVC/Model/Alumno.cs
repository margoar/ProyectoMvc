namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Alumno")]
    public partial class Alumno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Alumno()
        {
            Adjunto = new HashSet<Adjunto>();
            AlumnoCurso = new HashSet<AlumnoCurso>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string Nombre { get; set; }

        [StringLength(255)]
        public string Apellido { get; set; }

        [StringLength(100)]
        public string Sexo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaNacimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adjunto> Adjunto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AlumnoCurso> AlumnoCurso { get; set; }
    
        public static List<Alumno> Listar()
        {
            var alumnos = new List<Alumno>();
            try
            {
                using(var ctx = new bdproyectoContext())
                {
                    alumnos = ctx.Alumno.ToList();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            return alumnos;
        }
          public static Alumno Obtener(int id)
        {
            var alumno = new Alumno();
            try
            {
                using(var ctx = new bdproyectoContext())
                {
                    alumno = ctx.Alumno.Include("AlumnoCurso")
                        .Include("AlumnoCurso.Curso")
                        .Where(a => a.id == id)
                        .SingleOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
            return alumno;
        }
    }
  
    
}
