using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace LinguagemCS6
{
    class Dicionarios
    {
        static void Main(string[] args)
        {
            var cidades = new Dictionary<string, string>
            {
                ["SC"] = "Santa Catarina",
                ["SP"] = "São Paulo",
                ["RS"] = "Rio Grande do Sul"
            };

            WriteLine(cidades["SC"]);
            //WriteLine(cidades["sc"]); // erro
            //WriteLine(cidades[0]); // erro

            foreach (var item in cidades)
            {
                WriteLine($"{item.Key} = {item.Value}");
            }


            var paises = new Dictionary<int, string>
            {
                [1] = "Brasil",
                [2] = "Australia",
                [3] = "Nova Zelandia"
            };

            //---------------- dic com classe
            new Dictionary<int, Produto>
            {
                [1] = new Produto { Nome = "mouse", Preco = 25 },
                [2] = new Produto { Nome = "ultrabook", Preco = 2500 },
                [5] = new Produto { Nome = "impressora", Preco = 500 }
            }.ToList().ForEach(p =>
            WriteLine($"índice: {p.Key} - {p.Value.Nome} | preço: {p.Value.Preco}"));
            

            ReadLine();

        }
    }
}
