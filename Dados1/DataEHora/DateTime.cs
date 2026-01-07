/*using System;
namespace DataEHora;
internal class ProgramData
{
   static void Main(string[] args)
    {
        DateTime data = DateTime.Now;
          Console.WriteLine($"Data e hora especificadas: {data}");
          Console.WriteLine($"Ano:{data.Year}");
          Console.WriteLine($"Mês:{data.Month}");
          Console.WriteLine($"Dia:{data.Day}");
          Console.WriteLine($"Hora:{data.Hour}");
          Console.WriteLine($"Minuto:{data.Minute}");
          Console.WriteLine($"Secundo:{data.Second}");
          Console.WriteLine($"Milisegundos:{data.Millisecond}"); 
        // adicionando dias, horas, minutos e segundos
          DateTime novaData = data.AddDays(5).AddHours(3).AddMinutes(30).AddSeconds(15);
          Console.WriteLine($"Nova data e hora após adições: {novaData}");
        // obter dia da semana e dia do ano
          Console.WriteLine($"Dia da semana: {data.DayOfWeek}");
          Console.WriteLine($"Dia do ano: {data.DayOfYear}");
        // Agora no formato longo e curto
          Console.WriteLine($"Data e hora (formato longo): {data.ToLongDateString()} {data.ToLongTimeString()}");
          Console.WriteLine($"Data e hora (formato curto): {data.ToShortDateString()} {data.ToShortTimeString()}");
          Console.ReadKey();

    }
}

// criando data especifica DateTime data = new DateTime(2023, 12, 25, 10, 30, 0);
// console.writeline($"{data}");

*/