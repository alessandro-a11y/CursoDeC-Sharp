namespace Eventos
{
    class Email
    {
        public static void Enviar(object? sender, PedidosEventArgs e)
        {
            Console.WriteLine($"\nEnviando um email para {e.Email}");
        }
    }
}