//using System;
//namespace PassandroArgumentosporValoresERef
//{
//    internal class Program
//    {
//        static void Main(string[] aegs)
//        {
//            int x = 20;
//            Console.WriteLine($"\nValor do antes de criar o objeto: {x}");

//            Calculo calc = new Calculo();
//            calc.Dobrar( ref x);

//            Console.WriteLine($"\nValor do parâmetro x após chamar o método Dobrar: {x}");
//        }
//    }
//    public class Calculo
//    {
//        public void Dobrar(ref int y) 
//        {
//            y *= 2;
//            Console.WriteLine($"\nValor do paraâmetro y no método dobrar: {y}");
//        }
//    }
//}