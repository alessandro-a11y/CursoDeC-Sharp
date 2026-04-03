using System;
namespace TratamentoDeExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite um número inteiro:");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine($"O número digitado foi: {numero}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Erro: O valor digitado não é um número inteiro válido.");
                Console.WriteLine($"Detalhes do erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro inesperado.");
                Console.WriteLine($"Detalhes do erro: {ex.Message}");
            }
        }
    }
}