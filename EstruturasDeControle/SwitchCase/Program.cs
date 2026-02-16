//using System;
//namespace SwitchCase
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                Console.WriteLine("Informe o valor de 1-3: \n");
//                int Valor = Convert.ToInt32(Console.ReadLine());
//                switch (Valor)
//                {
//                    case 1:
//                        Console.WriteLine("Prestação de 100 reais");
//                        break;
//                    case 2:
//                        Console.WriteLine("Prestação de 200 reais");
//                        break;
//                    case 3:
//                        Console.WriteLine("Prestação de 300 reais");
//                        break;
//                    default:
//                        Console.WriteLine("Valor inválido");
//                        break;
//                }
//                Console.WriteLine("Deseja continuar? (s/n)");
//                string resposta = Console.ReadLine().ToLower();
//                if (resposta != "s")
//                {
//                    break;
//                }
//            }
//        }
//    }
//}
/*using System;
namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolhe um mês: ");
            var mes = Console.ReadLine().ToLower();

            switch (mes)
            {
                case "janeiro":
                case "março":
                case "abril":
                case "maio":
                case "junho":
                case "julho":
                case "agosto":
                case "outubro":
                case "dezembro":
                    Console.WriteLine("Esse mês tem 31 dias");
                    break;
                case "fevevereiro":
                    Console.WriteLine("Esse mês tem 28 ou 29 dias");
                    break;
                default:
                    Console.WriteLine("Esse mês tem 30 dias");
                    break;
            }
        }
    }
}*/