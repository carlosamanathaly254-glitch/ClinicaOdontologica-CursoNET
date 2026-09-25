using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;       // <-- Añadido
using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicaOdontologicaModelos
{
    [Table("Facturas")]
    public class Factura
    {
        [Key]
        [Column("id_factura")]
        public int IdFactura { get; set; }

        [Column("fecha_emision")]
        [Required]
        public DateTime FechaFactura { get; set; }

        [Column("subtotal", TypeName = "decimal(10,2)")]
        [Required]
        public decimal Subtotal { get; set; }

        [Column("impuesto", TypeName = "decimal(10,2)")]
        [Required]
        public decimal Impuesto { get; set; }

        [Column("total", TypeName = "decimal(10,2)")]
        [Required]
        public decimal Total { get; set; }

        [Column("estado_pago")]
        [MaxLength(20)]
        [Required]
        public string EstadoPago { get; set; }


        [ForeignKey("cita")]
        [Column("id_cita")]
        public int IdCita { get; set; }
        public Cita? cita { get; set; }
    }
}
