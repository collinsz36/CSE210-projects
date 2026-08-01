using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not successful?",
        "What is your favorite thing about this experience ?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private int _currentPrompt = 0;
    private int _currentQuestion = 0;
    public ReflectionActivity()
        : base(
              "Welcome to the Reflection Activity",
              "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognise the power you have and how you can use it in other aspects of your life")
    {
        ShuffleList(_prompts);
        ShuffleList(_questions);  
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nConsider the following prompt:\n");
        if (_currentPrompt >= _prompts.Count)
        {
            ShuffleList(_prompts);
            _currentPrompt = 0;
       }

        Console.WriteLine($"--- {_prompts[_currentPrompt]} ---");
        _currentPrompt++;

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience:");

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            if (_currentQuestion >= _questions.Count)
        {
            ShuffleList(_questions);
            _currentQuestion = 0;
        }

        Console.WriteLine($"\n> {_questions[_currentQuestion]}");
        _currentQuestion++;

        SpinnerAnimation(10);
        }

        DisplayEndingMessage();
    }
}