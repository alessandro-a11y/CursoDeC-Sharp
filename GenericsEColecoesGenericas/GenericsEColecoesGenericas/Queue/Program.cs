using System;
using System.Collections.Generic;

namespace Queue
{
    internal class Program : ProgramBase
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();
            fila.Enfileirar("Primeiro");
            fila.Enfileirar("Segundo");
            fila.Enfileirar("Terceiro");
            Console.WriteLine($"Primeiro elemento: {fila.Primeiro()}");
            Console.WriteLine($"Tamanho da fila: {fila.Tamanho()}");
            Console.WriteLine($"Desenfileirando: {fila.Desenfileirar()}");
            Console.WriteLine($"Primeiro elemento após desenfileirar: {fila.Primeiro()}");

            string[] cursos = { "C#", "Java", "Python", "JavaScript" };
            Queue<string> filaCursos = new Queue<string>();
            Console.WriteLine();
            Console.WriteLine("No. de Elementos na fila 1 : " + cursos.Count());

            ExibirCurso(cursos);

        }
    }
}