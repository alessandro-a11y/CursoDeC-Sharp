//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace ExercicioFinal
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            List<string> frutas = new List<string>
//            {
//                "Maça", "Banana",
//                "Uva", "Manga",
//                "Pera", "Laranja",
//                "Abacate", "Mamao",
//                "Pessego", "Amora"
//            };

//            foreach (var item in frutas)
//            {
//                Console.WriteLine(item);
//            }

//            Console.WriteLine($"\nQuantidade de elementos na lista de frutas:" +
//                $" {frutas.Count} ");

//            Console.WriteLine($"\nSegunda fruta: {frutas[1]}");
//            Console.WriteLine($"Penúltima fruta: {frutas[8]}\n");

//            frutas[2] = "Kiwi";
//            frutas[9] = "Caqui";


//            foreach (var item2 in frutas)
//            {
//                Console.WriteLine(item2);
//            }
//            frutas.Sort();
//            Console.WriteLine("\nLista em ordem alfabética");

//            foreach (var item3 in frutas)
//            {
//                Console.WriteLine(item3);
//            }

//            frutas.Reverse();

//            Console.WriteLine("\nFrutas em ordem invertidas");

//            foreach (var item4 in frutas)
//            {
//                Console.WriteLine(item4);
//            }
//        }
//    }
//}