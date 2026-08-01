using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
              "Welcome to the Breathing Activity",
              "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing")
              
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in...");
            CountDown(4);

            Console.WriteLine("\nBreathe out...");
            CountDown(4);
        }

        DisplayEndingMessage();
    }
}