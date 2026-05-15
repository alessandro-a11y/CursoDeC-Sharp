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
// BANCO VETORIAL EM MEMÓRIA
// ==========================================================

public class VectorDatabase
{
    // ======================================================
    // LISTA DE DOCUMENTOS
    // ======================================================

    private readonly List<VectorDocument> _documents;

    // ======================================================
    // CONSTRUTOR
    // ======================================================

    public VectorDatabase()
    {
        _documents = [];
    }

    // ======================================================
    // ADICIONA DOCUMENTO
    // ======================================================

    public async Task AddDocumentAsync(
        string content,
        EmbeddingService embeddingService)
    {
        // ==================================================
        // GERA EMBEDDING DO DOCUMENTO
        // ==================================================

        float[] embedding =
            await embeddingService
                .GenerateEmbeddingAsync(content);

        // ==================================================
        // CRIA DOCUMENTO VETORIAL
        // ==================================================

        VectorDocument document =
            new()
            {
                Content = content,

                Embedding = embedding
            };

        // ==================================================
        // SALVA DOCUMENTO
        // ==================================================

        _documents.Add(document);
    }

    // ======================================================
    // BUSCA DOCUMENTO MAIS PARECIDO
    // ======================================================

    public async Task<string> SearchAsync(
        string query,
        EmbeddingService embeddingService)
    {
        // ==================================================
        // GERA EMBEDDING DA PERGUNTA
        // ==================================================

        float[] queryEmbedding =
            await embeddingService
                .GenerateEmbeddingAsync(query);

        VectorDocument? bestDocument = null;

        double bestScore = -1;

        // ==================================================
        // COMPARA TODOS DOCUMENTOS
        // ==================================================

        foreach (VectorDocument document in _documents)
        {
            double similarity =
                CalculateCosineSimilarity(
                    queryEmbedding,
                    document.Embedding);

            if (similarity > bestScore)
            {
                bestScore = similarity;

                bestDocument = document;
            }
        }

        // ==================================================
        // RETORNA MELHOR CONTEXTO
        // ==================================================

        return bestDocument?.Content
               ?? "Nenhum contexto encontrado.";
    }

    // ======================================================
    // SIMILARIDADE COSSENO
    // ======================================================

    private double CalculateCosineSimilarity(
        float[] vectorA,
        float[] vectorB)
    {
        double dot = 0;

        double magnitudeA = 0;

        double magnitudeB = 0;

        for (int i = 0; i < vectorA.Length; i++)
        {
            dot += vectorA[i] * vectorB[i];

            magnitudeA +=
                Math.Pow(vectorA[i], 2);

            magnitudeB +=
                Math.Pow(vectorB[i], 2);
        }

        magnitudeA = Math.Sqrt(magnitudeA);

        magnitudeB = Math.Sqrt(magnitudeB);

        return dot / (magnitudeA * magnitudeB);
    }
}