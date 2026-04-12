using System;
namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número inteiro");
            int numero = int.Parse(Console.ReadLine());

            Action<int> dobra = n => Console.WriteLine($"O dobro de {n} é {n * 2}");
        }
    }
}