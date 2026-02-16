using System;
using PartialClass;
namespace PartialClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            MInhaPartialClassProps pessoa = new MInhaPartialClassProps();
            pessoa.Nome = "Ana Silva";
            pessoa.DataNascimento = new DateTime(1990, 5, 15);
            MinhaPartialClass calculos = new MinhaPartialClass();
            TimeSpan idade = calculos.CalculaIdade(pessoa.DataNascimento);
            Console.WriteLine($"{pessoa.Nome} tem {idade.Days / 365} anos.");
            DateTime outraData = new DateTime(2020, 1, 1);
            TimeSpan diferenca = calculos.DiferencaEntreDatas(DateTime.Now, outraData);
            Console.WriteLine($"Diferença entre hoje e {outraData.ToShortDateString()} é de {diferenca.Days} dias.");
        }


    }
}