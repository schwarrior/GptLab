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


# ChatGPT Dialog - for later

Date

## Prompt

I have some PDF product manuals. Teach me how add them to the API for Retrieval-Augmented Generation.
