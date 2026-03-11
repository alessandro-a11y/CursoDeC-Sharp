using System;
namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var figuras = new List<Figura>
            {
                new Triangulo(),
                new Circulo(),
                new Quadrado()
            };
            foreach (var figura in figuras)
            {
                figura.Desenhar();
            }
        }
    }
}