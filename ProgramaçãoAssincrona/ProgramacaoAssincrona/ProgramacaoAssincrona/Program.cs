using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Iniciando...");

        // Task simples (sem retorno)
        Task tarefa1 = ExecutarProcessoAsync();

        // Task<T> (com retorno)
        Task<int> tarefa2 = CalcularSomaAsync(10, 20);

        await tarefa1;

        int resultado = await tarefa2;
        Console.WriteLine($"Resultado da soma: {resultado}");

        Console.WriteLine("Finalizado.");
    }

    // Task (sem retorno)
    static async Task ExecutarProcessoAsync()
    {
        Console.WriteLine("Processo iniciado...");
        await Task.Delay(2000); // simula operação demorada
        Console.WriteLine("Processo finalizado.");
    }

    // Task<T> (com retorno)
    static async Task<int> CalcularSomaAsync(int a, int b)
    {
        await Task.Delay(1500); // simula processamento
        return a + b;
    }
}