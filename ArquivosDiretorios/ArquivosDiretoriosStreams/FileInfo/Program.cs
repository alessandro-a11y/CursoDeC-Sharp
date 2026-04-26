using System;
using System.IO;

namespace ManipulacaoArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var caminhoOrigem = @"c:\dados\poesia.txt";
            var caminhoDestino = @"c:\dados\txt\poesia.txt";
            var caminhoCopia = @"c:\dados\poesia_copia.txt";

            try
            {
                FileInfo arquivoOrigem = new FileInfo(caminhoOrigem);
                Console.WriteLine($"\nNome do arquivo: {arquivoOrigem.Name}");
                Console.WriteLine($"\nCaminho completo do arquivo: {arquivoOrigem.FullName}");
                Console.WriteLine($"\nO arquivoé somente leitura: {arquivoOrigem.IsReadOnly}");

                var diretorioPai = arquivoOrigem.Directory;

                Console.WriteLine($"\nNome do diretório: {diretorioPai.Name}");

                Console.WriteLine($"\nTamanho do arquivo: {arquivoOrigem.Length} bytes");

                Console.WriteLine($"\nÚltima gravação: {arquivoOrigem.LastWriteTime}");

                if (arquivoOrigem.Exists)
                {
                    arquivoOrigem.CopyTo(caminhoCopia, true);
                    Console.WriteLine($"\nArquivo copiado para: {caminhoCopia}");
                }
                else
                {
                    Console.WriteLine("\nO arquivo de origem não existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }
    }
}