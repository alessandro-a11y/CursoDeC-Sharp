
// Classes Filhas
public class CartaoCredito : Pagamento
{
    public string NumeroCartao { get; set; }
    public void ProcessarEstorno() => Console.WriteLine("Estorno solicitado para o cartão.");
}
