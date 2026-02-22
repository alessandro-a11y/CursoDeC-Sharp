using System;
using System.Collections.Generic;


namespace ExerciciosHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta[] contas = {
        new ContaCorrente(),
        new ContaPoupaca(),
        new ContaInvestimento()
    };

            foreach (var conta in contas)
            {
                Console.WriteLine($"--- {conta.GetType().Name} ---");
                conta.DepositarValor(1000);
                conta.Sacar(100);
                conta.ExibirSaldo();

                conta.Sacar(2000);
                conta.ExibirSaldo();

                Console.WriteLine();
            }
        }
    }
}