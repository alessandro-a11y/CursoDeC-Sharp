using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Iniciando...");

        await ProcessoRapidoAsync();

        int resultado = await BuscarValorAsync(true);
        Console.WriteLine($"Resultado: {resultado}");

        resultado = await BuscarValorAsync(false);
        Console.WriteLine($"Resultado: {resultado}");

        Console.WriteLine("Finalizado.");
    }

    // ValueTask (sem retorno)
    static ValueTask ProcessoRapidoAsync()
    {
        Console.WriteLine("Processo rápido executado sem await.");
        return ValueTask.CompletedTask; // já concluído (sem alocar Task)
    }

    // ValueTask<T> (com retorno)
    static ValueTask<int> BuscarValorAsync(bool cache)
    {
        if (cache)
        {
            // retorno imediato (sem criar Task)
            return new ValueTask<int>(42);
        }

        // simula operação assíncrona real
        return new ValueTask<int>(BuscarNoBancoAsync());
    }

    static async Task<int> BuscarNoBancoAsync()
    {
        await Task.Delay(2000); // simula I/O
        return 100;
    }
}