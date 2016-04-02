using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace LinguagemCS6
{
    class TestarNulos
    {
        static void Main(string[] args)
        {
            var medic = new Medico() { ID = 1, Nome = "Grinch" };
            WriteLine($"douto {medic.Nome} tem {(medic.Paciente != null ? medic.Paciente.Count() : 0)} pacientes");

            // jeito novo
            WriteLine($"douto {medic.Nome} tem { medic.Paciente?.Count ?? 0} pacientes");


            var objM = new Medico()
            {
                ID = 2,
                Nome = "Melina",
                Paciente = new List<Paciente> {
                    new Paciente {ID = 1, NomePaciente = "Evandro", ValorConsulta = 150 },
                    new Paciente {ID = 1, NomePaciente = "Maria", ValorConsulta = 180, Remedios = "dorflex" },
                }
            };
            WriteLine($"Dr(a) {objM.Nome} tem {objM.Paciente?.Count ?? 0} pacientes");

            decimal receita = 0;
            // codigo tradicional
            if (objM.Paciente!= null)
            {
                receita = objM.Paciente.Sum(p => p.ValorConsulta);
            }
            WriteLine(receita);
            // usando o null checking 
            decimal? receita2 = objM.Paciente?.Sum(v => v.ValorConsulta)??0;
            WriteLine(receita2);



            // 3 - checar outros nulos
            WriteLine($"HISTORICO DOS PACIENTES ------------ Dr(a) {objM.Nome} ");
            objM = null;
            foreach (var p in objM?.Paciente ?? null)
            {
                //WriteLine($"--- {p.NomePaciente} - remédios: {(p.Remedios == null ? "sem remedios" : p.Remedios)} - histórico: {p?.Historico}");
                WriteLine($"--- {p.NomePaciente} - remédios: {p?.Remedios ?? "sem remedios"} - histórico: {p?.Historico}");
            }
            
            WriteLine($"Dr(a) {objM.Nome} tem {objM.Paciente?.Count ?? 0} pacientes");


            ReadKey();


        }


        class Medico
        {
            public int ID { get; set; }
            public string Nome { get; set; }
            public List<Paciente> Paciente { get; set; }
        }

        class Paciente
        {
            public int ID { get; set; }
            public string NomePaciente { get; set; }
            public string Historico { get; set; } = "nada relatado";
            public string Remedios { get; set; }
            public decimal ValorConsulta { get; set; }
        }

    }
}
