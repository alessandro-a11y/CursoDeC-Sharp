using System;
using System.Collections.Generic;
using System.Text;

namespace UpCasting
{
    internal class Forma
    {
        protected int xpos, ypos;
        public Forma(int x, int y)
        {
            xpos = x;
            ypos = y;
        }
        public virtual void Desenhar(10, 20) => Console.WriteLine($"Desenhando forma base em ({xpos}, {ypos})");
    }
}
