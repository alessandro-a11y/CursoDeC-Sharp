//using System;
//namespace ClasseArray
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // Arrays de números
//            int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//            int[] numeros1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//            // Array de nomes
//            string[] nomes = new string[3] { "Ana", "Bia", "Carlos" };

//            // Revertendo o array de números
//            Array.Reverse(numeros1);

//            Console.WriteLine("Array invertido:");
//            foreach (int numero in numeros1)
//            {
//                Console.WriteLine($"{numero}");
//            }

//            // Ordenando o array de números
//            Array.Sort(numeros1);

//            Console.WriteLine("Array ordenado:");
//            foreach (int numero in numeros1)
//            {
//                Console.WriteLine($"{numero}");
//            }

//            // Exibindo números maiores que 5
//            Console.WriteLine("Números maiores que 5:");
//            foreach (int numero in numeros)
//            {
//                if (numero > 5)
//                {
//                    Console.WriteLine($"{numero}");
//                }
//            }

//            // Exibindo nomes com menos de 4 caracteres
//            Console.WriteLine("Nomes com menos de 4 caracteres:");
//            foreach (string nome in nomes)
//            {
//                if (nome.Length < 4)
//                {
//                    Console.WriteLine($"{nome}");
//                }
//            }

//            // Exibindo o segundo valor do array numeros
//            Console.WriteLine("Segundo número do array de números:");
//            Console.WriteLine($"{numeros[1]}");

//            Console.WriteLine("=============");
//        }
//    }
//}
