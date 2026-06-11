using System;
using System.IO;
using System.Runtime.CompilerServices;

public static class Ensure
{
    public static void That(
        bool condition,
        string? message = null,

        [CallerArgumentExpression(nameof(condition))]
        string? expression = null,

        [CallerMemberName]
        string? member = null,

        [CallerFilePath]
        string? file = null,

        [CallerLineNumber]
        int line = 0)
    {
        if (condition)
        {
            Console.WriteLine(
                $"[OK] {expression}\n" +
                $"     Método : {member}\n" +
                $"     Arquivo: {Path.GetFileName(file)}\n" +
                $"     Linha  : {line}\n");
            return;
        }

        throw new InvalidOperationException(
            $"""
            ==================================================
            VALIDAÇÃO FALHOU
            ==================================================

            Expressão:
                {expression}

            Mensagem:
                {message ?? "Nenhuma mensagem informada"}

            Local:
                Método : {member}
                Arquivo: {Path.GetFileName(file)}
                Linha  : {line}

            Horário:
                {DateTime.Now:dd/MM/yyyy HH:mm:ss}

            ==================================================
            """
        );
    }
}

public class ContaBancaria
{
    public string Titular { get; set; } = "";
    public decimal Saldo { get; set; }

    public void Sacar(decimal valor)
    {
        Ensure.That(
            valor > 0,
            "O valor do saque deve ser positivo");

        Ensure.That(
            Saldo >= valor,
            "Saldo insuficiente");

        Saldo -= valor;

        Console.WriteLine(
            $"Saque realizado. Novo saldo: {Saldo:C}");
    }
}

class Program
{
    static void Main()
    {
        var conta = new ContaBancaria
        {
            Titular = "Alessandro",
            Saldo = 5000m
        };

        decimal valorSaque = 7000m;

        conta.Sacar(valorSaque);
    }
}