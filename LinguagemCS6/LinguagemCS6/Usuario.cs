using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguagemCS6
{
    public partial class Usuario
    {
        public int ID { get; set; }
        public string nome { get; set; }
        public decimal salario { get; set; }
        public string depto { get; set; }

        public static List<Usuario> Get()
        {
            return new List<Usuario>
            {
                new Usuario {ID = 1, nome="Rafael", salario=1400},
                new Usuario {ID = 2, nome="Thiago", salario=12400},
                new Usuario {ID = 3, nome="Eliel", salario=5800.99M},
                new Usuario {ID = 4, nome="Flavio 1", salario=9800.59M},
                new Usuario {ID = 5, nome="Joenne", salario=12400},
                new Usuario {ID = 6, nome="Ailson", salario=4800.89M},
                new Usuario {ID = 7, nome="Ismael", salario=1400},
                new Usuario {ID = 8, nome="Flavio 2", salario=12400},
                new Usuario {ID = 9, nome="Larissa", salario=6400},
                new Usuario {ID = 10, nome="Danilo", salario=7450},
                new Usuario {ID = 11, nome="Felipe", salario=8930},
            };
        }
    }
}
