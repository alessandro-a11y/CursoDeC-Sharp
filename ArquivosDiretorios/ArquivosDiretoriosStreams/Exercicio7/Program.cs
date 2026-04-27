using System;
using System.IO;
using System.Security.Cryptography;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o caminho do diretório:");
            string caminhoDiretorio = Console.ReadLine() ?? "";

            try
            {
                if (!Directory.Exists(caminhoDiretorio))
                {
                    Console.WriteLine("Diretório não encontrado.");
                    return;
                }

                string[] arquivos = Directory.GetFiles(caminhoDiretorio);

                foreach (string arquivo in arquivos)
                {
                    Console.WriteLine(arquivo);
                }

                foreach (string arquivo in arquivos)
                {
                    string nome = Path.GetFileName(arquivo);
                    Console.WriteLine(nome);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}