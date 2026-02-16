using System;
namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia1 = (int)DiasDaSemana.Segunda;
            int dia2 = (int)DiasDaSemana.Terça;
            int dia3 = (int)DiasDaSemana.Quarta;
            int dia4 = (int)DiasDaSemana.Quinta;
            int dia5 = (int)DiasDaSemana.Sexta;
            int dia6 = (int)DiasDaSemana.Sabado;
            int dia7 = (int)DiasDaSemana.Domingo;

            Console.WriteLine(dia1);
            Console.WriteLine(dia2);
            Console.WriteLine(dia3);
            Console.WriteLine(dia4);
            Console.WriteLine(dia5);
            Console.WriteLine(dia6);
            Console.WriteLine(dia7);
            Console.WriteLine("======================================");
            Console.WriteLine(DiasDaSemana.Segunda);
            Console.WriteLine(DiasDaSemana.Terça);
            Console.WriteLine(DiasDaSemana.Quarta);
            Console.WriteLine(DiasDaSemana.Quinta);
            Console.WriteLine(DiasDaSemana.Sexta);
            Console.WriteLine(DiasDaSemana.Sabado);
            Console.WriteLine(DiasDaSemana.Domingo);
        }
    }
}