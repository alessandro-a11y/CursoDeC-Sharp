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

namespace FinanceAI;

// ==========================================================
// SERVICE PRINCIPAL DA IA
// ==========================================================

public class FinanceAIService
{
    private readonly IChatClient _chatClient;

    private readonly VectorDatabase _vectorDatabase;

    private readonly EmbeddingService _embeddingService;

    private readonly FinanceTools _financeTools;

    // ======================================================
    // CONSTRUTOR
    // ======================================================

    public FinanceAIService(
        IChatClient chatClient,
        VectorDatabase vectorDatabase,
        EmbeddingService embeddingService,
        FinanceTools financeTools)
    {
        _chatClient = chatClient;

        _vectorDatabase = vectorDatabase;

        _embeddingService = embeddingService;

        _financeTools = financeTools;
    }

    // ======================================================
    // MÉTODO PRINCIPAL DO CHAT
    // ======================================================

    public async Task<string> SendMessageAsync(
        string userMessage)
    {
        // ==================================================
        // BUSCA CONTEXTO NO RAG
        // ==================================================

        string ragContext =
            await _vectorDatabase.SearchAsync(
                userMessage,
                _embeddingService);

        // ==================================================
        // REGISTRO DAS TOOLS
        // ==================================================

        List<AITool> tools =
        [
            AIFunctionFactory.Create(
                _financeTools.CalculateCompoundInterest),

            AIFunctionFactory.Create(
                _financeTools.CalculateMonthlyExpenses)
        ];

        // ==================================================
        // HISTÓRICO DO CHAT
        // ==================================================

        List<ChatMessage> history =
        [
            new(
                ChatRole.System,
                $"""
                Você é uma IA especialista em finanças.

                Utilize o contexto abaixo para responder.

                CONTEXTO:
                {ragContext}

                Sempre utilize tools quando necessário.
                """
            ),

            new(ChatRole.User, userMessage)
        ];

        // ==================================================
        // CHAMADA DO MODELO
        // ==================================================

        ChatResponse response =
            await _chatClient.GetResponseAsync(
                history,
                new ChatOptions
                {
                    Tools = tools
                });

        return response.Text
               ?? "Sem resposta.";
    }
}
