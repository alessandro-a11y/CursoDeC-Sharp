// Tools/FinanceTools.cs

using System.ComponentModel;
using System.Text.Json;

namespace FinanceAI.Tools;

public class FinanceTools
{
    [Description("Calcula juros compostos")]
    public string CalculateCompoundInterest(
        double capital,
        double interestRate,
        int months)
    {
        double amount =
            capital * Math.Pow(
                1 + (interestRate / 100),
                months);

        return JsonSerializer.Serialize(new
        {
            capital,
            interestRate,
            months,
            amount = Math.Round(amount, 2)
        });
    }

    [Description("Calcula gastos mensais")]
    public string CalculateMonthlyExpenses(
        double rent,
        double food,
        double transport,
        double entertainment)
    {
        double total =
            rent +
            food +
            transport +
            entertainment;

        return JsonSerializer.Serialize(new
        {
            rent,
            food,
            transport,
            entertainment,
            total
        });
    }
}