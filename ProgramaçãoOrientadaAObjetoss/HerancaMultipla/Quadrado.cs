using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaMultipla
{
    internal class Quadrado : Forma, ICusto
    {
        public int GetArea()
        {
            return (lado * lado);
        }
        public int GetCusto(int area)
        {
            return area * 10;
        }
    }
}
