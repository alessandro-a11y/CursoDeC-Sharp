using System;
using System.Linq; 
using System.Collections.Generic;

namespace Eventos
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] frutas = { "Maçã", "Banana", "Uva", "Kiwi", "Manga" };

            // Filtra strings que possuem a letra 'a' (minúscula ou maiúscula)
            var comLetraA = frutas.Where(f => f.Contains("a", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Frutas com 'a': " + string.Join(", ", comLetraA));
            // Resultado: Maçã, Banana, Uva, Manga

            int[] numeros = { 5, 2, 8, 1, 9, 3 };

            // Ordena os números em ordem crescente
            var ordenados = numeros.OrderBy(n => n);

            Console.WriteLine("Ordenados: " + string.Join(", ", ordenados));
            // Resultado: 1, 2, 3, 5, 8, 9

            string[] nomes = { "Ana", "João", "Bia", "Paulo", "Lucas" };

            // Agrupa pelo tamanho da palavra
            var agrupados = nomes.GroupBy(n => n.Length);

            foreach (var grupo in agrupados)
            {
                Console.WriteLine($"Palavras com {grupo.Key} letras: {string.Join(", ", grupo)}");
            }
            /* Resultado: 
               Palavras com 3 letras: Ana, Bia
               Palavras com 4 letras: João
               Palavras com 5 letras: Paulo, Lucas 
            */

            int[] listaNumeros = { 1, 3, 7, 4, 9, 10 };

            // Busca o primeiro número que é par (n % 2 == 0)
            int primeiroPar = listaNumeros.FirstOrDefault(n => n % 2 == 0);

            Console.WriteLine("O primeiro número par encontrado é: " + primeiroPar);
            // Resultado: 4
        }
    }
}