using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MigrationDicas.Models
{
    public class Professor
    {
        public int ProfessorID { get; set; }

        [Required(ErrorMessage = "Digite o nome do professor")]
        [MinLength(5, ErrorMessage = "o tamanho mínimo deve ser 5 caracteres")]
        [StringLength(200, ErrorMessage = "O tamanho máximo são 200 caracteres")]
        public string Nome { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public decimal? Salario { get; set; }
        public string TwitterBlog { get; set; }
        public string Materia { get; set; }
        public bool Disponivel { get; set; }
        public DateTime? Admissao { get; set; }


        // relacionamento 1 - n
        public virtual List<Aluno> Alunos { get; set; }

    }
}