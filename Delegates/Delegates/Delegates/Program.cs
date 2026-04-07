using System;

namespace Delegates
{
    internal class Program
    {
        // Delegate
        public delegate void Operacao(int a, int b);

        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();

            // Forma explícita (raiz)
            Operacao op = new Operacao(calc.Somar);
            op.Invoke(10, 5);

            op = new Operacao(calc.Multiplicar);
            op.Invoke(10, 5);

            Console.ReadLine();
        }
    }

    class Calculadora
    {
        public void Somar(int a, int b)
        {
            Console.WriteLine("Soma: " + (a + b));
        }

        public void Multiplicar(int a, int b)
        {
            Console.WriteLine("Multiplicação: " + (a * b));
        }
    }
}