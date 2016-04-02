using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguagemCS6
{
    class IniciarPropriedades
    {
        static void Main(string[] args)
        {
            // exercicio 1 - string interpolation 1
            var prod = new Produto
            {
                ID = 123,
                Nome = "Fubá"
            };

            Console.WriteLine($"{prod.ID} - {prod.Nome} - {prod.Preco}");


            // exercicio 2 - interpolation + lista de objetos
            List<Produto> lista = new List<Produto>();
            for (int i = 0; i < 5; i++)
            {
                lista.Add(new Produto { ID = i + 1, Nome = "produto" + i, Qtde = i });
            }
            foreach (var item in lista)
            {
                Console.WriteLine($"{item.ID} - {item.Nome} - {item.Preco}");
            }
            Console.WriteLine("-- todos da lista");


            // solucao renato
            new List<Produto>()
            {
                new Produto { ID = 1, Nome = "teste1" },
                new Produto { ID = 2, Nome = "teste1" },
                new Produto { ID = 3, Nome = "teste1" },
                new Produto { ID = 4, Nome = "teste1" }
            }.ToList().ForEach(p =>
                Console.WriteLine($"{p.ID} - {p.Nome}")
            ) ;

            Console.ReadKey();

        }


    }

    public class Produto
    {
        public int ID { get; set; } = 0;
        public string Nome { get; set; } = "Produto novo";
        public decimal Preco { get; set; } = 8.99M;
        public double Qtde { get; set; } = 10;
        public bool Ativo { get; set; } = true;

    }
}
