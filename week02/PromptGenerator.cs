using system;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of my day?",
        "Who was the most interesting person I interacted with today?",
        "What made me sad today?",
        "What challenge did I overcome today?",
        "What should I have done differently today?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}