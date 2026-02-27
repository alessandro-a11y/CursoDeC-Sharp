using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Lista de Pagamentos (Polimorfismo: o tipo é a classe base)
        List<Pagamento> pagamentos = new List<Pagamento>
        {
            new CartaoCredito { NumeroCartao = "1234-5678" },
            new Pix { ChavePix = "contato@ai.com" },
            new CartaoCredito { NumeroCartao = "8765-4321" }
        };

        foreach (var p in pagamentos)
        {
            // O 'is' verifica o tipo real do objeto em tempo de execução
            if (p is CartaoCredito cartao)
            {
                // Aqui o objeto já foi convertido para CartaoCredito e se chama 'cartao'
                Console.WriteLine($"Pagamento via Cartão. Final: {cartao.NumeroCartao.Substring(5)}");
                cartao.ProcessarEstorno();
            }
            else if (p is Pix pix)
            {
                // Aqui o objeto já é tratado como Pix e se chama 'pix'
                Console.WriteLine($"Pagamento via Pix para a chave: {pix.ChavePix}");
                pix.GerarQRCode();
            }

            Console.WriteLine(new string('-', 30));
        }
    }
}