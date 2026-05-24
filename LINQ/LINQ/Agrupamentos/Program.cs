using System;
using System.Collections.Generic;
using System.Linq;

namespace Agrupamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var alunos = FonteDeDados.ObterAlunos();

            var grupos = alunos.GroupBy(x => new { x.Curso, x.Sexo })
                                         .OrderBy(g => g.Key.Curso)
                                         .ThenBy(g => g.Key.Sexo)
                                         .Select(g => new
                                         {
                                             Curso = g.Key.Curso,
                                             Sexo = g.Key.Sexo,
                                             Alunos = g.Select(a => a.Nome).ToList()
                                         });


            foreach (var grupo in grupos)
            {
                Console.WriteLine($"Curso: {grupo.Curso}, Sexo: {grupo.Sexo}");
                Console.WriteLine("Alunos:");
                foreach (var aluno in grupo.Alunos)
                {
                    Console.WriteLine($" - {aluno}");
                }
            }
        }
        public class FonteDeDados
        {
            public class Aluno
            {
                public string Nome { get; set; }
                public string Curso { get; set; }
                public int Idade { get; set; }
                public string Sexo { get; set; }

                public Aluno(string nome, string curso, string sexo, int idade)
                {
                    Nome = nome;
                    Curso = curso;
                    Idade = idade;
                    Sexo = sexo;
                }
            }
            public static List<Aluno> ObterAlunos()
            {
                return new List<Aluno>()
            {
             new Aluno("João", "Java", "Masculino", 20),
             new Aluno("Maria", "C#", "Feminino", 22)
            };
            }
        }
    }
}