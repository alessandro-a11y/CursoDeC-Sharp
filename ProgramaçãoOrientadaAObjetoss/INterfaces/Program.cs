using System;
namespace INterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IControle controle = new Demo();
            controle.Desenhar();
            controle.Exibir();

        }
    }
    interface IControle
    {
        void Desenhar();

        public void Exibir()
        {
            Console.WriteLine("Exibindo");
        }
    }
    public class Demo : IControle
    {
        public void Desenhar()
        {
            Console.WriteLine("Dsenhando");
        }
    }
    interface IGrafico
    {
        void Desenhar();
    }
     public class Grafico : IGrafico
    {
        public void Desenhar()
        {
            Console.WriteLine("Dsenhando");
        }
    }
}