using System;
using System.Collections.Generic;
using System.Linq; // Added for conversion and sorting

namespace Randomm
{
    internal class SorteoMegaSena
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            var numerosSorteados = new HashSet<int>();

            // 1. Generate 6 unique numbers
            while (numerosSorteados.Count < 6)
            {
                numerosSorteados.Add(random.Next(1, 61));
            }

            // 2. Convert to List and Sort
            var resultado = numerosSorteados.ToList();
            resultado.Sort();

            // 3. Display results
            Console.WriteLine("--- Resultados Mega Sena ---");
            Console.WriteLine(string.Join(" - ", resultado));
            Console.WriteLine("----------------------------");
        }
    }
}