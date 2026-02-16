using System;

namespace ClasseeAlocacaoDeMemoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alocacao();
        }

        public static void Alocacao()
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "Maria";
            p1.idade = 24;
            p1.sexo = "Feminino";

            Console.WriteLine($"{p1.nome}, {p1.idade}, {p1.sexo}");

            Pessoa p2 = p1;
            Console.WriteLine($"{p2.nome}, {p2.idade}, {p2.sexo}");
        }
    }

    class Pessoa
    {
        public string nome;
        public int idade;
        public string sexo;
    }
}
