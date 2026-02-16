//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace exercicios
//{
//    internal class Exe6
//    {
//        static void Main(string[] args)
//        {
//            /*
//            - Escreva um programa para calcular o fatorial de um número inteiro. 
//             O fatorial de um número é representado por : n! =>  n * (n – 1) * (n – 2) ....2*1 
//             Exemplo : fatorial de 6 é representado por  6! = 6*5*4*3*2*1 */
            
//            Console.WriteLine("Digite um número inteiro para calcular o fatorial: ");
//            int number = int.Parse(Console.ReadLine());
//            int resultado = 1;
//            for (int i = number; i >= 1; i--)
//            {
//                resultado *= i;
//            }
//            Console.WriteLine($"o fatorial de {number} é {resultado}");
//        }
//    }
//}
