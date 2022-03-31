using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio32
    {
        static void Main1(string[] args)
        {
            int numero;
            int soma = 0;
            int cont = 0;
            int quadrado;

            Console.WriteLine("Programa que calcula e exiba os números!\n\n");
            do
            {
                Console.WriteLine("Informe um número de 0 a 10: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if(numero < 0 || numero > 10)
                {
                    Console.WriteLine("Valor Inválido!");
                }
            } while (numero < 0 || numero > 10);

            while(cont < 20)
            {
                if (numero % 2 != 0)
                {
                    quadrado = numero * numero;
                    soma += quadrado;
                    cont++;
                }

                numero++;
            }
            Console.WriteLine($"A soma dos 20 primeiros números inteiros positivos ao quadrado ímpares é:\n" + soma);
            Console.ReadKey();      
        }
    }
}
