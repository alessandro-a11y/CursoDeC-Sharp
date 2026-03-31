using System;
using System.Collections.Generic;

namespace Atividade2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>
            {
                new Aluno("João", 20, "Masculino"),
                new Aluno("Maria", 22, "Feminino"),
                new Aluno("Pedro", 19, "Masculino"),
                new Aluno("Ana", 21, "Feminino")
            };

            Console.WriteLine("Lista de Alunos:\n");
            ExibirInfo(alunos);
        }

        private static void ExibirInfo(List<Aluno> alunos)
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}, Idade: {aluno.Idade}, Sexo: {aluno.Sexo}");
            }
        }

        class Aluno
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
            public string Sexo { get; set; }

            public Aluno(string nome, int idade, string sexo)
            {
                Nome = nome;
                Idade = idade;
                Sexo = sexo;
            }
        }
    }
}