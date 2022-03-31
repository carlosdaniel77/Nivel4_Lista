using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio31
    {
        static void Main1(string[] args)
        {
            int numero = 0;
            int quantidadePar = 0;
            int quantidadeImpar = 0;

            Console.WriteLine("Programa de números ímpares e pares!\n\n");
            while (numero >= 0)
            {
                Console.WriteLine("Digite um número(números negativos finalizam): ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero >= 0)
                {
                    if (numero % 2 == 0)
                    {
                        quantidadePar++;
                    }
                    else
                    {
                        quantidadeImpar++;
                    }
                }
            }
            Console.WriteLine("\n\nQuantidade de números pares: " + quantidadePar + "\nQuantidade de números ímpares: " + quantidadeImpar);

            Console.ReadKey();
        }
    }
}
