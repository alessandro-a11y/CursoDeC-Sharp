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
}