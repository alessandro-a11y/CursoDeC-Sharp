namespace PedidosOnline
{
    internal class PedidosMaiorQueZero
    {

        public static void PedidosMaioresqueZero(Queue<Pedido> filaPedidos)
        {
            while (filaPedidos.Count > 0)
            {
                Pedido pedidoAtual = filaPedidos.Dequeue();
                Console.WriteLine($"Processando pedido #{pedidoAtual.Numero} - Valor: R${pedidoAtual.Valor}");
            }
        }
    }
}