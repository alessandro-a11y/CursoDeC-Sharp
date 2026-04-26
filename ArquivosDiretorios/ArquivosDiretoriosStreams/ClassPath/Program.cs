using System.IO;

namespace ArquivosDiretoriosStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminho = "C:\\Users\\Public\\Documents\\ArquivoDeOrigem.txt";

            char dirSeparador = Path.DirectorySeparatorChar;
            Console.WriteLine("O separador de diretório padrão é: " + dirSeparador);


            string[] diretorios = caminho.Split(dirSeparador);

            Console.WriteLine("Os diretórios e arquivo no caminho são: ");
            foreach (var item in diretorios)
            {
                Console.WriteLine(item);
            }
        }
    }
}