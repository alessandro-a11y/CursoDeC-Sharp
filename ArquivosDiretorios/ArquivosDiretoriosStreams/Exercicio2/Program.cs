using System;
using System.IO;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o caminho: ");
            string caminho = Console.ReadLine();

            try
            {
                if (File.Exists(caminho))
                {
                    DateTime datacricao = File.GetCreationTime(caminho);

                    Console.WriteLine("Arquivo Encontrado");
                    Console.WriteLine($"Data de criação: {datacricao}");
                }
                else
                {
                    Console.WriteLine("Arquivo não encontrado");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}