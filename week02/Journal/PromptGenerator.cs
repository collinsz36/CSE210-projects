using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of my day?",
        "Who was the most interesting person I interacted with today?",
        "What or whomade me sad today?",
        "What challenge did I overcome today?",
        "What should I have done differently today?"
    };
    public Random _random = new Random();

    public string GetRandomPrompt()
    { 
        return _prompts[_random.Next(_prompts.Count)];
    }
}