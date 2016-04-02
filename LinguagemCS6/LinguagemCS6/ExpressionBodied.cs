using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace LinguagemCS6
{
    class ExpressionBodied
    {

        public static decimal CalculaPreco(decimal preco, int quantidade)
            => preco * quantidade;
        static void Main(string[] args)
        {
            WriteLine($"Valor do produto no estoque {CalculaPreco(10,2)}");

            var c = new carro
            {
                ID = 1,
                Modelo = "JEEP",
                AnoFabricacao = 2007,
                KmRodados = 800,
                Litros = 42
            };
            WriteLine($"O carro {c.Modelo}, fabricado em {c.AnoFabricacao} está com {c.Idade()} anos.");
            WriteLine($"Rodando {c.KmRodados} km com {c.Litros} litros, a média é de {c.Consumo():n2} km/litro.");
            WriteLine(c.ToString());

            var c2 = new carro
            {
                ID = 2,
                Modelo = "Landau",
                AnoFabricacao = 1980,
                KmRodados = 1200,
            };

        }
        class carro
        {
            public int ID { get; set; }
            public string Modelo { get; set; }
            public int Litros { get; set; }
            public double KmRodados { get; set; }
            public int AnoFabricacao { get; set; }
            public double Consumo() 
                => KmRodados / Litros;
            public string Idade()
                => (DateTime.Now.Year - AnoFabricacao).ToString();
            public string ConsumoString() 
                => Litros > 0? Consumo().ToString() : null;
            public override string ToString() 
                => $"{ID} - {Modelo}";
        }
    }
}
