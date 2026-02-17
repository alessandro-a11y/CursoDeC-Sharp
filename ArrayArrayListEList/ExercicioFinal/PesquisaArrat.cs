//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ExercicioFinal
//{
//    internal class PesquisaArrat
//    {
//        private static void Main()
//        {
//            Console.WriteLine("Digite uma quantidade de valores para o array: ");
//            int tamanho = int.Parse(Console.ReadLine());

//            int[] numeros = new int[tamanho];

//            Console.WriteLine("Digite um número, agora vamos fazer buscas na array: ");
//            int numeroBusca = int.Parse(Console.ReadLine());

//            for (int i = 0; i < numeros.Length; i++)
//            {
//                Console.WriteLine($"Digite o {i + 1}º número: ");
//                numeros[i] = int.Parse(Console.ReadLine());
//            }

//            bool encontrado = false;
//            for (int i = 0; i < numeros.Length; i++)
//            {
//                if (numeros[i] == numeroBusca)
//                {
//                    encontrado = true;
//                    Console.WriteLine($"Número {numeroBusca} encontrado na posição {i}.");
//                    break;
//                }
//            }

//            if (!encontrado)
//            {
//                Console.WriteLine($"Número {numeroBusca} não encontrado no array.");
//            }
//        }
//    }
//}
