using System;
using System.Collections.Generic;
namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();
            numeros.Push(1);


            int[] array1 = new int[] { 2, 3, 4, 5 };
            Stack<int> pilha1 = new Stack<int>(array1);

            var impares = new Stack<int>(3);
            impares.Push(5);

        }
    }
}