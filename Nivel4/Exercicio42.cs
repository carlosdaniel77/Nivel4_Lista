using System;

namespace tarefa
{
    class Exercicio42
    {
        static void Main1(string[] args)
        {
            int maior;
            int menor;
            int media;
            int num = 1;

            Console.WriteLine("Programa que determine o maior e o menor entre N números lidos!\n\n");
            Console.WriteLine("Informe um número: ");
            num = Convert.ToInt32(Console.ReadLine());
            maior = num;
            menor = num;
            media = num;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe um número: ");
                num = Convert.ToInt32(Console.ReadLine());
                media = media + num;

                if (num < menor)
                {
                    menor = num;
                }

                if (num > maior)
                {
                    maior = num;
                }
            }

            Console.WriteLine("O maior número é: "+ maior);
            Console.WriteLine("O menor número é: " + menor);
            Console.WriteLine("O média é: " + media);

            Console.ReadKey();
        }
    }
}
