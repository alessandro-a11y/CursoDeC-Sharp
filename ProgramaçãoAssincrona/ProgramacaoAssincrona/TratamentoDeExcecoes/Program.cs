using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        await LancaMultiplasExcecoesAsync();
    }

    static async Task LancaMultiplasExcecoesAsync()
    {
        Task tarefas = null;

        try
        {
            var primeiraTask = Task.Run(async () =>
            {
                await Task.Delay(1000);
                throw new IndexOutOfRangeException("Exceção da primeira task");
            });

            var segundaTask = Task.Run(async () =>
            {
                await Task.Delay(1000);
                throw new InvalidOperationException("Exceção da segunda task");
            });

            tarefas = Task.WhenAll(primeiraTask, segundaTask);

            await tarefas;
        }
        catch (Exception)
        {
            Console.WriteLine("Ocorreram as seguintes exceções:\n");

            if (tarefas?.Exception != null)
            {
                foreach (var ex in tarefas.Exception.InnerExceptions)
                {
                    Console.WriteLine($"{ex.GetType().Name} - {ex.Message}");
                }
            }
        }
    }
}