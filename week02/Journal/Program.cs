// I have added a search feature which enables user to serch for an entry by mood, entry text or prompt text. 
//I also have added a motivating opening signature statement and a closing reminder feature to the program. 
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
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            { 
                Console.Write("How are you feeling today?");
                string mood = Console.ReadLine();
                Console.WriteLine();
            
                string prompt = generator.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.WriteLine();

                Console.Write("Your Response: ");
                Console.Write("> ");
                string response = Console.ReadLine();

                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();
                entry._mood = mood;
                entry._promptText = prompt;
                entry._entryText = response;

                journal.AddEntry(entry);

                Console.WriteLine("Journal entry added!");
            }
            else if (choice == "2")
            {
                
                static void PrintSignature()
                {
                Console.WriteLine("========================================");
                Console.WriteLine("      Collins' Personal Journal");
                Console.WriteLine("      Keep Writing. Keep Growing.");
                Console.WriteLine("========================================");
                Console.WriteLine();
                }
                PrintSignature();
                journal.DisplayAll();
                Console.WriteLine("Dont forget to pray!");
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
            
                Console.Write("Enter keyword or mood to search: ");
                string keyword = Console.ReadLine();
                Console.WriteLine();

                journal.SearchEntries(keyword); 
            }
            else if (choice == "6")
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for using Collins' Personal Journal.");
                Console.WriteLine("Keep Writing. Keep Growing.");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}