using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    private static SemaphoreSlim semaforoSlim = new SemaphoreSlim(4); // Permite até 4 threads simultâneas
    private static void Main(string[] args)
    {
        for (int i = 1; i <= 6; i++)
        {
            string threadName = "Thread " + i;
            int espera = 2 + 2 * i;

            var t = new Thread(() =>
                AcessarBancoDados(threadName, espera));

            t.Start();

        }
    }
    private static void AcessarBancoDados(string nome, int seconds)
    {
        Console.WriteLine($"{nome} aguarda para acessar o banco de dados...");
        semaforoSlim.Wait();

        Console.WriteLine($"{nome} foi autorizada a acessar o banco de dados");
        Sleep(TimeSpan.FromSeconds(seconds));

        Console.WriteLine($"{nome} foi conluída...");
        semaforoSlim.Release();
    }

    private static void Sleep(TimeSpan timeSpan)
    {
        throw new NotImplementedException();
    }
}
