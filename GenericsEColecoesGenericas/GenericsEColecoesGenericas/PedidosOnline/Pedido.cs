namespace PedidosOnline
{
    internal partial class Program
    {
        class Pedido
        {
            public int Numero { get; set; }
            public double Valor { get; set; }

            public Pedido(int numero, double valor)
            {
                Numero = numero;
                Valor = valor;
            }
        }
    }
}