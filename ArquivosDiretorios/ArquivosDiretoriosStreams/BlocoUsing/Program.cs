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

            try
            {
                //using FileStream fs = new FileStream(caminho, FileMode.Open, FileAccess.Read);
                using StreamReader leitor = File.OpenText(caminho); //new StreamReader(fs);
                    
                string? linha;
                  while ((linha = leitor.ReadLine()) != null)
                  {
                      Console.WriteLine(linha);
                  }
                    
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}