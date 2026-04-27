using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace ExercicioStreams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = @"C:\Users\marce\OneDrive\Área de Trabalho\Exercicios C#\ExercicioStreams\ExercicioStreams\bin\Debug\net10.0\arquivo.txt";
            FileStream fs = null;
            StreamReader leitor = null;

            try
            {
                fs = new FileStream(caminho, FileMode.Open, FileAccess.Read);
                leitor = new StreamReader(fs);

                string? linha;
                while ((linha = leitor.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Erro de I/O: " + ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro: " + ex.Message);
            }
            finally
            {
                if (leitor != null)
                    leitor.Close();
                if (fs != null)
                    fs.Close();
            }
        }
    }
}