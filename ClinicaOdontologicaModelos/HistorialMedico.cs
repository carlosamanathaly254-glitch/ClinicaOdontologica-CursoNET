using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaOdontologicaModelos
{
    [Table("HistorialesMedicos")]
    public class HistorialMedico
    {
        [Key]
        [Column("id_historial_medico")]
        public int IdHistorialMedico { get; set; }

        [Column("alergias")]
        [MaxLength(100)]
        public string alergias { get; set; }

        [Column("enfermedades")]
        [MaxLength(100)]
        public string enfermedades { get; set; }

        [Column("tipo_sangre")]
        [MaxLength(10)]
        public string tipoSangre { get; set; }

        [ForeignKey("paciente")]
        [Column("id_paciente")]
        public int IdPaciente { get; set; }
        public Paciente? paciente { get; set; }

        //PONER OBJETOS DE NAVEGACION CUANDO HAY MAS DE UNA FOREIGNKEY
    }
}
