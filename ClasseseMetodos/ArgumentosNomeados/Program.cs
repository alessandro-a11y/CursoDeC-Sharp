using System;
namespace ArgumentosNomeados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Email email = new Email();
            email.Enviar(titulo: "Demissão",
                assunto:"Demissão por causa de insultos",
                destino: "figueiredoalessandro73@gmail.com"
                ); 
        }
    }
    public class Email
    {
        public void Enviar(string destino, string titulo, string assunto)
        {
            Console.WriteLine($"Email:{destino}\nTítulo: {titulo}\nAssunto: {assunto}");
        }
    }
}