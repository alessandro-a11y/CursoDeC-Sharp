using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PredicateProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Planeta> planetas = new List<Planeta>
            {
                new Planeta { Nome = "Mercúrio", Diametro = 4879, Massa = 0.33 },
                new Planeta { Nome = "Terra", Diametro = 12756, Massa = 5.97 },
                new Planeta { Nome = "Júpiter", Diametro = 142984, Massa = 1898 },
                new Planeta { Nome = "Marte", Diametro = 6792, Massa = 0.64 }
            };

            // Definindo o critério: Planetas com diâmetro maior que 10.000 km
            Predicate<Planeta> grandesPlanetas = p => p.Diametro > 10000;

            // Filtrando
            List<Planeta> filtrados = FiltrarPlanetas(planetas, grandesPlanetas);

            Console.WriteLine("Planetas com diâmetro > 10.000km:");
            foreach (var p in filtrados)
            {
                Console.WriteLine($"- {p.Nome} ({p.Diametro} km)");
            }
        }
        static List<Planeta> FiltrarPlanetas(List<Planeta> lista, Predicate<Planeta> criterio)
        {
            List<Planeta> resultado = new List<Planeta>();
            foreach (var p in lista)
            {
                if (criterio(p)) // Aqui o delegate é testado
                {
                    resultado.Add(p);
                }
            }
            return resultado;
        }
    }
}