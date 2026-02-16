using System;
using System.Linq;

namespace Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var AlunoENotas = new List<Aluno>
            {
                new Aluno { Nome = "Maria", Nota = 8.5 },
                new Aluno { Nome = "Manoeal", Nota = 6.95 },
                new Aluno { Nome = "Amanda", Nota = 7.25 },
                new Aluno { Nome = "Carlos", Nota = 6.55 },
                new Aluno { Nome = "Jaime", Nota = 8.50 },
                new Aluno { Nome = "Debora", Nota = 5.95 },
                new Aluno { Nome = "Sandra", Nota = 5.55 },
                new Aluno { Nome = "Alicia", Nota = 9.25 },
                new Aluno { Nome = "Marta", Nota = 7.85 },
                new Aluno { Nome = "Jaime", Nota = 9.15 },
            };

            Console.WriteLine($"Média dos alunos: {AlunoENotas.Average(a => a.Nota)}");
            

            AlunoENotas.Add(new Aluno { Nome = "Bia", Nota = 7.75 });
            AlunoENotas.Add(new Aluno { Nome = "Mario", Nota = 8.95 });

            Console.WriteLine("\nBia e joão adicionados");

            Console.WriteLine($"\nAluno(a) localizada: {AlunoENotas.Any(a => a.Nome == "Amanda")}");

            AlunoENotas.RemoveAll(a => a.Nome == "Amanda");
            Console.WriteLine("\nAmanda removida!");

            var listaOrdenada = AlunoENotas.OrderBy(a => a.Nome).ToList();
            Console.WriteLine("\nLista ordenada por nome: ");

            foreach (var aluno in listaOrdenada)
            {
                aluno.Exibir();
                Console.WriteLine(aluno.EstaAprovado() ? "Aprovado" : "Reprovado");
            }
        }
    }
}