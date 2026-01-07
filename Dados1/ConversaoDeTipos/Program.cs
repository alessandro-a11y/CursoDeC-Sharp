using System;
namespace ConversaoDeTipos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int varINT = 100; // usa 4 bytes
            float varFLOAT = varINT;// usa 8 bytes // Conversão implícita de int para double
            Console.WriteLine($"Convertendo o número inteiro {varINT}, em double ficara {varFLOAT}");
        }
    }
}