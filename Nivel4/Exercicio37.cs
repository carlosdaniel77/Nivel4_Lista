using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio37
    {

        static void Main(string[] args)
        {
            double primeiro;
            double segundo;
            int opcao;
            string charOpcao;
            bool encerrar = false;

            Console.WriteLine("Programa de conversão de base numérica!\n\n");
           

            while (encerrar == false)
            { 
                Console.WriteLine("Informe o primeiro número: ");
                primeiro = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o segundo número: ");
                segundo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe uma das opções para as operações:\n1 – Adição\n2 – Subtração\n3 – Multiplicação\n4 – Divisão\nopção: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Resultado de " + primeiro + " + " + segundo + "=" + (primeiro + segundo));
                        break;
                    case 2:
                        Console.WriteLine("Resultado de " + primeiro + " - " + segundo + "=" + (primeiro - segundo));
                        break;
                    case 3:
                        Console.WriteLine("Resultado de " + primeiro + " * " + segundo + "=" + (primeiro * segundo));
                        break;
                    case 4:
                        Console.WriteLine("Resultado de " + primeiro + " / " + segundo + "=" + (primeiro / segundo));
                        break;
                    default:
                        Console.WriteLine("Opção inválida, digite novamente a opção: ");
                        opcao = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                Console.WriteLine("Deseja continuar?(s/n)");
                charOpcao = Console.ReadLine();
                if(charOpcao=="N" || charOpcao == "n")
                {
                    encerrar = true;
                }
            }
            Console.ReadKey();
        }
    }
}
