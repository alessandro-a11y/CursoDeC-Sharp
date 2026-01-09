using System;
namespace Constantes1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MESES_ANO = 12;
            const int DIAS_ANO = 365;
            const float DIAS_POR_MES = (float) DIAS_ANO / MESES_ANO;
            Console.WriteLine(DIAS_POR_MES);

            //const int ANO = 12;
            //const int MES = 30, SEMANA = 7, QUINZENA = 15;

            //Console.WriteLine($"Constante ANO: {ANO}");
            //Console.WriteLine($"Constante MES: {MES}");
            //Console.WriteLine($"Constante SEMANA: {SEMANA}");
            //Console.WriteLine($"Constante QUINZENA: {QUINZENA}");
        }
    }
}