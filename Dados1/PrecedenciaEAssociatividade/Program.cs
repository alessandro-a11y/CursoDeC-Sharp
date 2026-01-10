//using System;
//namespace PrecedenciaEAssociatividade
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int a = 10;
//            int b = 20;
//            int c = 30;
//            int d = 40;
//            int resultado = a + b * c - d / a;
//            // multiplicação e divisão têm precedência sobre adição e subtração
//            // então a expressão é avaliada como:
//            // resultado = a + (b * c) - (d / a)
//            Console.WriteLine($"O resultado é: {resultado}");
//            int resultado2 = (a + b) * (c - d) / a;
//            // parênteses alteram a precedência, então esta expressão é avaliada como:
//            // resultado2 = ((a + b) * (c - d)) / a
//            Console.WriteLine($"O resultado2 é: {resultado2}");
//        }
//    }
//}