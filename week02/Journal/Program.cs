using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the objects
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

            switch (choice)
            {
                case "1":
                    // Get a random prompt
                    string prompt = generator.GetRandomPrompt();

                    // Display the prompt
                    Console.WriteLine(prompt);

                    // Get the user's response
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    // Create a new journal entry
                    Entry entry = new Entry();

                    entry._date = DateTime.Now.ToShortDateString();
                    entry._promptText = prompt;
                    entry._entryText = response;

                    // Add the entry to the journal
                    journal.AddEntry(entry);

                    Console.WriteLine("Journal entry added!");
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter filename: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "4":
                    Console.Write("Enter filename: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}