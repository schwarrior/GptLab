using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.UserSecrets;
using Microsoft.SemanticKernel;
// using Microsoft.SemanticKernel.Connectors.OpenAI;

Console.WriteLine("GPT Lab Starting...");

var config = new ConfigurationBuilder()
    .AddUserSecrets<Program>()
    .Build();


var apiKeyId = "OpenAI:ApiKey";
var apiKey = config[apiKeyId];

Debug.Assert(!string.IsNullOrEmpty(apiKey), $"API key not found. Please add it to user secrets with the key '{apiKeyId}'.");

Console.WriteLine($"Loaded {apiKeyId}");

// var builder = Kernel.CreateBuilder();

// builder.AddOpenAIChatCompletion(
//     modelId: "gpt-4o-mini", // inexpensive + good for dev
//     apiKey: apiKey
// );

// var kernel = builder.Build();

// var result = await kernel.InvokePromptAsync("Explain what RAG is in 3 sentences.");

// Console.WriteLine(result);

