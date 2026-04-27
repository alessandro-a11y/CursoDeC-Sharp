using System;
using System.IO;
using System.Security.Cryptography;

namespace CriptografiaAES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho do arquivo de origem: ");
            string origem = Console.ReadLine() ?? "";

            Console.Write("Digite o caminho do arquivo criptografado (destino): ");
            string destino = Console.ReadLine() ?? "";

            try
            {
                if (!File.Exists(origem))
                {
                    Console.WriteLine("Arquivo de origem não encontrado.");
                    return;
                }

                byte[] dados = File.ReadAllBytes(origem);

                using (Aes aes = Aes.Create())
                {
   
                    aes.Key = System.Text.Encoding.UTF8.GetBytes("1234567890123456"); // 16 bytes
                    aes.IV = System.Text.Encoding.UTF8.GetBytes("6543210987654321");  // 16 bytes

                    using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                    {
                        byte[] dadosCriptografados = encryptor.TransformFinalBlock(dados, 0, dados.Length);

                        File.WriteAllBytes(destino, dadosCriptografados);
                    }
                }

                Console.WriteLine("Arquivo criptografado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}