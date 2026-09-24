using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;          // <- añadir
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaOdontologicaModelos
{
    [Table("Recetas")]
    public class Receta
    {
        [Key]
        [Column("id_receta", TypeName = "serial")]
        public int IdReceta { get; set; }

        [Column("fecha_emision", TypeName = "date")]
        [Required]
        public DateTime FechaEmision { get; set; }

        [Column("indicaciones", TypeName = "text")]
        [Required]
        public string Indicaciones { get; set; }

        [ForeignKey("cita")]
        [Column("id_cita")]
        public int IdCita { get; set; }
        public Cita? cita { get; set; }
    }
}
