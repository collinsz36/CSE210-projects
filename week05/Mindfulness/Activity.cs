using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    private string _startingMessage;
    private string _description;
    private int _duration;

    public Activity(string startingMessage, string description)
    {
        _startingMessage = startingMessage;
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"{_startingMessage}\n");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session?\n:");
        if (int.TryParse(Console.ReadLine(), out int result))
        {
            _duration = result;
        }
        else
        {
        Console.WriteLine("Please enter a valid number.");
        }

        Console.WriteLine("\nGet ready...");
        SpinnerAnimation(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        SpinnerAnimation(3);

        Console.WriteLine($"\nYou have completed the {_startingMessage} for {_duration} seconds.");
        SpinnerAnimation(3);
    }
    public void CountDown(int seconds)
    {
       int i = seconds;
       while(i > 0)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i --;
        }  
    }
    public void SpinnerAnimation(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(300);
            Console.Write("\b");
            i = (i + 1) % spinner.Length;
        }
    }
    protected Random _random = new Random();

    protected void ShuffleList<T>(List<T> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
        int j = _random.Next(i + 1);

        T temp = list[i];
        list[i] = list[j];
        list[j] = temp;
        }
    }   
}