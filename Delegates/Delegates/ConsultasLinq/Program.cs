using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsultasLinq
{
    internal class Program
    {
        public delegate int OperacaoMatematica(int a, int b);
        static void Main(string[] args)
        {
            OperacaoMatematica operacao = Somar;
            int resultado = operacao.Invoke(5, 5);
            Console.WriteLine($"Resultado: {resultado}");
        }
        public static int Somar(int a, int b)
        {
            return a + b;
        }
    }
}