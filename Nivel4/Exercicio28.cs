using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio28
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Programa que gera e exibe números ímpares!");
            for(int i = 100; i < 200; i++)
            {
                if((i % 2) != 0)
                {
                    Console.WriteLine("Os números ímpares entre 200 e 100 são: "+ i);
                }
            }
        }
    }
}
