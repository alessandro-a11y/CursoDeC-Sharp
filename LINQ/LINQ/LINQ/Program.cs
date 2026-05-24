namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<string> frutas = new List<string>()
            {
                "Banana",
                "Maçã",
                "Laranja",
                "Abacaxi",
                "Uva"
            };

            // query syntax
            var resultado = from fruta in frutas
                            where fruta.Contains("a")
                            select fruta;

            foreach (var item in resultado)
            {
                Console.WriteLine(item);
            }

            // method syntax
            var resultado2 = frutas.Where(fruta => fruta.Contains("a"));
            foreach (var item in resultado2)
            {
                Console.WriteLine(item);
            }
        }
    }
}