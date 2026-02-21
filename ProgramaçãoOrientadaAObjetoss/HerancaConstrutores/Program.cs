using System;
using System.Collections.Generic;

namespace HerancaConstrutores
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Aluno aluno = new Aluno();
          Aluno aluno2 = new Aluno("João");
        }
    }
    public class Pessoa
    {
        public Pessoa()
        {
            Console.WriteLine("Construtor da classe Pessoa");
        }
        public Pessoa(string nome)
        {
            Console.WriteLine("Construtor da classe Pessoa com parâmetro: " + nome);
        }
    }
    // derivada
    public class Aluno : Pessoa
    {
        public Aluno() : base()
        {
            Console.WriteLine("Construtor da classe Aluno");
        }
        public Aluno(string nome) : base(nome)
        {
             Console.WriteLine("Construtor da classe Aluno com parâmetro: " + nome);
        }
    }
}