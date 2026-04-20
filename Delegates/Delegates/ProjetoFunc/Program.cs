using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace ProjetoFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1 = 10;
            int a2 = 5;

            Func<int, int, int> somar = (x, y) => x + y;
            int resultadoSoma = Calcular(a1, a2, somar);
            Console.WriteLine($"{a1} + {a2} = {resultadoSoma}");

            Func<int, int, int> operacaoSub = (a, b) => a - b;
            int resultadoSub = Calcular(a1, a2, operacaoSub);
            Console.WriteLine($"{a1} - {a2} = {resultadoSub}");
        }
        static int Calcular(int a, int b, Func<int, int, int> operacao)
        {
            return operacao(a, b);
        }
    }
}