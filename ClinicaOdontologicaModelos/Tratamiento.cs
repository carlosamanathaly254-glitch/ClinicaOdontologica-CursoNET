using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaOdontologicaModelos
{
    [Table("Tratamientos")]
    public class Tratamiento
    {
        [Key]
        [Column("IdTratamiento")]

        public int IdTratamiento { get; set; }

        [Column("nombreTratamiento")]
        [MaxLength(50)]
        [Required]
        public string nombreTratamiento { get; set; }

        [Column("costoBase", TypeName = "numeric(18,2)")]
        [Required]
        public decimal costoBase { get; set; }
        
        [Column("duracionMin")]
        [Required]
        public int duracionMin { get; set; }

    }
}
