/*
// aprendendo a usar DateTime em C#
using System;
namespace DataEHora
{



internal class  Program
{
    static void Main(string[] args)
    {
        // Obtendo a data e hora atuais
        DateTime agora = DateTime.Now;
        Console.WriteLine("Data e hora atuais: " + agora);
        // Formatando a data
        string dataFormatada = agora.ToString("dd/MM/yyyy");
        Console.WriteLine("Data formatada: " + dataFormatada);
        // Formatando a hora
        string horaFormatada = agora.ToString("HH:mm:ss");
        Console.WriteLine("Hora formatada: " + horaFormatada);
        // Adicionando dias à data atual
        DateTime daquiUmaSemana = agora.AddDays(7);
        Console.WriteLine("Data daqui a uma semana: " + daquiUmaSemana.ToString("dd/MM/yyyy"));
        // Subtraindo horas da hora atual
        DateTime duasHorasAtras = agora.AddHours(-2);
        Console.WriteLine("Hora duas horas atrás: " + duasHorasAtras.ToString("HH:mm:ss"));
    }
    }
}
*/