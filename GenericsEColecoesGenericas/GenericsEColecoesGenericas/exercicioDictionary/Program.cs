using System;
using System.Collections.Generic;
namespace exercicioDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // criar dicionário pra armazenar nome e nota de alunos
            var dic3 = new Dictionary<string, double>
            {
                {"Maria", 7.0},
                {"Eric", 8.0 },
                {"Ana", 9.0 },
                {"Alex", 6.0 },
                {"Dina", 5.0 }
            };
            // acessar e exibir nome e nota de cada aluno
            foreach (KeyValuePair<string, double> item in dic3)
            {
                Console.WriteLine($"Nome: {item.Key} -- Nota: {item.Value}");
            }
            Console.WriteLine("\n------ Nota atualizada ------\n");
            // localizar e atualizar a nota de um aluno específico
            dic3["Alex"] = 7.5;
            foreach (KeyValuePair<string, double> item1 in dic3)
            {
                Console.WriteLine($"Nome: {item1.Key} -- Nota: {item1.Value}");
            }
            // remover um aluno do dicionário
            dic3.Remove("Dina");
            Console.WriteLine("\n------ Aluno removido ------\n");
            foreach (KeyValuePair<string, double> item2 in dic3)
            {
                Console.WriteLine($"Nome: {item2.Key} -- Nota: {item2.Value}");
            }
            // adicionar um novo aluno ao dicionário
            dic3.Add("Lucas", 8.5);
            Console.WriteLine("\n------ Aluno adicionado ------\n");
            foreach (KeyValuePair<string, double> item3 in dic3)
            {
                Console.WriteLine($"Nome: {item3.Key} -- Nota: {item3.Value}");
            }
            //Ordenar os alunos por nome
            Console.WriteLine("\n------ Alunos ordenados por nome ------\n");
            var alunosOrdenados = new SortedDictionary<string, double>(dic3);
            foreach (KeyValuePair<string, double> item4 in alunosOrdenados)
            {
                Console.WriteLine($"Nome: {item4.Key} -- Nota: {item4.Value}");
            }
            // remover todos os alunos do dicionário
            dic3.Clear();
                Console.WriteLine("\n------ Dicionário limpo ------\n");
            foreach (KeyValuePair<string, double> item5 in dic3)
            {
                Console.WriteLine("Tudo limpo");
            }
        }
    }
}