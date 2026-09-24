using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologicaModelos
{
    [Table("Especialidades")]
    public class Especialidad
    {
        [Key]
        [Column("id_especialidad", TypeName = "serial")]
        public int IdEspecialidad { get; set; }

        [Column("nombre_especialidad")]
        [MaxLength(50)]
        [Required]
        public string NombreEspecialidad { get; set; }

        [Column("descripcion")]
        [MaxLength(200)]
        [Required]
        public string Descripcion { get; set; }

        List<Odontologo>? Odontologos { get; set; } = new List<Odontologo>();

    }
}
