using System;
using System.Collections.Generic;
namespace exercicioDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var alunos = new Dictionary<int, Aluno>()
            {
                { 1, new Aluno("João", 8.5) },
                { 2, new Aluno("Maria", 9.0) },
                { 3, new Aluno("Pedro", 7.5) }
            };

            ExibirInformacoes(alunos);

            // localizar e atualizar a nota do aluno com chave 2
            do
            {
                Console.WriteLine("\nInforme o código do Aluno a localizar (0 sai)");
                int codigo = int.Parse(Console.ReadLine());

                if (codigo == 0)
                {
                    break;
                }
                var resultado = alunos.ContainsKey(codigo);
                if (resultado)
                {
                    Console.WriteLine("Informe a nova nota do aluno");
                    double novaNota = double.Parse(Console.ReadLine());
                    alunos[codigo].Nota = novaNota;
                    Console.WriteLine("Nota atualizada com sucesso!");
                    ExibirInformacoes(alunos);
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado!");
                }
            } while (true);

            // localizar e remover o aluno com chave 3
            Console.WriteLine("\nInforme o código do Aluno a remover (0 sai)");
            int codigoRemover = int.Parse(Console.ReadLine());
            if (codigoRemover != 0)
            {
                var resultadoRemover = alunos.ContainsKey(codigoRemover);
                if (resultadoRemover)
                {
                    alunos.Remove(codigoRemover);
                    Console.WriteLine("Aluno removido com sucesso!");
                    ExibirInformacoes(alunos);
                }
                else
                {
                    Console.WriteLine("Aluno não encontrado!");
                }
            }
            // adicionar um novo aluno com chave 4
            Console.WriteLine("\nInforme o código do novo Aluno (0 sai)");
            string codigoNovo = Console.ReadLine();
            if (codigoNovo != "0")
            {
                Console.WriteLine("Informe o nome do novo Aluno");
                string nomeNovo = Console.ReadLine();
                Console.WriteLine("Informe a nota do novo Aluno");
                double notaNova = double.Parse(Console.ReadLine());
                alunos.Add(int.Parse(codigoNovo), new Aluno(nomeNovo, notaNova));
                Console.WriteLine("Aluno adicionado com sucesso!");
                ExibirInformacoes(alunos);
            }
            // Ordenar os alunos por nome
            Console.WriteLine("\nAlunos ordenados por nome");
            var alunosOrdenados = alunos.OrderBy(a => a.Value.Nome);
            foreach (var item1 in alunosOrdenados)
            {
                Console.WriteLine($"{item1.Key} - {item1.Value.Nome} - {item1.Value.Nota} ");
            }
            // removendo todos os alunos e notas
            alunos.Clear();
            Console.WriteLine("\nFim do exercício");

        }

        private static void ExibirInformacoes(Dictionary<int, Aluno> alunos)
        {
            foreach (var item in alunos)
            {
                Console.WriteLine($"{item.Key} - {item.Value} - {item.Value.Nota}");
            }
        }

        public class Aluno
        {
            public string Nome { get; set; }
            public double Nota { get; set; }

            public Aluno(string nome, double nota)
            {
                Nome = nome;
                Nota = nota;
            }

            public override string ToString()
            {
                return Nome;
            }
        }
    }
}