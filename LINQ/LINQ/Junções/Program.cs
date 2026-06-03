using System;
using System.Collections.Generic;
using System.Linq;

namespace Agrupamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {

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