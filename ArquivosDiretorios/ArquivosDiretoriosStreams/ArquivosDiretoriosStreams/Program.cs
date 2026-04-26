using System.IO;

namespace ArquivosDiretoriosStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string CaminhoDeOrigem = @"C:\Users\Public\Documents\ArquivoDeOrigem.txt";

            File.WriteAllText(CaminhoDeOrigem, "Olá, este é um arquivo de origem!");

            string novoTexto = File.ReadAllText(CaminhoDeOrigem) + "\nEste é um novo texto adicionado ao arquivo de origem.";

            File.AppendAllText(CaminhoDeOrigem, novoTexto);

            string conteudoFinal = File.ReadAllText(CaminhoDeOrigem);
            Console.WriteLine(conteudoFinal);
        }
    }
}