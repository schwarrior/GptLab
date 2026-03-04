```
  ______   _______   ________        __                  __       
 /      \ /       \ /        |      /  |                /  |      
/$$$$$$  |$$$$$$$  |$$$$$$$$/       $$ |        ______  $$ |____  
$$ | _$$/ $$ |__$$ |   $$ |         $$ |       /      \ $$      \ 
$$ |/    |$$    $$/    $$ |         $$ |       $$$$$$  |$$$$$$$  |
$$ |$$$$ |$$$$$$$/     $$ |         $$ |       /    $$ |$$ |  $$ |
$$ \__$$ |$$ |         $$ |         $$ |_____ /$$$$$$$ |$$ |__$$ |
$$    $$/ $$ |         $$ |         $$       |$$    $$ |$$    $$/ 
 $$$$$$/  $$/          $$/          $$$$$$$$/  $$$$$$$/ $$$$$$$/  
                                                                  
```

# Introduction

A laboratory for interacting with ChatGPT via API with Retrieval-Augmented Generation.


# Project Source Control

[Schwarrior GPT Lab](https://github.com/schwarrior/GptLab.git)


# ChatGPT Dialog

3/4/2026


## Prompt

Teach me to use a frontier model LLM via API ultimately including Retrieval-Augmented Generation. ChatGPT would be my preference but I would like to learn for free. I understand Gemini allows some free access to API. What do you suggest?


## Response

Instructions were given for setting up Chat API account credits. It was not free, as expected. $10 credit established. A bunch of sample python code was given and information about using vector storage. It makes me wonder if vector storage and semantic parsing is really necessary for basic RAG. We'll figure that out later.


## Prompt

Teach me to use the ChatGPT via API. I created GptLab, a C# .NET 10 console application in VS Code for this purpose. I funded a small amount of API credit and have obtained a Service Account API Key. I want to orchestrate this with the Microsoft Semantic Kernel.  Please start with instructions to add the Semantic Kernal to my project. Then explain how to add my API key to GtpLab project settings / secrets without leaking it onto GitHub.


## Response

```bash
dotnet add package Microsoft.SemanticKernel
dotnet add package Microsoft.SemanticKernel.Connectors.OpenAI
```

Code for program.cs given.

Instructions for safe storage of API Key given.

```bash
dotnet user-secrets init
dotnet user-secrets set "OpenAI:ApiKey" "sk-xxxxxxxx"
dotnet add package Microsoft.Extensions.Configuration
dotnet add package Microsoft.Extensions.Configuration.UserSecrets
```

```c#
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.UserSecrets;

var config = new ConfigurationBuilder()
    .AddUserSecrets<Program>()
    .Build();

var apiKey = config["OpenAI:ApiKey"];
Console.WriteLine(apiKey)
```

# Inital Run output

```bash
dotNet run
GPT Lab Starting...
Loaded OpenAI:ApiKey

Please enter your question for the model:
What is the significance of the openning line of the Godfather: "I believe in America"?
```

The opening line of "The Godfather," "I believe in America," serves several significant purposes in setting the tone and context for the film. Here are a few key points regarding its significance:

1. **Contrast with Reality**: The line is spoken by Amerigo Bonasera, an Italian-American who has been disappointed by the American justice system. This introduces a theme of disillusionment with American ideals, contrasting the notion of belief in America with the subsequent betrayals faced by characters in the story.       

2. **Cultural Commentary**: The statement reflects Bonasera's initial faith in American values, such as justice and fairness. As the narrative unfolds, the film explores the complexities of power, loyalty, and morality, suggesting that the idealized version of America doesn't always align with its realities, especially regarding issues of crime and retribution.

3. **Foreshadowing**: The line sets up the central conflict of the film. It foreshadows the moral dilemmas that characters, particularly Michael Corleone and Vito Corleone, will face as they navigate a world where traditional values clash with the harsh realities of power and survival.

4. **Establishing Themes**: "The Godfather" is deeply concerned with themes of family, loyalty, and the American Dream. The opening line encapsulates the tension between aspiration and disillusionment, which is woven throughout the narrative.

5. **Character Introduction**: The line also serves to introduce Bonasera as a character whose story and motivations are essential to the plot. His plea sets the stage for the moral complexities that the Corleone family embodies.

Overall, this opening line effectively encapsulates the central themes of the film and frames the narrative's exploration of the American experience, particularly for immigrant communities.


# ChatGPT Dialog - for later

Date

## Prompt

I have some PDF product manuals. Teach me how add them to the API for Retrieval-Augmented Generation.
