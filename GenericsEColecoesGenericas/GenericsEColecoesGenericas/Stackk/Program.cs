using System;
using System.Collections.Generic;
namespace Stackk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> diasSemana = new Stack<string>();
            diasSemana.Push("Segunda-feira");
            diasSemana.Push("Terça-feira");
            diasSemana.Push("Quarta-feira");

            int[] array1 = new int[] { 1, 2, 4, 6, 8 };
            Stack<int> pilhaNumeros = new Stack<int>(array1);

            var lista = new List<string>()
            {
                "Maça", "Banana", "Uva", "Abacaxi"
            };
            var frutas = new Stack<string>(lista);
            var impares = new Stack<int>(3);
            impares.Push(1);
            impares.Push(2);
            impares.Push(3);
        }
    }
}