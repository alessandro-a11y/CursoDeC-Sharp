using System;
using System.Collections.Generic;

namespace Agregacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Professor pf1 = new Professor("Alessandro");
            Professor pf2 = new Professor("João");
            Professor pf3 = new Professor("Davi");

            Departamento dep1 = new Departamento("Matemática");

            dep1.AdicionarProfessor(pf1);
            dep1.AdicionarProfessor(pf2);
            dep1.AdicionarProfessor(pf3);

            dep1.ListarProfessores();
        }
    }

    internal class Departamento
    {
        public string? Nome { get; set; }

        private List<Professor> professores;

        public Departamento(string nome)
        {
            Nome = nome;
            professores = new List<Professor>();
        }

        public void AdicionarProfessor(Professor professor)
        {
            professores.Add(professor);
        }

        public void ListarProfessores()
        {
            if (professores.Count > 0)
            {
                Console.WriteLine($"Professores do departamento {Nome}:");

                foreach (var professor in professores)
                {
                    Console.WriteLine(professor.Nome);
                }
            }
            else
            {
                Console.WriteLine($"O departamento {Nome} não tem professores.");
            }
        }
    }

    internal class Professor
    {
        public string? Nome { get; set; }

        public Professor(string nome)
        {
            Nome = nome;
        }
    }
}