
//using System;
//using System.Collections.Generic;
//using System.Runtime.Intrinsics.X86;
//using System.Text;

//namespace exercicios
//{
//    internal class exe3
//    {
//        static void Main(string[] args)
//        {
//            /*  Escreva um programa para solicitar ao usuário que escolha a resposta correta de uma lista de opções de 
//            resposta de uma pergunta. O usuário pode optar por continuar respondendo a pergunta ou parar de responder.
//n           Não utilize a instrução break.*/
//            string resposta = "";
//            while (resposta != "x")
//            {
//                Console.WriteLine("Qual a instrução para sair de um loop ?\na.quit\nb.continue\nc.break\nd.exit\nQual a opção correta ? (tecle x para sair)");
//                resposta = Console.ReadLine().ToLower();
//                if (resposta == "c")
//                {
//                    Console.WriteLine("Parabéns! Resposta correta.");
//                } else if (resposta == "x")
//                {
//                    Console.WriteLine("Programa encerrado.");
                    
//                }
//                else
//                {
//                    Console.WriteLine("Resposta incorreta. Tente novamente.");
//                }
                
//            }
           
//        }
//    }
//}
