using controle_escolar.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace controle_escolar.Models
{
    public class Turma
    {
        [Key]
        public int TurmaId { get; set; }

        public string Nome { get; set; }

        public ETurno Turno { get; set; }

    }
}
