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
// REQUEST PARA DOCUMENTOS
// ==========================================================

public class DocumentRequest
{
    public string Content { get; set; } = string.Empty;
}
