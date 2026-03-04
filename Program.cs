using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.UserSecrets;
using Microsoft.SemanticKernel;
// using Microsoft.SemanticKernel.Connectors.OpenAI;

Console.WriteLine("GPT Lab Starting...");

var apiKeyId = "OpenAI:ApiKey";
var config = new ConfigurationBuilder()
    .AddUserSecrets<Program>()
    .Build();
var apiKey = config[apiKeyId];
Debug.Assert(!string.IsNullOrEmpty(apiKey), $"API key not found. Please add it to user secrets with the key '{apiKeyId}'.");
Console.WriteLine($"Loaded {apiKeyId}");

string? question = null;
while (string.IsNullOrEmpty(question))
{
	Console.WriteLine();
	Console.WriteLine("Please enter your question for the model:");
	question = Console.ReadLine();
	Console.WriteLine();
}

var builder = Kernel.CreateBuilder();
builder.AddOpenAIChatCompletion(
    modelId: "gpt-4o-mini", // inexpensive + good for dev
    apiKey: apiKey
);
var kernel = builder.Build();
var result = await kernel.InvokePromptAsync(question);

Console.WriteLine(result);

