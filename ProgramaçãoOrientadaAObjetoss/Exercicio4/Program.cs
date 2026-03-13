/*
 * Crie um programa que solicite ao usuário os nomes de três pessoas e os armazene em uma 
matriz de objetos do tipo Pessoa. 
Para fazer isso, primeiro crie uma classe Pessoa que tenha uma propriedade Nome do tipo 
string, um construtor que receba o nome como parâmetro e sobrescreva o método 
ToString().
Finalize o programa lendo as pessoas e executando o método ToString() na tela.
 */

using System;
using System.Collections.Generic;
namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa [] pessoas = new Pessoa[3];
            pessoas[0] = new Pessoa("Alice");
            pessoas[1] = new Pessoa("Bob");
            pessoas[2] = new Pessoa("Charlie");

            foreach (var item in pessoas)
            {
                // Chamar ToString() ou passar o objeto diretamente para Console.WriteLine
                Console.WriteLine(item.ToString());
            }

        }
    }
    public class Pessoa
    {
        public string Nome { get; set; }
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        // Sobrescreve ToString conforme o enunciado
        public override string ToString()
        {
            return $"Pessoa: {Nome}";
        }
    }
}