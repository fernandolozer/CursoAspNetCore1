using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore_EF7_Entidades.Models
{
    public class Aluno
    {
        // DbContexto = BancoEscolaUVV

        public int ID { get; set; }
        public string NomeAluno { get; set; }
        public string Email { get; set; }
        public int Ano { get; set; }

        [Display(Name = "Professor")]
        public int ProfessorID { get; set; }

        // virtual = permite navegação
        // LazyLoading - Carrega ou não pai + filhos
        public virtual Professor Professor { get; set; }
    }
}
