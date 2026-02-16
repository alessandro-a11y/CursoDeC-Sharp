using System;
using System.Collections.Generic;   
namespace Indexadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var minhaLista = new MinhaLista();
            minhaLista[0] = "Primeiro item";
            Console.WriteLine(minhaLista[0]);
            minhaLista[1] = "Segundo item";
            minhaLista[2] = "Terceiro item";
            Console.WriteLine(minhaLista[1]);
            Console.WriteLine(minhaLista[2]);
        }
    }
    public class MinhaLista
    {
        private string[] dados = new string[10];

        
        public string this[int index]
        {
            get
            {
                return dados[index];
            }
            set
            {
                dados[index] = value;
            }
        }
    }
}