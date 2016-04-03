using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore_EF7_Entidades.Models
{
    public class Professor
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Digite o nome do professor")]
        [MinLength(5, ErrorMessage = "o tamanho mínimo deve ser 5 caracteres")]
        [StringLength(200, ErrorMessage = "O tamanho máximo são 200 caracteres")]
        public string Nome { get; set; }
        public string Telefone { get; set; } 
        public decimal? Salario { get; set; } 
        // Relacionamento 1 - n
        public virtual List<Aluno> Alunos { get; set; } 
    }
}
