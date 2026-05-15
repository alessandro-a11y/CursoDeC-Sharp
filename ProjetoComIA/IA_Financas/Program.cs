// Program.cs

using FinanceAI.Services;
using FinanceAI.Tools;
using Microsoft.Extensions.AI;
using OllamaSharp;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IChatClient>(_ =>
    new OllamaApiClient(
        new Uri("http://host.docker.internal:11434"),
        "gpt-oss:20b"
    )
);

builder.Services.AddSingleton<FinanceTools>();
builder.Services.AddSingleton<FinanceChatService>();

var app = builder.Build();

app.MapPost("/chat", async (
    ChatRequest request,
    FinanceChatService financeService) =>
{
    var response =
        await financeService.SendMessageAsync(request.Message);

    return Results.Ok(new
    {
        response
    });
});

app.Run(); Message);