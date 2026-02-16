using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ArraysList
{
    internal class ArraysList
    {
        public static void Lista(string[] array, int index)
        {
            var lista = new ArrayList()
            {
                "Maria", 5, true, " ", null
            };
            // inserindo por indice
            lista.Insert(2, "Paulo");
            //adicionando normalmente 
            lista.Add(3.5);
            

            foreach (var item2 in lista)
            {
                Console.WriteLine(item2);
            }
        }
    }
    
}
