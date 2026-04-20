namespace Eventos
{
    class SMS
    {
        public static void Enviar(object? sender, PedidosEventArgs e)
        {
            Console.WriteLine($"\nEnviando um SMS para {e.Telefone}");
        }
    }
}