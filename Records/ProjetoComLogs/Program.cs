using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoComLogs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] logEntries = new string[]
            {
                "2024-06-01 10:00:00 - INFO - Iniciando o processo",
                "2024-06-01 10:01:00 - ERROR - Falha ao conectar ao banco de dados",
                "2024-06-01 10:02:00 - INFO - Tentando reconectar",
                "2024-06-01 10:03:00 - INFO - Reconexão bem-sucedida",
                "2024-06-01 10:04:00 - INFO - Processo concluído"
            };

            Console.WriteLine("\nExibindo o array de strings: logEntries[]");

            foreach (var item in logEntries)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nPegando o último registro do log: logEntries[^1]");
            string ultimoRegistro = logEntries[^1];

            Console.WriteLine($"\"{ultimoRegistro}\"");

            Console.WriteLine("\nOs 3 últimos registros do log: logEntries[^3..^]");

            foreach (var entry in logEntries[^3..])
            {
                Console.WriteLine($"\"{entry}\"");
            }

            Console.WriteLine("\nExtraindo a data do 4° elemento do array: logEntries[3][..19]");

            string dataDoQuartoRegistro = logEntries[3][..19];
            Console.WriteLine($"\"{dataDoQuartoRegistro}\"");
        }
    }
}