using System;
using System.Collections.Generic;
namespace PedidosOnline
{
    internal partial class Program : PedidosMaiorQueZero
    {
        static void Main(string[] args)
        {
            Queue<Pedido> filaPedidos = new Queue<Pedido>();
            filaPedidos.Enqueue(new Pedido(1, 100.50));
            filaPedidos.Enqueue(new Pedido(2, 250.75));
            filaPedidos.Enqueue(new Pedido(3, 80.20));

            Console.WriteLine($"\nNúmero de pedidos na fila : {filaPedidos.Count()}");

            PedidosMaioresqueZero(filaPedidos);

            filaPedidos.Enqueue(new Pedido(4, 150.00));
            filaPedidos.Enqueue(new Pedido(5, 300.00));
            filaPedidos.Enqueue(new Pedido(6, 50.00));

            PedidosDiferentesDeNull(filaPedidos);
        }

        private static void PedidosDiferentesDeNull(Queue<Pedido> filaPedidos)
        {
            int numeroPedido = 7;
            Pedido? pedidoLocalizado = filaPedidos.FirstOrDefault(p => p.Numero == numeroPedido);

            if (pedidoLocalizado != null)
            {
                Console.WriteLine($"Pedido #{pedidoLocalizado.Numero} encontrado - Valor: R${pedidoLocalizado.Valor}");
            }
            else
            {
                Console.WriteLine($"Pedido #{numeroPedido} não encontrado na fila.");
            }
        }
    }
}