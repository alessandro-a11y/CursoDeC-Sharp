using System;
namespace TratamentosDeErros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("x / y");
                Console.WriteLine("x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("y: ");
                int y = Convert.ToInt32(Console.ReadLine());
                int resultado = x / y;
                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("0 não pode");
                Console.WriteLine($"\nDetalhes do erro: {ex.Message}");
                Console.WriteLine($"\nDetalhes: {ex?.StackTrace.ToString()}");
            }
            finally
            {
                Console.WriteLine("Fim do programa");
            }
        }
    }
}