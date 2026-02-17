using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ExercicioFinal
{
    internal partial class Mercado
    {
        static void Main()
        {
            List<Produto> produtos = new List<Produto>
            {
                new Produto("Arroz", 10.50m),
                new Produto("Feijão", 8.30m),
                new Produto("Macarrão", 5.20m),
                new Produto("Óleo", 7.80m),
                new Produto("Açúcar", 4.60m)
            };

            Produto.ExibirRelatorio(produtos);
            Console.WriteLine("--- MOCHILA ADICIONADA ---");
            produtos.Add(new Produto(" Mochila", 22.44m));

            Produto.ExibirRelatorio(produtos);


            produtos.OrderBy(p => p.Preco).ToList().ForEach(p => Console.WriteLine($"- {p.Nome}: R$ {p.Preco:F2}"));

            Produto.ExibirRelatorio(produtos);


            foreach (var p in produtos)
            {
                if (p.Preco < 5.00m)
                {
                    Console.WriteLine("--- PRODUTOS ABAIXO DE CINCO REAIS ---");
                    Console.WriteLine($"- {p.Nome}: R$ {p.Preco:F2}");
                }
            }

            // "Existe algum p tal que o nome de p seja igual a 'estojo'?"
            bool temEstojo = produtos.Any(p => p.Nome.ToLower() == "estojo");

            if (temEstojo)
            {
                Console.WriteLine("O estojo está na lista!");
            }

        }
    }
}
