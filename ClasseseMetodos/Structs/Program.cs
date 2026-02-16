using System;
namespace Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "João";
            cliente.Idade = 30;
            cliente.ExibirDados();
        }
    }
    public struct Cliente
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public Cliente(string? nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}\tIdade: {Idade}");
        }
    }
}