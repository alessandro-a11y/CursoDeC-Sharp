//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace exercicios
//{
//    internal class exe2
//    {
//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                Console.WriteLine("Digite um número maior que 0 e ele será multiplicado: \n");
//                int number = int.Parse(Console.ReadLine());

//                if (number > 0)
//                {
//                    for (int i = 1; i <= 10; i++)
//                    {
//                        int result = number * i;
//                        Console.WriteLine($"{number} x {i} = {result}");
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Número inválido. Por favor, tente novamente.\n");
//                }
//                Console.WriteLine("Deseja continuar? s/n");
//                string resposta = Console.ReadLine().ToLower();
//                if (resposta != "s")
//                {
//                    break;
//                }
//            }
//        }
//    }
//}
