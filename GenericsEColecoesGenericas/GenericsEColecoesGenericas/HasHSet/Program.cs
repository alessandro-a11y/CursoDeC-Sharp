using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var TimesSp = new HashSet<string>()
            {
                "Corinthians",
                "Palmeiras",
                "São Paulo",
                "Santos"
            };
            var TimesRj = new HashSet<string>()
            {
                "Flamengo",
                "Vasco",
                "Fluminense",
                "Botafogo"
            };
            var TimesMg = new HashSet<string>()
            {
                "Atlético-MG",
                "Cruzeiro",
                "América-MG"
             };
            var TimesCampeoesMundiais = new HashSet<string>()
            {
                "Santos",
                "Flamengo",
                "São Paulo"
            };

            if (TimesSp.IsSubsetOf(TimesCampeoesMundiais))
            {
                Console.WriteLine("TimesSP é um subconjunto de TimesCampeosMundiais");
            }
            if (TimesCampeoesMundiais.IsSubsetOf(TimesSp))
            {
                Console.WriteLine("TimesCampeoesMundiais é um subconjunto de TimesSp");
            }
            if (TimesRj.Overlaps(TimesCampeoesMundiais))
            {
                Console.WriteLine("TimesRj tem times campeões mundiais");
            }
            if (!TimesSp.SetEquals(TimesRj))
            {
                Console.WriteLine("\nTimesSp e TimesRj não contem os mesmos elementos");
            }
            Console.WriteLine("\nJuntando os HashSet<T>: SP, RJ, MG");
            TimesSp.UnionWith(TimesRj);
            TimesRj.UnionWith(TimesMg);

            ExibirColecao(TimesSp);

            Console.WriteLine("\nTodos os times ordenados");
            var TodosTimes = new SortedSet<string>(TimesSp);
            ExibirColecao(TodosTimes);

            Console.WriteLine("\nInterseção de dois HashSet<T>: TimesSp e TimesCampeoesMundiais");
            TimesSp.IntersectWith(TimesCampeoesMundiais);
            ExibirColecao(TimesSp);


            Console.WriteLine("\nDiferenças");
            TimesCampeoesMundiais.ExceptWith(TimesSp);
            ExibirColecao(TimesCampeoesMundiais);


            static void ExibirColecao<T>(IEnumerable<T> colecao)
            {
                Console.WriteLine();
                foreach (var item in colecao)
                {
                    Console.WriteLine($"{item}");
                }
            }
        }
    }

}
