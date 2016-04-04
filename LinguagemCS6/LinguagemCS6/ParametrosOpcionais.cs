using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguagemCS6
{
    public class ParametrosOpcionais
    {

        static void Main(string[] args)
        {
            Console.WriteLine(IR(1800.89M));
            Console.WriteLine(IR(1800.89M, 12));
            Console.WriteLine(IR(1800.89M, 12, 82));
            Console.WriteLine(IR(1800.89M, aliquota: 40));

            Console.ReadLine();
        }

        // regra para opcionais:
        // os obrigatórios DEVEM vir antes de qualquer
        // parâmetro opcional
        static decimal IR(decimal salario,
                          decimal perc = 10,
                          decimal aliquota = 80)
        {
            if (salario <= 1000) return 0;

            return salario * (perc / 100) - aliquota;
        }

    }
}
