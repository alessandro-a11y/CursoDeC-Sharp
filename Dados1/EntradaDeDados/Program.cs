using System;
namespace EntradaDeDados
{
    internal class Program 
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Informe o seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}");
            Console.ReadKey();
        }

    }
}