using System;
namespace GetHashCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pessoa1 = new Pessoa(123456, "Alessandro");
            var pessoa2 = new Pessoa(133456, "Alessandro");
            var pessoa3 = new Pessoa(143456, "Alessandro");


            Console.WriteLine("pessoa1 ---> CPF = 123456 NOME = Alessandro");
            Console.WriteLine("pessoa2 ---> CPF = 133456 NOME = Alessandro");
            Console.WriteLine("pessoa3 ---> CPF = 143456 NOME = Alessandro");

            Console.WriteLine("\nComparando objetos Pessoa - GetHashCode");
            Console.WriteLine($"pessoa1 = {pessoa1.GetHashCode()}");
            Console.WriteLine($"pessoa2 = {pessoa2.GetHashCode()}");
            Console.WriteLine($"pessoa3 = {pessoa3.GetHashCode()}");
        }
    }
    public class Pessoa
    {
        public int CPF { get; set; }
        public string Nome { get; set; }


        public override bool Equals(object? obj)
        {
            if (obj == null) 
                return false;
            if ((obj is not Pessoa))
                return false;

            var other = (Pessoa)obj;

            return CPF.Equals(other.CPF);
        }
        public Pessoa(int cpf, string nome)
        {
            CPF = cpf;
            Nome = nome;
        }
    }
}

//string a = "José";
//string b = "José";

//int x = 100;
//int y = 100;

//Console.WriteLine(a.Equals(b));
//Console.WriteLine(x.Equals(y));



//string a = "José";
//string b = "José";

//Console.WriteLine(a + "=" + a.GetHashCode());
//Console.WriteLine(b + "=" + b.GetHashCode());