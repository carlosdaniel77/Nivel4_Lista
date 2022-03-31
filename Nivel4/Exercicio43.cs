using System;

namespace tarefa
{
    class Exercicio43
    {
        static void Main1(string[] args)
        {
            ulong graosCasa = 1;
            double casasTabuleiro = 64;
            ulong graos = 1;

            Console.WriteLine("Programa para calcular o número de grãos que o monge esperava receber!\n\n");

            for (int x = 1; x < casasTabuleiro; x++)
            {
                graosCasa = graosCasa * 2;
                graos += graosCasa;
            }

            Console.WriteLine("A quantidade de grãos é: "+ graos);
            Console.ReadKey();
        }
    }
}
