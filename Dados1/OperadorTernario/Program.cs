using System;
namespace OperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a temperatura: \n");
            double temp = Convert.ToDouble(Console.ReadLine());

            var resultado = temp > 27 ? "Quente" : "Normal";

            Console.WriteLine($"A temperatura está {resultado}");
        }
    }
}