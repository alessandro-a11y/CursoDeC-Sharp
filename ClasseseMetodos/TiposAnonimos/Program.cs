using System;
namespace TiposAnonimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var aluno = new
            {
                Nome = "Carlos",
                Idade = 22,
                Curso = "Engenharia de Software",
                Endereco = new
                {
                    Rua = "Av. Brasil",
                    Numero = 1000,
                    Cidade = "São Paulo"
                }

            };
            var aluno1 = new[]
            {
                new {
                    Nome = "Carlos",
                    Idade = 22,
                    Curso = "Engenharia de Software"
                },
                new {
                    Nome = "Ana",
                    Idade = 20,
                    Curso = "Medicina"
                },
            };

            //var produto = new { Nome = "Notebook",
            //    Preco = 2500.00, 
            //    Categoria = "Eletrônicos" };

            //Console.WriteLine($"Produto: {produto.Nome}, " +
            //    $"Preço: {produto.Preco}, " +
            //    $"Categoria: {produto.Categoria}");

            //var pessoa = new { Nome = "Ana", 
            //    Idade = 28, 
            //    Profissao = "Engenheira" };

            //Console.WriteLine($"Nome: {pessoa.Nome}, " +
            //    $"Idade: {pessoa.Idade}, " +
            //    $"Profissão: {pessoa.Profissao}");
        }
    }
}
