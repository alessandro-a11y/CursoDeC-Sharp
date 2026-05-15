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

using Microsoft.Extensions.AI;
using OllamaSharp;

namespace FinanceAI;

public class Program
{
    public static async Task Main(string[] args)
    {
        WebApplicationBuilder builder =
            WebApplication.CreateBuilder(args);

        // ==================================================
        // CONFIGURAÇÃO DA PORTA
        // ==================================================

        builder.WebHost.UseUrls("http://0.0.0.0:11134");

        // ==================================================
        // INJEÇÃO DE DEPENDÊNCIA
        // ==================================================

        builder.Services.AddSingleton<IChatClient>(
            serviceProvider =>
            {
                return new OllamaApiClient(
                    new Uri("http://localhost:11434"),
                    "gpt-oss:20b"
                );
            });

        builder.Services.AddSingleton<EmbeddingService>();
        builder.Services.AddSingleton<VectorDatabase>();
        builder.Services.AddSingleton<FinanceTools>();
        builder.Services.AddSingleton<FinanceAIService>();

        WebApplication app = builder.Build();

        // ==================================================
        // ENDPOINT PARA ADICIONAR DOCUMENTOS NO RAG
        // ==================================================

        app.MapPost(
            "/documents",
            async (
                DocumentRequest request,
                VectorDatabase vectorDatabase,
                EmbeddingService embeddingService) =>
            {
                await vectorDatabase.AddDocumentAsync(
                    request.Content,
                    embeddingService);

                return Results.Ok(new
                {
                    message = "Documento indexado com sucesso."
                });
            });

        // ==================================================
        // ENDPOINT PRINCIPAL DO CHAT
        // ==================================================

        app.MapPost(
            "/chat",
            async (
                ChatRequest request,
                FinanceAIService financeService) =>
            {
                string response =
                    await financeService
                        .SendMessageAsync(
                            request.Message);

                return Results.Ok(new
                {
                    response
                });
            });

        Console.WriteLine(
            "\nFINANCE AI ONLINE NA PORTA 11134\n");

        await app.RunAsync();
    }
}
