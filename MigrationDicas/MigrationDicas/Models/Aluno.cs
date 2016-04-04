using System;
using System.ComponentModel.DataAnnotations;

namespace MigrationDicas.Models
{
    public class Aluno
    {
        [Key]
        public int AlunoID { get; set; }
        public int ProfessorID { get; set; }
        [Required]
        public string NomeAluno { get; set; }
        public string Email { get; set; }
        public int Ano { get; set; }
        public DateTime? Inscricao { get; set; }

        public virtual Professor Professor { get; set; }
    }
}