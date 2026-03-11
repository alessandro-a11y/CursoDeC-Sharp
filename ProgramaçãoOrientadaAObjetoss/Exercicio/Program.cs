using System;
namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(0);
            Console.WriteLine("Informe a quantidade de gasolina para abastecer: ");
            int quantidade = int.Parse(Console.ReadLine());

            carro.Abastecer(quantidade);
            carro.Dirigir();
        }
    }
}
