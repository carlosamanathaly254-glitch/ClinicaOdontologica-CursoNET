using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologicaModelos
{
    [Table("DetalleCitas")]
    public class DetalleCita
    {
        [Key]
        [Column("id_detalle_cita", TypeName = "serial")]
        public int IdDetalleCita { get; set; }

        [Column("costo_aplicado", TypeName = "numeric(10,2)")]
        [Required]
        public decimal CostoAplicado { get; set; }

        [Column("observaciones")]
        [MaxLength(200)]
        [Required]
        public string Observaciones { get; set; }

        [ForeignKey("cita")]
        [Column("id_cita")]
        public int IdCita { get; set; }
        public Cita? cita { get; set; }
    }
}
