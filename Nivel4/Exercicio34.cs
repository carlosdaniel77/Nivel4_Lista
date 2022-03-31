using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio34
    {
        static void Main1(string[] args)
        {
            int numeroAtual;
            double maior;
            double menor;

            Console.WriteLine("Programa que leia um conjunto de números positivos e exiba o menor e o maior!\n\n");
            Console.WriteLine("Informe um número (negativo para sair): ");
            numeroAtual = Convert.ToInt32(Console.ReadLine());

            if (numeroAtual >= 0)
            {
                menor = numeroAtual;
                maior = numeroAtual;
                while (numeroAtual >= 0)
                {
                    Console.WriteLine("Informe outro número: ");
                    numeroAtual = Convert.ToInt32(Console.ReadLine());
                    if (numeroAtual > maior)
                    {
                        maior = numeroAtual;
                    }
                    if (numeroAtual < menor && numeroAtual >= 0)
                    {
                        menor = numeroAtual;
                    }
                }
                Console.WriteLine("\nO maior número foi "+ maior +" e o menor foi: " + menor);
            }           
            Console.ReadKey();
        }
    }
}
