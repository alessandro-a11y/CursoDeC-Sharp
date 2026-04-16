using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeExtensao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>()
            {
                "João", "Maria", "Pedro", "Ana" 
            };
            var resultado = from n in nomes
                            where n.Contains("o")
                            select n;

            foreach (var item in resultado)
            {
                Console.WriteLine(item);
            }

            List<string> nomes2 = new List<string>()
            {
                "João", "Maria", "Pedro", "Ana" 
            };

            var resultado2 = nomes2.Where(n => n.Contains("o"));
            foreach (var item1 in resultado2)
            {
                Console.WriteLine(item1);
            }

        }
    }

}