namespace Eventos
{
    class PedidosEventArgs : EventArgs
    {
        public string? Email { get; set; }
        public string? Telefone { get; set; }
    }
}