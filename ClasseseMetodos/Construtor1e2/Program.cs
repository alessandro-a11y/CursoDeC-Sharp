using System;
namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Alessandro",18);
            Console.WriteLine(cliente.Nome);
            Console.WriteLine(cliente.Idade);
        }
    }
    public class Cliente
    {
        public string? Nome;
        public int Idade;

        public Cliente(string? Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
        }
    }
}
















































//using System;

//namespace Construtor1e2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Aluno aluno = new Aluno("Alessandro", 18, "Masculino", "Sim");

//            Console.WriteLine(aluno.Nome ?? "null");
//            Console.WriteLine(aluno.Idade == 0 ? "não há valor" : aluno.Idade);
//            Console.WriteLine(aluno.Sexo ?? "null");
//            Console.WriteLine(aluno.Aprovado ?? "null");
//        }
//    }

//    public class Aluno
//    {
//        public string? Nome;
//        public int Idade;
//        public string? Sexo;
//        public string? Aprovado;

//        // Construtor 1
//        public Aluno(string nome) => Nome = nome;
//        // Construtor 2 (encadeado)
//        public Aluno(string nome, int idade, string sexo, string aprovado)
//            : this(nome)
//        {
//            Idade = idade;
//            Sexo = sexo;
//            Aprovado = aprovado;
//        }
//    }
//}
