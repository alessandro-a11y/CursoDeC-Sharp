using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ExemploPlanetas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gerenciador = new GerenciaExoPlanetas();

            var exoPlanetas = gerenciador.Exoplanetas;

            // Isso AINDA permite alterar o objeto (porque é referência)
            

            Console.WriteLine("\nLista de exoplanetas:\n");

            foreach (var planeta in exoPlanetas)
            {
                Console.WriteLine(planeta.Nome);
            }
        }
    }

    public class ExoPlaneta
    {
        public string Nome { get; private set; }

        public ExoPlaneta(string nome)
        {
            Nome = nome;
        }

        // Método controlado para alteração
        public void AlterarNome(string novoNome)
        {
            Nome = novoNome;
        }

        public static List<ExoPlaneta> ObterExoPlanetas()
        {
            return new List<ExoPlaneta>
            {
                new ExoPlaneta("Kepler-22b"),
                new ExoPlaneta("Gliese 667 Cc"),
                new ExoPlaneta("Proxima Centauri b"),
                new ExoPlaneta("TRAPPIST-1e"),
                new ExoPlaneta("LHS 1140 b")
            };
        }
    }

    public class GerenciaExoPlanetas
    {
        private readonly List<ExoPlaneta> exoplanetas;

        public GerenciaExoPlanetas()
        {
            exoplanetas = ExoPlaneta.ObterExoPlanetas();
        }

        public ReadOnlyCollection<ExoPlaneta> Exoplanetas
        {
            get { return exoplanetas.AsReadOnly(); }
        }

        public void AdicionarExoPlaneta(string nome)
        {
            exoplanetas.Add(new ExoPlaneta(nome));
        }
    }
}