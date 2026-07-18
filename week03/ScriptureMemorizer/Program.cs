//I have my program working with a library of scriptures rather than a single one.
//The program choose scriptures at random to present to the user.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        List<Scripture> scriptures = new List<Scripture>();
        {
            scriptures.Add(new Scripture(new Reference("John",3,16),"For God so loved the world that he gave his only begotten Son that whoever believes in him should not perish but have everlasting life."));

            scriptures.Add(new Scripture(new Reference("Proverbs",3,5,6),"Trust in the Lord with all your heart and lean not on your own understanding In all your ways acknowledge Him and He shall direct your paths."));

            scriptures.Add(new Scripture(new Reference("Exodus",6,2),"And God spake unto Moses and said unto him Iam the Lord."));

            scriptures.Add(new Scripture(new Reference("1 Nephi",10,22),"And the Holy Ghost giveth authority that I should speak these things and deny them not."));

            scriptures.Add(new Scripture(new Reference("Ether",6,29),"And it came to pass that Jared died and his brother also."));
        }

        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        bool running = (true);
        while(running)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.AllWordsHidden())
            {
                running = false;
            }

            Console.WriteLine();
            Console.Write("Press Enter Key to continue or type 'quit' to end program: ");

            string response = Console.ReadLine();
            scripture.HideRandomWords(3);

            if (response.ToLower() == "quit")
            {
                running = false;
            }
           
        }
    }
}