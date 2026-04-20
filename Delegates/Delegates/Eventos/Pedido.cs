namespace Eventos
{
    class Pedido
    {
        public event EventHandler<PedidosEventArgs>? OnCriarPedido;

        public void CriarPedido(string email, string telefone)
        {
            Console.WriteLine("\nPedido criado");

            // Forma moderna
            OnCriarPedido?.Invoke(this, new PedidosEventArgs { Email = email, Telefone = telefone });
        }
    }
}