using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace controle_escolar.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        public string Matricula { get; set; }

        public string Nome { get; set; }
        

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }

    }
}
