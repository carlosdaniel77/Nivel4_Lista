using System;

namespace tarefa
{
    class Exercicio41
    {
        static void Main1(string[] args)
        {
            int idade;

            Console.WriteLine("Programa que dada a idade de um nadador, classifica sua categoria!\n\n");
            Console.WriteLine("Informe a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if(idade <= 4)
            {
                Console.WriteLine("Muito Jovem!");
            }

            if (idade >= 5)
            {
                Console.WriteLine("Infantil A!");
            }

            if (idade >= 8)
            {
                Console.WriteLine("Infantil B!");
            }

            if (idade >= 11)
            {
                Console.WriteLine("Juvenil A!");
            }

            if (idade >= 14)
            {
                Console.WriteLine("Juvenil B!");
            }

            if (idade >= 18)
            {
                Console.WriteLine("Adulto!");
            }

            Console.ReadKey();
        }
    }
}
