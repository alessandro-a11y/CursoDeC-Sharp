using System;
namespace ModoficadorAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado();
            quadrado.Cor = "Vermelho";
            quadrado.Lado = 5;
            quadrado.CalcularArea();
            quadrado.CalcularPerimetro();
            quadrado.Descriao();

        }
    }
}