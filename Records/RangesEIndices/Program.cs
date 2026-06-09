using System;
using System.Linq;

namespace RangeEIndices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] diasDaSemana = { "Domingo", 
                                    "Segunda", "Terça", "Quarta", 
                                    "Quinta", "Sexta", "Sábado" 
                                    };

            string[] diasUteis = diasDaSemana[0..5];
            Console.WriteLine(string.Join(", ", diasUteis));

            string[] doMeioAoFim = diasDaSemana[2..];
            Console.WriteLine(string.Join(", ", doMeioAoFim));

            string[] doComecoAtePenultimo = diasDaSemana[..^1];
            Console.WriteLine(string.Join(", ", doComecoAtePenultimo));

            string[] copiaCompleta = diasDaSemana[..];
            Console.WriteLine(string.Join(", ", copiaCompleta));
        }
    }
}