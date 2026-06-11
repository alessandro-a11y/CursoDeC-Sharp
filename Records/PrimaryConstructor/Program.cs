using System;
using System.Linq;

namespace PrimaryConstructor
{
    internal class Program
    {
        public static void Main(string[] args)
        {

        }
    }
    public class Pedido(Guid clienteID, List<string> itens, DateTime data)
    {
        public Guid ClienteId { get; } = clienteID != Guid.Empty
            ? clienteID
            : throw new ArgumentException("Cliente inválido");

        public List<string> Itens { get; } = itens is { Count: > 0 }
            ? itens
            : throw new ArgumentException("Itens obrigatórios");

        public DateTime Data { get; } = data != default
            ? data
            : throw new ArgumentException("Data inválida");
    }
}