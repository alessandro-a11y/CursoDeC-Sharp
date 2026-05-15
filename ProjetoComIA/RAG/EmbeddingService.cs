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
// SERVICE DE EMBEDDINGS
// ==========================================================

public class EmbeddingService
{
    private readonly OllamaApiClient _embeddingClient;

    // ======================================================
    // CONSTRUTOR
    // ======================================================

    public EmbeddingService()
    {
        _embeddingClient =
            new OllamaApiClient(
                new Uri("http://localhost:11434"),
                "nomic-embed-text"
            );
    }

    // ======================================================
    // GERA EMBEDDING
    // ======================================================

    public async Task<float[]> GenerateEmbeddingAsync(
        string text)
    {
        var result =
            await _embeddingClient
                .EmbedAsync(text);

        return result
            .Embeddings
            .First()
            .ToArray();
    }
}
