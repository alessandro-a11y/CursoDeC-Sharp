using System;
namespace MetodosAnonimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>
            {
                "Maria", "Miriam", "Paulo", "Carlos"
            };

            string resultado = nomes.Find(nome => nome.Equals("Paulo"));

            Console.WriteLine(resultado);

        }
    }
}