//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace exercicios
//{
//    internal class exe4
//    {
//        static void Main(string[] args)
//        {
//            /*Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 
//            maneiras diferentes:- Incrementando 2 em cada passo- Incrementando 1 em cada passo - Com e loop infinito (use "break" e "continue")*/
//            Console.WriteLine("Números pares de 10 a 20, exceto 16:\n");
//            Console.WriteLine("1. Incrementando 2 em cada passo:");
//            for (int i = 10; i <= 20; i += 2)
//            {
//                if (i == 16)
//                {
//                    continue;
//                }
//                Console.WriteLine(i);

//            }
//            Console.WriteLine("\n2. Incrementando 1 em cada passo:");
//            for (int i = 10; i <= 20; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    if (i == 16)
//                    {
//                        continue;
//                    }
//                    Console.WriteLine(i);
//                }
//            }
//        }
//    }
//}
