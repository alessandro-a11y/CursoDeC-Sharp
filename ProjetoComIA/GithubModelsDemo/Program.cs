using Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using OpenAI;
using System.ClientModel;
using System.Text;

namespace GitHubModelsDemo;

public class Program
{
    public static async Task Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.Title = "GitHub Models Chat";

        var config = new ConfigurationBuilder()
            .AddUserSecrets<Program>()
            .Build();

        var githubPAT = config["GIT_PATH"];

        if (string.IsNullOrWhiteSpace(githubPAT))
        {
            Console.WriteLine("Token GitHub não encontrado.");
            return;
        }

        const string modelId = "gpt-5";
        const string endpoint = "https://models.inference.ai.azure.com";

        var client = new OpenAIClient(
            new ApiKeyCredential(githubPAT),
            new OpenAIClientOptions
            {
                Endpoint = new Uri(endpoint)
            });

        var builder = Kernel.CreateBuilder();

        builder.AddOpenAIChatCompletion(
            modelId,
            client);

        var kernel = builder.Build();

        var chatService = kernel.GetRequiredService<IChatCompletionService>();

        var history = new ChatHistory();

        history.AddSystemMessage("""
You are an expert assistant specialized in the GitHub Models API.

Your responsibilities:
- Explain concepts clearly
- Help developers integrate APIs
- Provide practical examples
- Debug errors
- Suggest best practices
- Generate production-quality code

Focus especially on:
- C#
- ASP.NET Core
- REST APIs
- Semantic Kernel
- AI integrations
- Streaming responses
- Tool Calling
- RAG architectures

Always answer with:
- concise explanations
- clean code
- professional structure
- practical examples
""");

        while (true)
        {
            Console.WriteLine();
            Console.Write("Você: ");

            var userQuestion = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userQuestion))
                break;

            history.AddUserMessage(userQuestion);

            Console.WriteLine();
            Console.WriteLine("GPT-5:");
            Console.WriteLine();

            var responseBuilder = new StringBuilder();

            var streamingResult =
                chatService.GetStreamingChatMessageContentsAsync(history);

            await foreach (var chunk in streamingResult)
            {
                if (!string.IsNullOrEmpty(chunk.Content))
                {
                    responseBuilder.Append(chunk.Content);
                    Console.Write(chunk.Content);
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            history.AddAssistantMessage(responseBuilder.ToString());
        }
    }
}