using System;
using System.Collections.Generic;
using System.Linq;
namespace ProjetoListaComDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>
            {
                new Pessoa("João", 20),
                new Pessoa("Maria", 18),
                new Pessoa("Pedro", 25),
                new Pessoa("Carlos", 15),
                new Pessoa ("Ana", 17)
            };

            // Percorrer e imprimir
            Action<Pessoa> imprimirPessoa = p => Console.WriteLine($"Nome: {p.Nome}, Idade: {p.Idade}");
            pessoas.ForEach(imprimirPessoa);

            // Filtrar maiores de 18
            Predicate<Pessoa> maiorDeIdade = p => p.Idade >= 18;
            List<Pessoa> maioresDeIdade = pessoas.FindAll(maiorDeIdade);

            //Pegar a pessoa mais velha
            Func<Pessoa, int> obterIdade = p => p.Idade;
            Pessoa pessoaMaisVelha = pessoas.OrderByDescending(obterIdade).FirstOrDefault();
             Console.WriteLine("\nMaiores de idade:");

            // Exibir o resultado final
            maioresDeIdade.ForEach(imprimirPessoa);
            Console.WriteLine($"\nPessoa mais velha: Nome: {pessoaMaisVelha.Nome}, Idade: {pessoaMaisVelha.Idade}");


        }
    }
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }


    }
}