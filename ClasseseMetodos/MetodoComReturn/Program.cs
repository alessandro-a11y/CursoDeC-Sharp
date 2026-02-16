using System;
namespace MetodoComreturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Calculadora cacl = new Calculadora();

                Console.WriteLine("informe um número: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("informe outro número: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Resultados");
                Console.WriteLine($"Soma: {cacl.Somar(num1, num2)}");
                Console.WriteLine($"Subtração: {cacl.Subtrair(num1, num2)}");
                Console.WriteLine($"Multiplicação: {cacl.Multiplicar(num1, num2)}");
                Console.WriteLine($"Divisão: {cacl.Dividir(num1, num2)}\n");
                Console.WriteLine("deseja continuar? s/n");
                string resp = Console.ReadLine().ToLower();
                if (resp != "s")
                {
                    break;
                }

            }
        }
        public class Calculadora
        {
            public int Somar(int a, int b)
            {
                return a + b;
            }
            public int Subtrair(int a, int b)
            {
                return a - b;
            }
            public int Multiplicar(int a, int b)
            {
                return a * b;
            }
            public int Dividir(int a, int b)
            {
                if (b == 0)
                {
                    Console.WriteLine("A divisão por zero não é permitida.\n");
                    return 0;
                }
                return a / b;
            }
        }
    }
}