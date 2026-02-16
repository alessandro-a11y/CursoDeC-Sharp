using System;
namespace ConstrutorStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Alessandro", 18);

            Console.WriteLine($"{p1.Nome} - {p1.idade}");
            Console.WriteLine($"Idade mínima: {Pessoa.IdadeMinima}");

            Pessoa p2 = new Pessoa("Alessandro", 18);
            Console.WriteLine($"{p2.Nome} - {p2.idade}");
            Console.WriteLine($"Idade mínima: {Pessoa.IdadeMinima}");

        }
    }
}