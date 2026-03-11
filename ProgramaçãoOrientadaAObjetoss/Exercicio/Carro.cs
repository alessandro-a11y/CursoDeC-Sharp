namespace Exercicio
{
    public class Carro : IVeiculo 
    {
        public int QuantidadeInicial { get; set; }

        public Carro(int quantidadeInicial)
        {
            QuantidadeInicial = quantidadeInicial;
        }
        public void Dirigir()
        {
            if (QuantidadeInicial > 0)
            {
                Console.WriteLine("Dirigindo...");
                QuantidadeInicial--;
            }
            else
            {
                Console.WriteLine("Sem combustível");
            }
        }

        public bool Abastecer(int quantidade)
        {
            QuantidadeInicial += quantidade;
            return true;
        }
    }
}
