using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace controle_escolar.Models
{
    public class Chamada
    {
        [Key]
        public int IdChamada { get; set; }

        [ForeignKey("Aluno")]
        public int AlunoID { get; set; }
        public virtual Aluno Aluno { get; set; }


        //  [ForeignKey("Turma")]
        public int IdTurma { get; set; }

        public DateTime DataChamada { get; set; }

        public Boolean StatusChamada { get; set; }

    }
}
