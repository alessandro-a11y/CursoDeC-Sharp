//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace exercicios
//{
//    internal class Exe9
//    {
//        static void Main(string[] args)
//        {
//            /*11- Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números 
//inteiros. (considere que na divisão podemos ter números fracionários e que não existe divisão por zero e 
//quando isso ocorrer exibir uma mensagem de alerta)
//             */
//            Console.WriteLine("Digite o primeiro número inteiro:");
//            int numberone = int.Parse(Console.ReadLine());
//            Console.WriteLine("Informe p operando: (+, -, *, /)");
//            string operando = Console.ReadLine();
//            Console.WriteLine("Digite o segundo número inteiro:");
//            int numbertwo = int.Parse(Console.ReadLine());
            
//            if (numberone == 0 || numbertwo == 0)
//            {
//                Console.WriteLine("Alerta: Não é possível realizar divisão por zero.");
//            }
//            else
//            {
//                switch (operando)
//                {
//                    case "+":
//                        Console.WriteLine($"Resultado: {numberone + numbertwo}");
//                        break;
//                    case "-":
//                        Console.WriteLine($"Resultado: {numberone - numbertwo}");
//                        break;
//                    case "*":
//                        Console.WriteLine($"Resultado: {numberone * numbertwo}");
//                        break;
//                    case "/":
//                        double resultado = (double)numberone / numbertwo;
//                        Console.WriteLine($"Resultado: {resultado}");
//                        break;
//                    default:
//                        Console.WriteLine("Operando inválido. Por favor, use +, -, * ou /.");
//                        break;
//                }
//            }
//        }
//    }
//}
