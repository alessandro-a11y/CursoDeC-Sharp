using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var limiteCredito = new List<Limite>();

            for(int i = 1; i < 16; i++) 
            { 
                limiteCredito.Add(new Limite { Numero = i });
            }

            var limitesComrestricao = limiteCredito.Where(x => x.AnalisaLimite()).ToList();

            if (limitesComrestricao.Count > 3)
            {
                Console.WriteLine("Limite de crédito bloqueado");
            }
            else
            {
                Console.WriteLine("Limite de crédito liberado");
            }
        }
    }
    public class Limite
    {
        public int Numero { get; set; }
        private bool isRestricao;

        public Limite()
        {
            var semente = Guid.NewGuid().GetHashCode();
            var numeroAleatorio = new Random(semente).Next(1, 4);

            isRestricao = numeroAleatorio == 1;
        }
        public bool AnalisaLimite()
        {
            Console.WriteLine($"Executa análise de limite de crédito para o limite {Numero}");
            return isRestricao;
        }
    }
}