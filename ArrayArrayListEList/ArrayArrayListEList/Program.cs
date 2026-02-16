using System;
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;
            numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            string[] nomes = new string[3] { "Ana", "Bia", "Carlos" };

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Elementos do indice {i }: {numeros[i] }");
            }
            Console.WriteLine("=============");
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Elementos do indice {i }: {nomes[i] }");
            }


            Console.WriteLine("=============");


        }
    }
}