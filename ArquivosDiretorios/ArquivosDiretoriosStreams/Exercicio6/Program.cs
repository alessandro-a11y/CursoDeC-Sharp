using System;
using System.IO;
using System.Security.Cryptography;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o caminho da imagem (origem): ");
            string origem = Console.ReadLine() ?? "";

            Console.WriteLine("Digite o caminho do arquivo de texto (destino): ");
            string destino = Console.ReadLine() ?? "";

            try
            {
                if (!File.Exists(origem))
                {
                    Console.WriteLine("Arquivo de origem não encontrado.");
                    return;
                }

                byte[] dadosImagem = File.ReadAllBytes(origem);

                string textoBase64 = Convert.ToBase64String(dadosImagem);

                string pastaDestino = Path.GetDirectoryName(destino);

                if (!string.IsNullOrEmpty(pastaDestino) && !Directory.Exists(pastaDestino))
                {
                    Directory.CreateDirectory(pastaDestino);
                }

                File.WriteAllText(destino, textoBase64);

                Console.WriteLine("Imagem convertida para Base64 com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}