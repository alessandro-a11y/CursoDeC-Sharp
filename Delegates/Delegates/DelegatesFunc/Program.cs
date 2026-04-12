using System;
namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> raizQuadrada = n => Math.Sqrt(n);

            Console.WriteLine("Digite um número:");
            double numero = double.Parse(Console.ReadLine());

            double resultado = raizQuadrada(numero);
            Console.WriteLine($"A raiz quadrada de {numero} é {resultado}");
        }
    }
}