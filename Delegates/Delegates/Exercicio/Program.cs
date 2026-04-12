using System;
namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());

            Predicate<int> ehPar = n => n % 2 == 0 ? true : false;

            if(ehPar(numero))
            {
                Console.WriteLine("O número é par.");
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
            }
        }
    }
}