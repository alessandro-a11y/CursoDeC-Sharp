using System;
using System.Collections.Generic;

namespace ListMetodoFind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> frutas = new List<string>
            {
                "Uva", "Banana", "Pera", "Maçã", "Abacate", "Laranja", "Morango"
            };

            var fruta1 = frutas.Find(Procura);
            Console.WriteLine($"Predicado: {fruta1}");

            var fruta2 = frutas.Find(i => i.Contains('n'));
            Console.WriteLine($"\nFind: {fruta2}");

            var fruta3 = frutas.FindLast(i => i.Contains('n'));
            Console.WriteLine($"\nFindLast: {fruta2}");

            var fruta4 = frutas.FindIndex(i => i.Contains('n'));
            Console.WriteLine($"\nFindLast: indice = {fruta4} item = {frutas[fruta4]}");

            var fruta5 = frutas.FindLastIndex(i => i.Contains('n'));
            Console.WriteLine($"\nFindLast: indice = {fruta5} item = {frutas[fruta5]}");

            var fruta6 = frutas.FindAll(i => i.Contains('n'));
            Console.WriteLine("\nFindALl: ");
            foreach (var item in fruta6)
            {
                Console.WriteLine(item);
            }
        }
    static bool Procura(string item)
        {
            return item.Contains('n');
        }
    } 
}
