//using System;
//internal class ProgramNull
//{
//    static void Main(string[] args)
//    {
//        int? a = 30;
//         if(a.HasValue)
//        {
//            Console.WriteLine($"O valor da váriavel é: {a.Value}");
//        }else
//        {
//            Console.WriteLine("A variável não possui valor atribuído.");
//        }
//    }
//}

// nullable reference types
using System;
namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome = "";
            if (nome == null)
            {
                Console.WriteLine("A variável 'nome' é nula.");
            }
            else
            {
                Console.WriteLine($"O valor da variável 'nome' é: {nome?.ToUpper()}");
            }
        }
    }
}