using System;
using System.Security.Cryptography.X509Certificates;
namespace ClasseseMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            Pessoa p1 = new Pessoa();
            p1.nome = "Alessandro";
            p1.idade = 18;
            p1.sexo = "Masculino";

            Console.WriteLine($"{p1.nome}, {p1.idade}, {p1.sexo}");

            Pessoa p2 = new Pessoa();
            p2.nome = "Maria";
            p2.idade = 25;
            p2.sexo = "Feminino";

            Console.WriteLine($"{p2.nome}, {p2.idade}, {p2.sexo}");

        }
    }
    class Pessoa
    {
        public string? nome;
        public int? idade;
        public string? sexo;
    }
}

