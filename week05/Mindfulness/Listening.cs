using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are your personal heroes?"
    };
    private int _currentPrompt = 0;

    public ListingActivity()
        : base(
              "Listing Activity",
              "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        ShuffleList(_prompts);
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nList as many responses as you can.");

        Console.WriteLine($"\nPrompt:");
        if (_currentPrompt >= _prompts.Count)
        {
            ShuffleList(_prompts);
            _currentPrompt = 0;
        }

        Console.WriteLine(_prompts[_currentPrompt]);
        _currentPrompt++;

        Console.WriteLine("\nYou may begin in...");
        CountDown(5);

        int count = 0;

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items.");

        DisplayEndingMessage();
    }
}