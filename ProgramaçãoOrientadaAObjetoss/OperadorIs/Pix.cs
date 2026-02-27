public class Pix : Pagamento
{
    public string ChavePix { get; set; }
    public void GerarQRCode() => Console.WriteLine("QR Code gerado com sucesso.");
}
