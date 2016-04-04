using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MigrationDicas.Models
{
    public class Professor
    {
        public int ProfessorID { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public decimal? Salario { get; set; }
        public string TwitterBlog { get; set; }
        public string Materia { get; set; }

        // relacionamento 1 - n
        public virtual List<Aluno> Alunos { get; set; }

    }
}