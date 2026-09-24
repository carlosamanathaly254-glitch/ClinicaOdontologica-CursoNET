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
        [Column("IdTratamiento", TypeName = "serial")]

        public int IdTratamiento { get; set; }

        [Column("nombreTratamiento")]
        [MaxLength(100)]
        [Required]
        public string nombreTratamiento { get; set; }

        [Column("costoBase", TypeName = "numeric(10,2)")]
        [Required]
        public decimal costoBase { get; set; }

        [Column("duracionMin")]
        [Required]
        public int duracionMin { get; set; }


        //Relaciones
        List<DetalleCita>? DetallesCita{ get; set; } = new List<DetalleCita>();


    }
    }
