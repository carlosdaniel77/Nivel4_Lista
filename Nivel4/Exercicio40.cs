using System;

namespace tarefa
{
    class Exercicio40
    {
        static void Main1(string[] args)
        {
            double numero;
            bool parar = false;
            char letra;
            
            Console.WriteLine("Programa que leia o índice de poluição medido e emita a notificação adequada aos diferentes grupos de empresas!\n\n");
            do
            {
                do
                {
                    Console.WriteLine("Informe o índice de poluição: ");
                    numero = Convert.ToDouble(Console.ReadLine());
                    if (numero < 0) Console.WriteLine("Número inválido informe um número positivo!");
                } while (numero < 0);

                Console.WriteLine();

                if (numero >= 0 && numero <= 0.25)
                {
                    Console.WriteLine("Índice de poluição aceitável.");
                }

                if (numero >= 0.3)
                {
                    Console.WriteLine("Suspender atividades das indústrias do 1º Grupo!");
                }

                if (numero >= 0.4)
                {
                    Console.WriteLine("Suspender atividades das indústrias do 2º Grupo!");
                }

                if (numero >= 0.5)
                {
                    Console.WriteLine("Suspender atividades das indústrias do 3º Grupo!");
                }

                Console.WriteLine("Deseja encerrar o programa? (s/N)?");
                letra = Convert.ToChar(Console.ReadLine());
                if (letra == 's' || letra == 'S')
                {
                    parar = true;
                }
            } while (parar == false);
        }
    }
}
