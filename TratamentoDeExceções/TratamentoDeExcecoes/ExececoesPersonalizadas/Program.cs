using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ExececoesPersonalizadas
{
    internal class Program
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
        public class SaldoInsuficienteException : Exception
        {
            public SaldoInsuficienteException()
            {
            }

            public SaldoInsuficienteException(string? message) : base(message)
            {
            }

            public SaldoInsuficienteException(string? message, Exception? innerException) : base(message, innerException)
            {
            }

            protected SaldoInsuficienteException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
        }
        public class Conta
        {
            public Conta(int numero, string? titular, decimal saldo)
            {
                Numero = numero;
                Titular = titular;
                Saldo = saldo;
            }

            public int Numero { get; set; }
            public string? Titular { get; set; }
            public decimal Saldo { get; set; }

            public decimal Depositar(decimal valor)
            {
                Saldo += valor;
                Console.WriteLine($"Despositou: {valor}");
                return Saldo;
            }
            public decimal Sacar(decimal valor)
            {
                Console.WriteLine($"Sacou: {valor}");
                if (Saldo < valor)
                {
                    throw new SaldoInsuficienteException("Saldo insuficiente");
                }
                else
                {
                    Saldo -= valor;
                    return Saldo;
                }
            }
            public override string ToString()
            {
                return $"Conta: {Numero} : {Titular} - Saldo = {Saldo}";
            }

        }
    }
}