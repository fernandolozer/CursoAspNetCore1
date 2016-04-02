using static System.Console;
using static System.Math;

namespace LinguagemCS6
{
    class removerUsing
    {
        static void Main(string[] args)
        {
            var anonimo = new { esporte = "lalalala" };
            WriteLine(anonimo.esporte);

            var valor = 98.543M;

            WriteLine(Round(valor));
            WriteLine(Abs(valor));
            WriteLine(Sqrt(4));

            ReadLine();            
        }
    }
}
