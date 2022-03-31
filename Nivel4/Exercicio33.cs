
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivel4
{
    class Exercicio33
    {
        static void Main(string[] args)
        {
            int quantidadeAluno;
            double notaProva;
            double media;
            double somaNota = 0;
            string matricula;

            Console.WriteLine("Programa de exibição da média de alunos em uma prova!\n\n");
            Console.WriteLine("Quantos alunos tem na sala?");
            quantidadeAluno = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= quantidadeAluno; i++)
            {
                Console.WriteLine($"\nInforme a matrícula do {i}º aluno(a): ");
                matricula = Console.ReadLine();
                Console.WriteLine($"\nInforme a nota da prova do {i}º aluno(a): ");
                notaProva = Convert.ToInt32(Console.ReadLine());
                somaNota += notaProva;
            }
            media = somaNota / quantidadeAluno;
            Console.WriteLine($"A média da turma é: " + media);
            Console.ReadKey();
        }

    }
}
