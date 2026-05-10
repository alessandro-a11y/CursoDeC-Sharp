using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        await foreach(var item in GeraMeses())
        {
            Console.WriteLine(item);
        }
    }
    static private async IAsyncEnumerable<string> GeraMeses()
    {
        yield return "Janeiro";
        yield return "Fevereiro";
        yield return "Março";
        yield return "Abril";
        yield return "Maio";
        yield return "Junho";
        await Task.Delay(5000);
        yield return "Julho";
        yield return "Agosto";
        yield return "Setembro";
        yield return "Outubro";
        yield return "Novembro";
        yield return "Dezembro";
    }
}