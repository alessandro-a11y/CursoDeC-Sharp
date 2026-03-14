using System;
using System.Collections.Generic;
internal class Program
{
    static void Main(string[] args)
    {
        Teste teste = new Teste();
        int i1 = 10;
        int i2 = 20;

        teste.Comparar(i1, i2);


    }
    public class Teste
    {
        public void Comparar<T> (T p1,  T p2)
        {
            var resultado = p1.Equals(p2);
            Console.WriteLine($"{p1} {p2} são iguais ? {resultado}");
        }
    }
}