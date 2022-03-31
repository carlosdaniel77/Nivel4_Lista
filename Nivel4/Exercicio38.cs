using System;

namespace tarefa
{
    class Exercicio38
    {
        static void Main1(string[] args)
        {
            double c;
            double n;
            double e;
            double sal;
            double hex;
            Console.WriteLine("Programa que leia código e número de horas trabalhadas de um operário!\n\n");
            Console.WriteLine("Informe o número de horas trabalhdas: ");
            n = Convert.ToInt32(Console.ReadLine());

            if(n > 50)
            {
                e = n - 50;
                hex = e * 20;
                sal = 50 * 10;
                Console.WriteLine("Sálario Total e Excedente: " + sal, hex);
            }
            else
            {
                e = 0;
                sal = n * 10;
                Console.WriteLine("Sálario Total e Excedente: "+ sal, e);
            }
            Console.ReadKey();
        }
    }
}
