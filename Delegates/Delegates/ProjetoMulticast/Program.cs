using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoMulticast
{
    internal class Program
    {
        public delegate void MulticastBoasVindas();
        static void Main(string[] args)
        {
            MulticastBoasVindas boasVindas = BoasVindasPT;
            boasVindas += BoasVindasEN;

            boasVindas();
        }
        static void BoasVindasPT()
        {
            Console.WriteLine("Bem-vindo ao Projeto Multicast!");
        }
        static void BoasVindasEN()
        {
            Console.WriteLine("Welcome to the Multicast Project!");
        }
    }
}