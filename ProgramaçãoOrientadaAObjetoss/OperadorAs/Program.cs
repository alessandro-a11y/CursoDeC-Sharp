using System;
namespace OperadorAS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Object carroObj = new Carro();

            var y = carroObj as string;

            if (y != null)
            {
                Console.WriteLine("Convertido para object");
            }
            else
            {
                Console.WriteLine("Y é null");
            }
        }
    }
    class Carro 
    { }

}