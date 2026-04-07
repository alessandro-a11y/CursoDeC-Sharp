using System;
using System.Collections.Generic;

namespace ExececoesPersonalizadas
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Conta conta = new Conta(123, "João", 1000);
                Console.WriteLine(conta);
                conta.Depositar(500);
                Console.WriteLine(conta);
                conta.Sacar(2000);
                Console.WriteLine(conta);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine("Erro ao sacar: " + ex.Message);
            }
        }
    }
}