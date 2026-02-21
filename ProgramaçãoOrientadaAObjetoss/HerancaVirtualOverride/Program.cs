using System;
using System.Collections.Generic;

namespace HerancaOverrideVirtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa { Nome = "Maria" };
            Console.WriteLine(pessoa.Saudacao());
        }
    }
    public class Pessoa
    {
        public string? Nome { get; set; }
        public virtual string Saudacao() => $"Olá, meu nome é {Nome}";
    }
    public class Aluno : Pessoa
    {
        public string? Curso { get; set; }
        public override string Saudacao() => $"Olá, meu nome é {Nome} e estou cursando {Curso}";
    }
}