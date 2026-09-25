using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologicaModelos
{
    [Table("Odontologos")]
    public class Odontologo
    {
        [Key]
        [Column("id_odontologo")]
        public int IdOdontologo { get; set; }

        [Column("nombres")]
        [MaxLength(50)]
        [Required]
        public string Nombres { get; set; }

        [Column("apellidos")]
        [MaxLength(50)]
        [Required]
        public string Apellidos { get; set; }

        [Column("registro_medico")]
        [MaxLength(20)]
        [Required]
        public string RegistroMedico { get; set; }

        [ForeignKey("especialidad")]
        [Column("id_especialidad")]
        [Required]
        public int IdEspecialidad { get; set; }
        public Especialidad? especialidad { get; set; }

        List <Cita>? Citas { get; set; } = new List<Cita>();

    }
}
