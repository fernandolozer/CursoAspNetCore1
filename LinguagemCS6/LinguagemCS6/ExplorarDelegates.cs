using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguagemCS6
{
    public class ExplorarDelegates
    {
        // definição do delegate
        delegate int Operacao(int a, int b = 4, int c = 7);

        static void Main(string[] args)
        {
            var dados = new List<Produto>()
            {
                new Produto { ID = 1, Nome = "Farinha de trigo", Preco=10 },
                new Produto { ID = 2, Nome = "Fuba", Preco=5 },
                new Produto { ID = 3, Nome = "Oleo", Preco=2 },
                new Produto { ID = 4, Nome = "Macarrão", Preco=6 }
            };

            //var filtro = dados

            // modo tradicional
            Console.WriteLine(calcular(10,5));
            Console.ReadKey();

            // usanddo delegate 
            Operacao op = (a, b, c) => (a + b) * c;
            Console.WriteLine(op(1,2,3));
            Console.WriteLine(op(1));
            Console.WriteLine(op(1, c: 3));
            Console.ReadKey();

            // alterar a formula em runtime

            op = (a, b, c) => (int)Math.Pow(c, 2) / (a * b);
            Console.WriteLine(op(1, 2, 3));
            Console.WriteLine(op(1));
            Console.WriteLine(op(1, c: 3));
            Console.ReadKey();



        }

        static int calcular(int a, int b)
        {
            return a + b;
        }
    }
}
