using System;
using System.Collections.Generic;
namespace ColecoesSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
        var numeros = new HashSet<int>() { 1, 2, 3, 4, 5 };

        var frutas = new HashSet<string>() { "banana", "maçã", "laranja" };

            HashSet<int> pares = new HashSet<int>();

            for (int i = 0; i < 6; i++)
            {
                pares.Add(i * 2);
            }

        var lista1 = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };
        var conjunto = new HashSet<int>(lista1);

        var lista2 = new List<string>
        {
                "uva", "abacaxi", "melancia", "banana"
        };
            HashSet<string> minhasFrutas = new HashSet<string>(lista2);
        }
    }
}