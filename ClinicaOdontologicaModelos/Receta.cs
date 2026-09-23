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
        [Column("id_receta")]
        public int IdReceta { get; set; }

        [Column("fecha_emision")]
        [Required]
        public DateTime FechaEmision { get; set; }

        [Column("indicaciones")]
        [Required]
        public string Indicaciones { get; set; }

        [ForeignKey("cita")]
        [Column("id_cita")]
        public int IdCita { get; set; }
        public Cita Cita { get; set; }
    }
}
