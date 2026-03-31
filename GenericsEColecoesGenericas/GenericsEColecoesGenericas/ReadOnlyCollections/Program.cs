using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ReadOnlyCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var planetas = new List<string>
            {
                "Mercúrio", "Vênus", "Terra", "Marte", "Júpiter", "Saturno", "Urano", "Netuno"
            };

            var listaPlanetas = new ReadOnlyCollection<string>(planetas);


            Console.WriteLine("\nPlanetas não gasosos do sistemas solar: ");
            foreach (var item in listaPlanetas)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"\n\nPlanetas na coleção: {listaPlanetas.Count()}");


            Console.WriteLine($"\nJúpiter esta na coleção?");
            Console.WriteLine(listaPlanetas.Contains("Júpiter") ? "Sim" : "Não");
            Console.WriteLine($"\nPlaneta do índice 3: {listaPlanetas[3]}");
            Console.WriteLine($"\nIndice do planeta Terra: {listaPlanetas.IndexOf("Terra")}");
            Console.WriteLine("\nInserindo um novo elemento na Lista original ( índice 4 )");
            planetas.Insert(4, "Ceres");
            Console.WriteLine("\nExibindo o novo planeta na lista");

            foreach (var item1 in listaPlanetas)
            {
                Console.WriteLine($"{item1}");

            }
            Console.WriteLine("\n\nCopiando os elementos para um array unidimensional");
            string[] arrayPlanetas = new string[listaPlanetas.Count() + 2];
            listaPlanetas.CopyTo(arrayPlanetas, 1);
            foreach (var item2 in planetas)
            {
                Console.WriteLine($"\"{item2}\"");
            }
        }
    }
}