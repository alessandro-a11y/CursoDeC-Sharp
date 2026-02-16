using System;           
using System.Collections.Generic;

namespace Indexadores
{
    internal class ExercicioTimes
    {
        public static void Main(string[] args)
        {
            Times time = new Times();

            time[0] = "Flamengo";
            time[1] = "Vasco";
            time[2] = "Botafogo";
            time[3] = "Fluminense";
            time[4] = "Bangu";
            time[5] = "Madureira";
            // sp
            time[6] = "Palmeiras";
            time[7] = "Santos";
            time[8] = "São Paulo";
            time[9] = "Corinthians";
            time[10] = "Bragantino";
            time[11] = "Guarani";

            for (int j = 0; j < 11 ; j++)
            {
                Console.WriteLine(time[j]);
            }
        }
    }
}
