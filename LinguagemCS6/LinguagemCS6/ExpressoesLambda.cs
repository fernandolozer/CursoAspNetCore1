using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinguagemCS6
{
    class ExpressoesLambda
    {
        static void Main(string[] args)
        {
            int contador = 0;

            // quanto tem apenas um parametro no func, será o retorno
            // o () vazio significa que não tem parametroos

            Func<int> numero = () => ++contador;

            WriteLine(numero());
            WriteLine(numero());
            WriteLine(numero());

            WriteLine(contador);

            // Exercicio: Quantos Caracteres tem a expressao "Phidelis"?

            var phi = "Phidelis";

            // forma tradicional
            WriteLine(conta(phi));

            // usando Func
            // string é a entrada / int é a saída
            // l.Lenght => fórmula do método a ser criado runtime
            // como escrever a Func?
            // Func<entradas(16), saída(1)> método = exp => fórmula
            Func<string, int> metodoContaLetras = l => l.Length;
            WriteLine(metodoContaLetras(phi));


            // outro exercicio - Contar quantas palavras tem uma string.

            Func<string, int> contaPalavras = f => f.Trim().Split(' ').Count(x => !string.IsNullOrWhiteSpace(x));
            Console.WriteLine("Conta palavras");
            Console.WriteLine(contaPalavras("    teste de    quantidade     de palavras   "));

            // calcular o imposto
            // valor = int
            // perc = decimal
            // saida = decimal
            // formula = valor * (perc / 100)
            Console.WriteLine(@"calcular o imposto");
            Func<int, decimal, decimal> imposto = (valor, perc) => valor * (perc / 100);
            WriteLine(imposto(10, 20.3M));


            // calcular o imposto renda (IRFunc)
            // salario, perc, aliquota (decimal)
            // formula: salario * (perc / 100) - aliquota
            // condicao: salario <= 1000 >>> imposto = 0
            // cond ? true : false
            Console.WriteLine("Imposo de Renda");
            Func<decimal, decimal, decimal, decimal> ir = (salario, percentual, aliquota)
                => salario <= 1000 ? 0 : (salario * (percentual / 100)) - aliquota;

            Console.WriteLine(ir(1001M, 10M, 30M));

            var percent = 25M;
            var alqt = 45M;

            var lista = Usuario.Get();

            lista.ForEach(u =>
            {
                var resultir = ir(u.salario, percent, alqt);
                Console.WriteLine($"{u.nome} - Salario: {u.salario:c2} - imposto: {resultir:c2}");
            }
            );


            ReadKey();
        }

        static int conta(string txt)
        {
            return txt.Length;
        }
    }
}
