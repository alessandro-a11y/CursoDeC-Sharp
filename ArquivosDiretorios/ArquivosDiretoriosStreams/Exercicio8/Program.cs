using System;
using System.IO;
using System.Security.Cryptography;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho do diretório: ");
            string caminho = Console.ReadLine();

            try
            {
                DirectoryInfo dir = new DirectoryInfo(caminho);

                if (!dir.Exists)
                {
                    Console.WriteLine("Diretório não encontrado.");
                    return;
                }

                DirectoryInfo[] subDiretorios = dir.GetDirectories();

                foreach (DirectoryInfo subDir in subDiretorios)
                {
                    Console.WriteLine(subDir.Name);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}