using System;
using System.Collections.Generic;   
namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dic3 = new Dictionary<int, int>()
         {
             {1, 100 },
             {2, 200 },
             {3, 300 }

         };
            Console.WriteLine("" +
                "Incluir elemento com chave" +
                "(3) duplicada");

            try
            {
                dic3.Add(3, 300);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString);
            }
   
        }
    }
}