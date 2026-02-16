using System;
namespace MetodosEstaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var soma = Calculadora.Somar(10, 5);
            var subtracao = Calculadora.subtrair(10, 5);
            var multiplicacao = Calculadora.Multiplicar(10, 5);
            var divisao = Calculadora.Dividir(10, 5);

            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Subtração: {subtracao}");
            Console.WriteLine($"Multiplicação: {multiplicacao}");
            Console.WriteLine($"Divisão: {divisao}");

        }
        public class Calculadora
        {
            public static int Somar(int a, int b)
            {
                return a + b;
            }
            public static int subtrair(int a, int b)
            {
                return a - b;
            }
            public static int Multiplicar(int a, int b)
            {
                return a * b;
            }
            public static int Dividir(int a, int b)
            {
                return a / b;
            }
        }  
    }
}