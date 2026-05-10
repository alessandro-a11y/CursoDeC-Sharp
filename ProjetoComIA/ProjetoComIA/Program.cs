using Microsoft.Extensions.AI;
using OllamaSharp;

IChatClient chatClient =
    new OllamaApiClient(
        new Uri("http://localhost:11434"),
        "gpt-oss:20b"
    );

List<ChatMessage> historicoChat = new();

Console.WriteLine("Chat GPT-OSS");
Console.WriteLine("Digite 'sair' para encerrar");
Console.WriteLine();

while (true)
{
    Console.Write("Você: ");
    var mensagemUsuario = Console.ReadLine();

    if (mensagemUsuario?.Trim().ToLower() == "sair")
    {
        Console.WriteLine("Encerrando...");
        break;
    }

    if (string.IsNullOrWhiteSpace(mensagemUsuario))
        continue;

    historicoChat.Add(
        new ChatMessage(ChatRole.User, mensagemUsuario)
    );

    Console.Write("Assistente: ");

    string respostaCompleta = "";

    await foreach (var item in chatClient.GetStreamingResponseAsync(historicoChat))
    {
        Console.Write(item.Text);
        respostaCompleta += item.Text;
    }

    Console.WriteLine();
    Console.WriteLine();

    historicoChat.Add(
        new ChatMessage(ChatRole.Assistant, respostaCompleta)
    );
}