using System;

namespace tarefa
{
    class Exercicio44
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            char letra;
            int opcao;

            Console.WriteLine("Programa que exiba as opções!\n\n");

            do
            {
                do
                {
                    Console.WriteLine("Escolha uma das opções:\n\t 1 – Conversão de Graus Celsius em Graus Fahrenheit \n\t 2 – Conversão de Graus Fahrenheit em Graus Celsius \n\t 3 – Peso ideal do homem \n\t 4 – Peso ideal da mulher \n\n");
                    opcao = Convert.ToInt32(Console.ReadLine());
                    if (opcao < 1 || opcao > 4) Console.WriteLine("Opção errada!\n");
                } while (opcao < 1 || opcao > 4);
                double celsius, fahrenheit;
                double altura, pesoIdeal;
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite a temperatura em °C: ");
                        celsius = Convert.ToDouble(Console.ReadLine());
                        fahrenheit = (celsius * 9 / 5) + 32;
                        Console.WriteLine("A temperatura convertida é " + fahrenheit + " °F.\n");
                        break;

                    case 2:
                        Console.WriteLine("Digite a temperatura em °F: ");
                        fahrenheit = Convert.ToDouble(Console.ReadLine());
                        celsius = (fahrenheit - 32) * 5 / 9;
                        Console.WriteLine("A temperatura convertida é " + celsius + " °C.\n");
                        break;

                    case 3:
                        Console.WriteLine("Digite a altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        pesoIdeal = (72.7 * altura) - 58;
                        Console.WriteLine("Seu peso ideal é " + pesoIdeal + " kg\n");
                        break;

                    case 4:
                        Console.WriteLine("Digite a altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        pesoIdeal = (62.1 * altura) - 44.7;
                        Console.WriteLine("Seu peso ideal é " + pesoIdeal + " kg\n");
                        break;

                    default:
                        Console.WriteLine("Opção errada.\n");
                        break;
                }

                Console.WriteLine("\nDeseja encerrar o programa? (s/N)");
                letra = Convert.ToChar(Console.ReadLine());
                if (letra == 's' || letra == 'S')
                {
                    continuar = false;
                }
            } while (continuar);
            Console.ReadKey();
        }
    }
}
