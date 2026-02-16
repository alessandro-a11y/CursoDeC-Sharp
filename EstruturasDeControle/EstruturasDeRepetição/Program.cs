//using System;
//namespace EstruturasDeRepetição
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var num = 1;
//            do
//            {
//                Console.WriteLine($"Repetição número {num}");
//                num++;
//                if (num > 5)
//                {
//                    Console.WriteLine("Desejar continuar? s/n");
//                    var resposta = Console.ReadLine().ToLower();
//                    if (resposta == "s")
//                    {
//                        num = 1;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Fim do processamento");
//                        break;
//                    }
//                }
//            } while (num <= 10);
//        }
//    }
//}

//int i = 1;

//repetir:
//Console.WriteLine($"Repetição número {i}");
//i++;
//if (i <= 10)
//{
//    goto repetir;
//}
/*
            int num = 10;
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
*/
//while (true)
//{
//    int indice = 1;
//    Console.WriteLine("Insira um número maior que zero: \n");
//    int numero = Convert.ToInt32(Console.ReadLine());

//    if (numero >= 0)
//    {
//        while (indice <= 10)
//        {
//            Console.WriteLine($"tabuada: {indice} x {numero} = {numero * indice}");
//            indice++;
//        }
//    }
//    else
//    {
//        Console.WriteLine("Número deve ser maior que zero!");
//    }
//    Console.WriteLine("\nDeseja continuar? (s/n)");
//    string resposta = Console.ReadLine().ToLower();

//    if (resposta == "s")
//    {
//        continue;
//    }
//    else
//    {
//        Console.WriteLine("Fim do processamento");
//        break;
//    }

//}
//int x = 0;

//while (x < 5)
//{
//    int y = 0;
//    while (y < 5)
//    {
//        Console.Write($"({x}, {y}) ");
//        y++;
//    }
//    x++;
//    Console.WriteLine();
//}