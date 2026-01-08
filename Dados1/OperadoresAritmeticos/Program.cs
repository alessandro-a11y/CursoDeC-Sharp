using System;
namespace OperadoresAritmeticos
{
    internal class Progra
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor de x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor de y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Soma: {x+y}");
            Console.WriteLine($"Subtração: {x-y}");
            Console.WriteLine($"Multiplicação: {x*y}");
            Console.WriteLine($"Divisão: {x/y}");
            Console.WriteLine($"Módulo: {x%y}");
        }
    }
}