using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace ProjetoDelegateAction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = Enumerable.Range(1, 20).ToList();

            Action<int> imprimirSePar = n =>
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                }
            };
            Console.WriteLine("---------- Lista de números pares ----------".PadLeft(30));
            numeros.ForEach(imprimirSePar);
        }
    }
}