using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // 🔹 Token principal (manual)
        using var ctsManual = new CancellationTokenSource();

        // 🔹 Token com timeout automático
        using var ctsTimeout = new CancellationTokenSource(TimeSpan.FromSeconds(5));

        // 🔹 Combinação de tokens (manual + timeout)
        using var ctsLinked = CancellationTokenSource.CreateLinkedTokenSource(
            ctsManual.Token,
            ctsTimeout.Token
        );

        var token = ctsLinked.Token;

        // 🔥 Cancelamento manual após 2 segundos
        _ = Task.Run(async () =>
        {
            await Task.Delay(2000);
            Console.WriteLine("\n>> Cancelamento MANUAL disparado!");
            ctsManual.Cancel();
        });

        try
        {
            Console.WriteLine("Iniciando...\n");

            await ProcessoAsync(token);

            int resultado = await CalcularAsync(5, 7, token);
            Console.WriteLine($"Resultado: {resultado}");

            await ProcessoRapidoAsync(token);

            int valor = await BuscarValorAsync(false, token);
            Console.WriteLine($"Valor: {valor}");
        }
        catch (OperationCanceledException ex)
        {
            Console.WriteLine("\nOperação cancelada!");

            if (ctsManual.IsCancellationRequested)
                Console.WriteLine("Motivo: cancelamento manual");

            else if (ctsTimeout.IsCancellationRequested)
                Console.WriteLine("Motivo: timeout");
        }
        finally
        {
            Console.WriteLine("\nFinalizado.");
        }
    }

    // Task
    static async Task ProcessoAsync(CancellationToken token)
    {
        Console.WriteLine("Processo longo iniciado...");

        for (int i = 0; i < 10; i++)
        {
            token.ThrowIfCancellationRequested();

            await Task.Delay(1000, token);
            Console.WriteLine($"Etapa {i + 1}");
        }
    }

    // Task<T>
    static async Task<int> CalcularAsync(int a, int b, CancellationToken token)
    {
        await Task.Delay(1000, token);
        return a + b;
    }

    // ValueTask
    static ValueTask ProcessoRapidoAsync(CancellationToken token)
    {
        if (token.IsCancellationRequested)
            return ValueTask.FromCanceled(token);

        Console.WriteLine("Processo rápido executado.");
        return ValueTask.CompletedTask;
    }

    // ValueTask<T>
    static ValueTask<int> BuscarValorAsync(bool cache, CancellationToken token)
    {
        if (token.IsCancellationRequested)
            return ValueTask.FromCanceled<int>(token);

        if (cache)
            return new ValueTask<int>(42);

        return new ValueTask<int>(BuscarNoBancoAsync(token));
    }

    static async Task<int> BuscarNoBancoAsync(CancellationToken token)
    {
        Console.WriteLine("Buscando no banco...");

        await Task.Delay(3000, token);
        return 100;
    }
}