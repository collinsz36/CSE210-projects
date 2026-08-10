using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine("       ETERNAL QUEST");
            Console.WriteLine("==============================");

            manager.DisplayScore();

            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Goal Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("\nSelect a choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal(manager);
                break;
            }
            else if (choice == "2") 
            {
                manager.DisplayGoals();
                break;
            }
             else if (choice == "3")  
            {
                manager.RecordEvent();
                break;
            }
            else if (choice == "4") 
            {
                manager.Save("goals.txt");
                break;
            }
            else if (choice == "5") 
            {
                manager.Load("goals.txt");
                break;
            }
            else if (choice == "6")  
            {
                running = false;
                Console.WriteLine("Thank you for using Eternal Quest!");
                break;
            }
            else
            {       
                Console.WriteLine("Invalid choice.");
                break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("\nCreate a New Goal");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("\nSelect goal type: ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            Goal goal = new SimpleGoal(
                name,
                description,
                points
            );

            manager.AddGoal(goal);

            Console.WriteLine("Simple goal created!");
        }
        else if (type == "2")
        {
            Goal goal = new EternalGoal(
                name,
                description,
                points
            );

            manager.AddGoal(goal);

            Console.WriteLine("Eternal goal created!");
        }
        else if (type == "3")
        {
            Console.Write("How many times must you complete it? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for completing it? ");
            int bonus = int.Parse(Console.ReadLine());

            Goal goal = new ChecklistGoal(
                name,
                description,
                points,
                target,
                bonus
            );

            manager.AddGoal(goal);

            Console.WriteLine("Checklist goal created!");
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
    }
}