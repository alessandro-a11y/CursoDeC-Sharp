using System;
namespace Sobrecargas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Email email = new Email();
            email.Enviar("figueiredoAlessandro73@gmail.com");

            email.Enviar("\nfigueiredoAlessandro73@gmail.com",
                "testanto meus conhecimentos em sobrecargas\n"
                );

            email.Enviar("figueiredoalessandro73@gmail.com",
                "testando meus conhecimentos", 
                1500);
        }
    }
    public class Email
    {
        public void Enviar(string endereco)
        {
            Console.WriteLine($"{endereco}");
            Console.WriteLine("Assunto padrão");
        }

        public void Enviar(string endereco, string assunto)
        {
            Console.WriteLine($"{endereco}");
            Console.WriteLine($"{assunto}");
        }
        public void Enviar(string endereco, string assunto, int valor)
        {
            Console.WriteLine($"{endereco}");
            Console.WriteLine($"{assunto}");
            Console.WriteLine($"{valor}");
        }

    }
}