using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysMultimensionais
{
    internal class ListaDeAlunos
    {
        static void Main(string[] args)
        {
            string[,] alunos =
            {
                {"Maria", "Alessandro", "Pedro", "Milton", "Josefa"},
                {"Francisco", "Rodolfo", "José", "Edvaldo", "Diego"}
            };

            for (int i = 0; i < alunos.GetLength(0); i++)
            {
                for (int j = 0; j < alunos.GetLength(1); j++)
                {
                    Console.Write($"|[{i}, {j}] {alunos[i, j],-12}| ");
                }
                Console.WriteLine();
            }


        }
    }
}
