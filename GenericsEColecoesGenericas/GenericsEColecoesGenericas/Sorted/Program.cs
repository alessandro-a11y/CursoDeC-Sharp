using System;
using System.Collections.Generic;
namespace Sorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var brics = new SortedDictionary<int, string>()
            {
                {  3, "Brasil"  },
                { 1, "Rússia" },
                { 4, "Índia" },
                { 2, "China" }
            };
            exibir1(brics);

            Console.WriteLine("--------------------------------------");
            if (!brics.ContainsKey(5))
            {
                brics.Add(5, "África do Sul");
                Console.WriteLine("\nÁfrica do Sul adicionada\n");
                exibir1(brics);

            }
            Console.WriteLine("--------------------------------------");
        }

        private static void exibir1(SortedDictionary<int, string> brics)
        {
            foreach (var item2 in brics)
            {
                Console.WriteLine($"{item2.Key} - {item2.Value}");
            }
        }
    }
}