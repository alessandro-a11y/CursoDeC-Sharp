using System.IO;

namespace ArquivosDiretoriosStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var caminhoDiretorio = @"C:dados";

            var DirOrigem = new DirectoryInfo(caminhoDiretorio);

            Console.WriteLine($"Nome do diretório: {DirOrigem.Name}");
            Console.WriteLine($"\nCaminho completo: {DirOrigem.FullName}");
            Console.WriteLine($"\nData de criação: {DirOrigem.CreationTime}");
            Console.WriteLine($"\nÚltima modificação: {DirOrigem.LastWriteTime}");
            Console.WriteLine($"\nÚltimo acesso: {DirOrigem.LastAccessTime}");
            Console.WriteLine($"\nAtributos: {DirOrigem.Attributes}");


            // criando diretorio

            var novoDiretorio = new DirectoryInfo(@"C:\Users\Public\Documents\NovoDiretorio");

            try
            {
                if (!novoDiretorio.Exists)
                {
                    novoDiretorio.Create();
                    Console.WriteLine($"{novoDiretorio} criado com sucesso");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            // excluindo diretorio

            try
            {
                if (novoDiretorio.Exists)
                {
                    novoDiretorio.Delete();
                    Console.WriteLine($"{novoDiretorio} excluído com sucesso");
                }
                    
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            // listando arquivos do diretorio

            try
            {
                foreach (var item in DirOrigem.GetDirectories())
                {
                    Console.WriteLine(item.Name);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}