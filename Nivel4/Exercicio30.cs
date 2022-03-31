using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Nivel4
{
    class Exercicio30
    {
        static void Main1(string[] args)
        {
            int tabuada;
            Console.WriteLine("Programa de Tabuada!\n\n");
            Console.WriteLine("Digite a tabuada que você deseja: ");
            tabuada = Convert.ToInt32(Console.ReadLine());

            for(int x = 0; x <= 10; x++)
            {
                Console.WriteLine(tabuada + " * " + x + " = " + tabuada * x);
            }
            Console.ReadKey();
        }

    }
}
