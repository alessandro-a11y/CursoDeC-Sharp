namespace ExercicioFinal
{
    internal partial class Mercado
    {
        public class Produto
        {
            public string Nome { get; set; }
            public decimal Preco { get; set; }
            public Produto(string nome, decimal preco)
            {
                Nome = nome;
                Preco = preco;
            }

            public static void ExibirRelatorio(List<Produto> produtos)
            {
                if (produtos.Count == 0)
                {
                    Console.WriteLine("A lista está vazia.");
                    return;
                }

                Console.WriteLine("--- RELAÇÃO DE PRODUTOS ---");
                foreach (var p in produtos)
                {
                    Console.WriteLine($"- {p.Nome}: R$ {p.Preco:F2}");
                }

                // Cálculos usando LINQ (mais simples e rápido)
                decimal somaTotal = produtos.Sum(p => p.Preco);
                decimal mediaPreco = produtos.Average(p => p.Preco);
                int quantidade = produtos.Count;

                Console.WriteLine("---------------------------");
                Console.WriteLine($"Quantidade de produtos: {quantidade}");
                Console.WriteLine($"Soma total: R$ {somaTotal:F2}");
                Console.WriteLine($"Média de preços: R$ {mediaPreco:F2}");
                Console.WriteLine("---------------------------");
            }
        }
    }
}
