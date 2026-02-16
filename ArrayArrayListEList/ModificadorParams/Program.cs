using System;
namespace ModificadorParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = { 1, 2, 3, 4 };

            var res1 = Calcular.Soma(valores);
            Console.WriteLine(res1);

            var res2 = Calcular.Soma( 1, 2, 3, 4, 5, 6 );
            Console.WriteLine(res2);
        }
    }
    public class Calcular
    {
        public static int Soma(params int[] numeros)
        {
            int total = 0;
            foreach (var numero in numeros)
            {
                total += numero;
            }
            return total;
        }
    }
}