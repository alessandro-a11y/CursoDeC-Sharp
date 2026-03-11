using System;
namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LivroFotos album1 = new LivroFotos();
            LivroFotos album2 = new LivroFotos(24);
            SuperLivroFotos album3 = new SuperLivroFotos();

            Console.WriteLine(album1.GetNumeroPaginas());
            Console.WriteLine(album2.GetNumeroPaginas());
            Console.WriteLine(album3.GetNumeroPaginas());
        }
    }
}