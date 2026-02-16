using System;
namespace Randomm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            Console.WriteLine("Número aleatório entre 0 e 100: " + random.Next(0, 101));
            Console.WriteLine("Número aleatório entre 1 e 10: " + random.Next(1, 11));
            Console.WriteLine("Número aleatório entre 50 e 150: " + random.Next(50, 151));
        }
    }   
}