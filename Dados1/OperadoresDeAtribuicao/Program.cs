using System;
namespace OperadoresDeAtribuicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine($"Valor inicial: {x}");
            Console.WriteLine($"1° = {x += 5}");
            Console.WriteLine($"2° = {x -= 3}");
            Console.WriteLine($"3° = {x *= 2}");
            Console.WriteLine($"4° = {x /= 4}");
            Console.WriteLine($"5° = {x %= 3}");
        }
    }
}