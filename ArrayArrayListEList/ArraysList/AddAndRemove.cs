using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArraysList
{
    internal class AddAndRemove
    {
        static void Main(string[] args)
        {
            var lista = new ArrayList()
            {
                "Ana", 5, true, " ", null, 1.1, "zé", 3, 9, 0
            };

            lista.Remove(null);
            Imprimir(lista);
            lista.RemoveAt(4);
            Imprimir(lista);
            lista.RemoveRange(0, 2);
            Imprimir(lista);
        }

        static void Imprimir(ArrayList lista)
        {
            foreach (var item in lista)
            {
                Console.Write($"{item}| ");
            }
            Console.WriteLine();
        }
    }
}
