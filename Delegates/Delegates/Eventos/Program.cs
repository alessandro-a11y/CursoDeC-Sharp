using System;

namespace Eventos
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido();

            // Inscrevendo métodos no evento
            pedido.OnCriarPedido += Email.Enviar;
            pedido.OnCriarPedido += SMS.Enviar;

            pedido.CriarPedido("exemplo@email.com", "123456789");
        }
    }
    class PedidosEventArgs : EventArgs
    {
        public string? Email { get; set; }
        public string? Telefone { get; set; }
    }
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
    class Email
    {
        public static void Enviar(object? sender, PedidosEventArgs e)
        {
            Console.WriteLine($"\nEnviando um email para {e.Email}");
        }
    }
    class SMS
    {
        public static void Enviar(object? sender, PedidosEventArgs e)
        {
            Console.WriteLine($"\nEnviando um SMS para {e.Telefone}");
        }
    }
}