using System;
using System.Collections.Generic;
using System.Linq;

namespace Records
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Usar o record aninhado 'UsuarioRecord' que suporta a expressão 'with'
            var usuario1 = new UsandoRecord.UsuarioRecord("João", "joao@example.com", 30);

            Console.WriteLine($"\nUsuário Original: {usuario1}");

            UsandoRecord.UsuarioRecord usuarioCopia = usuario1 with { Email = "jose@example.com" };

            Console.WriteLine($"\nApós a alteração: {usuarioCopia}");
        }
    }

    public class UsandoRecord
    {
        private string v1;
        private string v2;
        private int v3;

        public UsandoRecord(string v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public record UsuarioRecord(string Nome, string Email, int Idade);
    }
}