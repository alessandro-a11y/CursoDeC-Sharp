//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace EstruturasDeRepetição
//{
//    internal class @for
//    {
//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                Console.WriteLine("Informe um número inteiro: \n");
//                int numero = Convert.ToInt32(Console.ReadLine());
//                if (numero < 0)
//                {
//                    Console.WriteLine("Número inválido! Tente novamente. \n");
//                    continue;
//                }
//                else
//                {
//                    for (int i = 1; i <= 10; i++)
//                    {
//                        int resultado = numero * i;
//                        Console.WriteLine($"{numero} x {i} = {resultado}");
//                    }
//                    Console.WriteLine("Deseja continuar a tabuada? s/n \n ");
//                    string resposta = Console.ReadLine().ToLower();
//                    if (resposta != "s")
//                    {
//                        break;
//                    }
//                }
//            }
//            Console.WriteLine("Fim do processamento!");
//        }
//    }
//}
