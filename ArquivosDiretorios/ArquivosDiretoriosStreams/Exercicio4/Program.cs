using System;
using System.IO;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"d:\dados\exercicio.txt";

            try
            {
                using(StreamWriter sw = new StreamWriter(caminho))
                {
                    sw.WriteLine("Primeira linha");
                    sw.WriteLine("Segunda linha");
                }
                using (StreamWriter sw = new StreamWriter(caminho, true))
                {
                    sw.WriteLine("Terceira linha (adicionada)");
                    sw.WriteLine("Quarta linha (adicionada)");
                }
                using (StreamReader sr = new StreamReader(caminho))
                {
                    string? linha;
                    while ((linha = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}