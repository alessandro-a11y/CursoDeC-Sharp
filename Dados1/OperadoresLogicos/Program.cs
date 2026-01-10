using System;
namespace OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool c1 = true;
            bool c2 = false;
            Console.WriteLine(c1&&c2);
            Console.WriteLine(c1||c2);
            Console.WriteLine(!c2);
        }
    }
}