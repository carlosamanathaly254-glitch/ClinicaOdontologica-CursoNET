using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologicaModelos
{
    [Table("citas")]
    public class Cita
    {
        [Key]
        [Column("id_cita")]
        public int IdCita { get; set; }

        [Column("fecha_cita")]
        [Required]
        public DateTime FechaCita { get; set; }

        [Column("motivo")]
        [MaxLength(200)]
        [Required]
        public string Motivo { get; set; }

        [Column("estado_cita")]
        [MaxLength(20)]
        [Required]
        public string EstadoCita { get; set; }

        [ForeignKey("paciente")]
        [Column("id_paciente")]
        public int IdPaciente { get; set; }
        

        [ForeignKey("odontologo")]
        [Column("id_odontologo")]
        public int IdOdontologo { get; set; }
        

        [ForeignKey("consultorio")]
        [Column("id_consultorio")]
        public int IdConsultorio { get; set; }
        


        //Objetos de navegación
        public Paciente? paciente { get; set; }
        public Odontologo? odontologo { get; set; }
        public Consultorio? consultorio { get; set; }


        // Relaciones
        List<DetalleCita>? DetallesCita { get; set; } = new List<DetalleCita>();
        List<Receta>? Recetas { get; set; } = new List<Receta>();
    }
}
