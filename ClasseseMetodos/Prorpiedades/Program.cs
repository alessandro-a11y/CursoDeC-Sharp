using System;
namespace Propriedades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();
            produto.Nome = "Caneta";
            produto.Preco = 1.99;
            produto.EstoqueMinimo = 100;

            produto.Exibir();

        }
    }
    public class Produto
    {
        private string nome;
        public string Nome
        {
            get { return nome.ToUpper(); }
            set { nome = value; }
        }
        private double preco;
        public double Preco 
        { 
            get { return preco; }
            set
            {
                if (value < 5.00)
                {
                    preco = 5.00;
                }
                else
                {
                    preco = value;
                }
            }
        }
        private double desconto = 0.05;
        public double Desconto
        {
            get { return desconto; }
        }
        private int estoqueMinimo;
        public int EstoqueMinimo 
        {
            get 
            {
                return estoqueMinimo; 
            }
            set 
            { 
                estoqueMinimo = value; 
            }
        }

        public double PrecoFinal
        {
            get { return Preco - (Preco * Desconto); }
        }

        public void Exibir()
        {
            Console.WriteLine(
                $"Nome: {Nome}" +
                $"\nPreço: {Preco:C}" +
                $"\nDesconto: {Desconto:P}" +
                $"\nPreço Final: {PrecoFinal:C}" +
                $"\nEstoque mínimo: {estoqueMinimo}"
            );
        }
    }
}
