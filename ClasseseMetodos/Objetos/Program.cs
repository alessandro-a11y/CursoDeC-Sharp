using System;
namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Objetos();
        }
        public static void Objetos()
        {
            Cachorro bilu = new Cachorro();
            bilu.nome = "Bilu";
            bilu.cor = "Marrom";
            bilu.sexo = "Macho";

            Cachorro pipoca = new Cachorro();
            pipoca.nome = "Pipoca";
            pipoca.cor = "Branco";
            pipoca.sexo = "Fêmea";
        }
        public class Cachorro
        {
            public string nome;
            public string cor;
            public string sexo;
        }
    }
}