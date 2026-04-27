using System;
using System.IO;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho do arquivo de origem: ");
            string caminhoOrigem = Console.ReadLine() ?? "";

            Console.Write("Digite o caminho de destino: ");
            string caminhoDestino = Console.ReadLine() ?? "";

            try
            {
                if (!File.Exists(caminhoOrigem))
                {
                    Console.WriteLine("Arquivo de origem não encontrado.");
                    return;
                }

                string pastaDestino = Path.GetDirectoryName(caminhoDestino);

                if (!string.IsNullOrEmpty(pastaDestino) && !Directory.Exists(pastaDestino))
                {
                    Directory.CreateDirectory(pastaDestino);
                }

                File.Copy(caminhoOrigem, caminhoDestino, true);

                Console.WriteLine("Arquivo copiado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}