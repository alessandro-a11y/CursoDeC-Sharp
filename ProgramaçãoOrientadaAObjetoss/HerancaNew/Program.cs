using System;
using System.Collections.Generic;

namespace HerancaNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new();
            aluno.Nome = "João";
            aluno.Curso = "Engenharia de Software";
            Console.WriteLine(aluno.Saudacao());
        }
    }
    public class Pessoa
    {
        public string? Nome { get; set; }
        public string Saudacao() => $"Olá, meu nome é {Nome}";
    }
    public class Aluno : Pessoa
    {
        public string? Curso { get; set; }
        public new string Saudacao() => $"Olá, meu nome é {Nome} e estou cursando {Curso}";
    }
}