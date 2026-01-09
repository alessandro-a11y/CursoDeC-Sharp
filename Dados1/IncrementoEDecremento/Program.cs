//using System;
//namespace IncrementoEDecremento
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int x = 10;
//            x++;
//            int y = 10;
//            y--;
//            Console.WriteLine(x);
//            Console.WriteLine(y);
//        }
//    }
//}
using System;

class Program
{
    static void Main()
    {
        int numero = 10;

        // incremento
        numero++;   // agora vale 11
        ++numero;   // agora vale 12

        // decremento
        numero--;   // agora vale 11
        --numero;   // agora vale 10

        Console.WriteLine(numero);
    }
}
