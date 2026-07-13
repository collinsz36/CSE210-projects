// I have added a motivating opening signature statement and a closing reminder feature to the journal.
using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

        if (choice == "1")
        {
            string prompt = generator.GetRandomPrompt();

            Console.WriteLine(prompt);

            Console.Write("> ");
            string response = Console.ReadLine();

            Entry entry = new Entry();

            entry._date = DateTime.Now.ToShortDateString();
            entry._promptText = prompt;
            entry._entryText = response;

            journal.AddEntry(entry);

            Console.WriteLine("Journal entry added!");
        }
        else if (choice == "2")
        {
            journal.DisplayAll();
        }
        else if (choice == "3")
        {
            Console.Write("Enter filename: ");
            string loadFile = Console.ReadLine();
            journal.LoadFromFile(loadFile);
        }
        else if (choice == "4")
        {
            Console.Write("Enter filename: ");
            string saveFile = Console.ReadLine();
            journal.SaveToFile(saveFile);
        }
        else if (choice == "5")
        {
            running = false;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
        }
    }
}