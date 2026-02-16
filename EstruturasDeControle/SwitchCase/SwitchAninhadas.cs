//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SwitchCase
//{
//    internal class SwitchAninhadas
//    {
//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                int cargo = 0;
//                int funcao = 0;

//                Console.WriteLine("Você é gerente(1) ou Programador(2): \n");
//                cargo = Convert.ToInt32(Console.ReadLine());

//                if (cargo == 2)
//                {
//                    Console.WriteLine("Você é junior(1) ou senior(2)? \n");
//                    funcao = Convert.ToInt32(Console.ReadLine());
//                }
//                switch (cargo)
//                {
//                    case 1:
//                        Console.WriteLine("\nBem-vindo Gerente");
//                        break;
//                    case 2:
//                        Console.WriteLine("\nBem-Vindo Programador");
//                        switch (funcao)
//                        {
//                            case 1:
//                                Console.WriteLine("Você é um Programador Junior");
//                                break;
//                            case 2:
//                                Console.WriteLine("Você é um Programador Senior");
//                                break;
//                            default:
//                                Console.WriteLine("Função inválida");
//                                break;
//                        }
//                        break;
//                    default:
//                        Console.WriteLine("\nFunção desconhecida");
//                        break;
//                }
//                Console.WriteLine("\nDeseja continuar? (s/n)");
//                string resposta = Console.ReadLine().ToLower();
//                if (resposta == "s")
//                {

//                    continue;
//                }
//                else
//                {
//                    Console.WriteLine("Fim do processamento");
//                    break;
//                }
//            }

//        }
//    }
//}
