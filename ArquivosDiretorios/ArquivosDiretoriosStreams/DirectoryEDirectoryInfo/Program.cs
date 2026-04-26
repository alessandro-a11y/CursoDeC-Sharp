using System.IO;

namespace ArquivosDiretoriosStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var caminhoDiretorio = @"C:\Users\Public\Documents\NovoDiretorio";

            try
            {
                if (!Directory.Exists(caminhoDiretorio))
                {
                    Directory.CreateDirectory(caminhoDiretorio);
                    Console.WriteLine($"Diretório criado em: {caminhoDiretorio}");

                }
                else
                {
                    Console.WriteLine($"O diretório já existe em: {caminhoDiretorio}");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}