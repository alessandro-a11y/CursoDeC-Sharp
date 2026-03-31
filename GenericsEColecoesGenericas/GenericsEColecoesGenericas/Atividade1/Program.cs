using System;
using System.Collections.Generic;
using System.Numerics;

namespace Atividade1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Escreva um programa 
            para adicionar dois números 
            inteiros usando o conceito de Generics.
             */

            var calculadora = new Calculadora<int>();
            calculadora.Adicionar(5, 10);

        }
    }
    class Calculadora<T> where T : INumber<T>
    {
        public T Adicionar(T a, T b)
        {
            return a + b;
        }
    }
}