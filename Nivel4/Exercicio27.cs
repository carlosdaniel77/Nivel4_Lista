using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio27
    {
        static void Main1(string[] args)
        {
            int numeroFatorial;
            int quantidadeNumero;
            int cont = 0;
            int resultado = 0;
            int resultado2 = 0;

            Console.WriteLine("Programa de Fatorial dos Números escolhidos!");
            Console.WriteLine("Informe a quantidade de números: ");
            quantidadeNumero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantidadeNumero; i++)
            {
                Console.WriteLine("Informe o número a ser calculado pelo fatorial: ");
                numeroFatorial = Convert.ToInt32(Console.ReadLine());
                if(numeroFatorial > 0)
                {
                    cont = numeroFatorial;
                    Console.Write(numeroFatorial + " ! = ");
                    while (cont > 1)
                    {
                        cont--;
                        resultado = resultado2 * cont;

                        Console.Write(numeroFatorial + "x");
                        numeroFatorial--;
                        resultado2 += resultado;
                    }
                    Console.WriteLine("1 = " + resultado2);
                }
            }
        }
    }
}
