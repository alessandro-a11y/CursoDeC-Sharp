// Services/FinanceChatService.cs

using FinanceAI.Tools;
using Microsoft.Extensions.AI;

namespace FinanceAI.Services;

public class FinanceChatService
{
    private readonly IChatClient _chatClient;
    private readonly FinanceTools _financeTools;

    public FinanceChatService(
        IChatClient chatClient,
        FinanceTools financeTools)
    {
        _chatClient = chatClient;
        _financeTools = financeTools;
    }

    public async Task<string> SendMessageAsync(string message)
    {
        List<AITool> tools =
        [
            AIFunctionFactory.Create(
                _financeTools.CalculateCompoundInterest),

            AIFunctionFactory.Create(
                _financeTools.CalculateMonthlyExpenses)
        ];

        List<ChatMessage> history =
        [
            new(
                ChatRole.System,
                """
                Você é uma IA especialista em finanças.

                Você ajuda usuários com:
                - investimentos
                - planejamento financeiro
                - controle de gastos
                - juros compostos

                Sempre utilize tools quando necessário.
                """
            ),

            new(ChatRole.User, message)
        ];

        var response =
            await _chatClient.GetResponseAsync(
                history,
                new ChatOptions
                {
                    Tools = tools
                });

        return response.Text ?? "Sem resposta.";
    }
}