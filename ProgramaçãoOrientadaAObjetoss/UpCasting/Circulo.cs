using System;
using System.Collections.Generic;
using System.Text;

namespace UpCasting
{
    internal class Circulo : Forma
    {

        public Circulo(int x, int y) : base(x, y)
        { }
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um círculo");
        }
    }
}
