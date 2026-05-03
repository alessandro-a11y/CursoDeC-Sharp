using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        TesteAsync t = new();

        try
        {
            t.ChamaTarefaAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
            Console.WriteLine("Este bloco não será executado");
            Console.WriteLine(ex.Message);
        }

    }
class TesteAsync
    {
        public Task MinhaTarefaAsync()
        {
            return Task.Run(() =>
            {
                Task.Delay(2000);
                throw new Exception("Ocorreu um erro na tarefa!");

            });
        }
        public async void ChamaTarefaAsync()
        {
            await MinhaTarefaAsync();
        }
    }
}