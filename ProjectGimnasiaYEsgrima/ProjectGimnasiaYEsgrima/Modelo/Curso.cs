using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectGimnasiaYEsgrima
{
    

    [Table("curso")]
    public partial class Curso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Idcurso { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaInicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaFin { get; set; }
    }
}
