using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetodoDeExtensao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Usando o método de extensão que criamos
            int resultado = numeros.SomarImpares();

            Console.WriteLine("Lista: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10");
            Console.WriteLine($"A soma dos números ímpares é: {resultado}");
        }
    }
}
