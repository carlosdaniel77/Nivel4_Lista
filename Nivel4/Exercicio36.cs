using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio36
    {
        static void Main1(string[] args)
        {
            double media;
            int numero;
            int soma = 0;
            int contador = 0;
            int maior = 0;
            int menor = 0;

            Console.WriteLine("Programa que leia 10 valores inteiros e positivos!\n\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite um número inteiro positivo: ");
                numero = Convert.ToInt32(Console.ReadLine());
                soma += numero;
                contador++;
                if (contador == 1)
                {
                    menor = numero;
                    maior = numero;
                }
                if (numero < 0)
                {
                    i--;
                }
                else if (numero > maior)
                {
                    maior = numero;
                }
                else if (numero < menor)
                {
                    menor = numero;
                }

            }
            media = soma / 10.00;
            Console.WriteLine($"O maior número é " + maior + ".\nO menor número é " + menor + ".\nA média dos números digitado é: " + media);
            Console.ReadKey();       
        }
    }
}
