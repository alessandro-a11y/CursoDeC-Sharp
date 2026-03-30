using System;
using System.Collections.Generic;
namespace ColecoesSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numeros = new List<int>()
            {
                1, 7, 3, 6, 5, 4, 2
            };
            SortedSet<int> numerosOrdenados = new SortedSet<int>(numeros);
            ExibirColecao(numerosOrdenados);

            var frutas = new List<string>() { "uva", "banana", "abacaxi", "laranja" };

            SortedSet<string> frutasOrdenadas = new SortedSet<string>(frutas);
            ExibirColecao(frutasOrdenadas);

            var impares = new int[] { 1, 3, 5, 7, 9 };
            SortedSet<int> numerosImpares = new SortedSet<int>(impares);
            ExibirColecao(numerosImpares);

        }
        static void ExibirColecao<T>(IEnumerable<T> colecao)
        {
            foreach (var item in colecao)
            {
                Console.WriteLine(item);
            }
        }
    }

}
