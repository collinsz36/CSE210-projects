//I have put checks into the program to prevent recording events if no goals are set,
//prevent recording events on goals that are already complete and to prevent choosing an invalid goal.
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        bool running = true;

        while (running)
        {

            Console.WriteLine("Eternal Quest");
            Console.WriteLine("==============");
            Console.WriteLine();

            goalManager.DisplayPlayerInfo();

            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Record Event");
            Console.WriteLine("  4. Save Goals");
            Console.WriteLine("  5. Load Goals");
            Console.WriteLine("  6. Quit");
            Console.WriteLine();

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                goalManager.CreateGoal();
                Pause();
            }
            else if (choice == "2")
            {
                goalManager.ListGoals();
                Pause();
            }
            else if (choice == "3")
            {
                goalManager.RecordEvent();
                Pause();
            }
            else if (choice == "4")
            {
                goalManager.SaveGoals();
                Pause();
            }
            else if (choice == "5")
            {
                goalManager.LoadGoals();
                Pause();
            }
            else if (choice == "6")
            {
                running = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Pause();
            }
        }
    }
    static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }
}
