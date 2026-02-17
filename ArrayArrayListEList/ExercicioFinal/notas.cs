//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ExercicioFinal
//{
//    internal class notas
//    {
//        static void Main()
//        {
            
//            // Forma 1: Já atribuindo os valores
//            float[,] notas = new float[2, 5];

//            //Coleto de dados
//            for (int i = 0; i < notas.GetLength(0); i++)
//            {
//                Console.WriteLine($"\nENTRADA DE NOTAS: GRUPO {i + 1}");
//                for (int j = 0; j < notas.GetLength(1); j++)
//                {
//                    Console.WriteLine("Informe a nota dos alunos: ");
//                    notas[i, j] = float.Parse(Console.ReadLine());
//                }
//            }

//            Console.WriteLine("\n\nRESUMO DAS NOTAS");
//            for (int i = 0; i < notas.GetLength(0); i++)
//            {
//                Console.WriteLine($"\nResultados do Grupo {i + 1}:");

//                for (int j = 0; j < notas.GetLength(1); j++)
//                {
//                    Console.WriteLine($"- Aluno {j + 1}: Nota {notas[i, j]}");
//                }
//            }
//            for (int i = 0; i < notas.GetLength(0); i++)
//            {
//                float soma = 0; // Zera a soma para cada grupo novo
//                for (int j = 0; j < notas.GetLength(1); j++)
//                {
//                    soma += notas[i, j];
//                }
//                float media = soma / notas.GetLength(1);
//                Console.WriteLine($"Média do Grupo {i + 1}: {media:F2}");
//            }
//        }
//    }
//}
