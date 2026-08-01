//I have added features that makes sure no random prompts/questions are selected until they have all been used at least once in that session.
using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu:");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
            }
            else if (choice == "2") 
            {
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
            }
            else if (choice == "3")
            {
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
            }
            else if (choice == "4")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice."); 
                Console.WriteLine("\nPress Enter to return to the menu.");
                Console.ReadLine();
            }
        }
    }
}