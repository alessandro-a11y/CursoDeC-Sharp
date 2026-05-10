using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Exercicio
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await ExecuteOperationAsync();
        }

        static async Task ExecuteOperationAsync()
        {
            var time = 30;
            var cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromSeconds(time));

            Console.WriteLine("\nIniciando download.....");
            Console.WriteLine($"\nCancelando a operação após {time} segundos...");

            try
            {
                using var httpClient = new HttpClient();
                var finaldestination = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "poesia.txt");

                var response = await httpClient.GetAsync(
                    "https://www.macoratti.net/dados/Poesia.txt",
                    HttpCompletionOption.ResponseHeadersRead,
                    cancellationTokenSource.Token);

                response.EnsureSuccessStatusCode();

                var totalbytes = response.Content.Headers.ContentLength ?? 0;
                var readbytes = 0L;

                await using var filestream = new FileStream(
                    finaldestination,
                    FileMode.Create,
                    FileAccess.Write,
                    FileShare.None,
                    8192,
                    true);

                await using var contentStream = await response.Content
                    .ReadAsStreamAsync(cancellationTokenSource.Token);

                var buffer = new byte[8192];
                int bytesRead;

                while ((bytesRead = await contentStream.ReadAsync(buffer, cancellationTokenSource.Token)) > 0)
                {
                    await filestream.WriteAsync(buffer, cancellationTokenSource.Token);
                    readbytes += bytesRead;

                    if (totalbytes > 0)
                    {
                        Console.Write($"\rProgresso: {readbytes} de {totalbytes} bytes ({(readbytes * 100.0 / totalbytes):F2}%)");
                    }
                    else
                    {
                        Console.Write($"\rProgresso: {readbytes} bytes baixados");
                    }
                }
            }
            catch (OperationCanceledException)
            {
                Console.WriteLine("\nDownload cancelado (timeout).");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"\nErro de rede: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro inesperado: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nDownload finalizado.");
            }
        }
    }
}