using System;
using System.Collections;
namespace ListEArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista1 = new ArrayList();
            lista1.Add(1);
            lista1.Add(2);
            lista1.Add(3);

            var elemento = lista1[0];
            int item = (int)lista1[1];


            List<int> lista2 = new List<int>();
            lista2.Add(1);
            lista2.Add(2);
            lista2.Add(3);

            var elemento2 = lista2[0];
            int item2 = (int)lista2[1];

            foreach (int i in lista2)
            {
                Console.WriteLine(i);
            }
            foreach (var item1 in lista1)
            {
                Console.WriteLine(item1);
            }
        }
    }
}