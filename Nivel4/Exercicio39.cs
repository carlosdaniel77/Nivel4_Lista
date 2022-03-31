using System;

namespace tarefa
{
    class Exercicio39
    {
        static void Main1(string[] args)
        {
            int numero;
            bool parar = false;
            char letra;

            Console.WriteLine("Programa que leia um número inteiro e mostre uma mensagem indicando se este número é par ou ímpar!\n\n");

            do
            {
                Console.WriteLine("Informe um número inteiro: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é par!\n");
                }
                else
                {
                    Console.WriteLine("O número não é par!\n");
                }

                if (numero < 0)
                {
                    Console.WriteLine("O número é negativo!\n");
                }
                else
                {
                    Console.WriteLine("O número é positivo!\n");
                }

                Console.WriteLine("Deseja sair? (s/N)?");
                letra = Convert.ToChar(Console.ReadLine());
                if (letra == 's' || letra == 'S')
                {
                    parar = true;
                }
            } while (parar == false);
        }
    }
}
