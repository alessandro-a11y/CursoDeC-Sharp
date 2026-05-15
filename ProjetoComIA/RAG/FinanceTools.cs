/*
==========================================================
FINANCE AI - RAG + EMBEDDINGS + TOOL CALLING
==========================================================

TECNOLOGIAS:
- ASP.NET Core
- Ollama
- Tool Calling
- Embeddings
- RAG
- Similaridade Cosseno
- IA Local
- Docker Ready
- POO
- Métodos
- Classes

MODELOS NECESSÁRIOS:

ollama pull gpt-oss:20b
ollama pull nomic-embed-text

RODAR:

dotnet run

ENDPOINTS:

POST http://localhost:11134/documents
POST http://localhost:11134/chat

==========================================================
*/

using System.ComponentModel;
using System.Text.Json;

namespace FinanceAI;

// ==========================================================
// TOOLS DA IA
// ==========================================================

public class FinanceTools
{
    // ======================================================
    // TOOL DE JUROS COMPOSTOS
    // ======================================================

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

    // ======================================================
    // TOOL DE GASTOS MENSAIS
    // ======================================================

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
