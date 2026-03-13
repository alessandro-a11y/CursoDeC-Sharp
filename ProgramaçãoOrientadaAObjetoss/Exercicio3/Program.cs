using System;
using System.Collections.Generic;
namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] pessoas = new Pessoa[3];

            Console.Write("Digite o nome do primeiro aluno: ");
            string nome1 = Console.ReadLine();
            pessoas[0] = new Aluno(nome1);

            Console.Write("Digite o nome do segundo aluno: ");
            string nome2 = Console.ReadLine();
            pessoas[1] = new Aluno(nome2);

            Console.Write("Digite o nome do professor: ");
            string nome3 = Console.ReadLine();
            pessoas[2] = new Professor(nome3);

            Console.WriteLine("\n--- Pessoas cadastradas ---");

            foreach (Pessoa p in pessoas)
            {
                Console.WriteLine(p.ToString());

                if (p is Aluno aluno)
                {
                    aluno.Estudar();
                }

                if (p is Professor professor)
                {
                    professor.Ensinar();
                }
            }
        }
    }
}