using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running(new DateTime(2022, 11, 3), 30, 4.8);
        activities.Add(running);

        Cycling cycling = new Cycling(new DateTime(2022, 11, 3), 30, 9.7);
        activities.Add(cycling);

        Swimming swimming = new Swimming(new DateTime(2022, 11, 3), 30, 20);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}