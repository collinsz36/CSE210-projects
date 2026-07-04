using System;

class Program
{
    static void Main(string[] args)
    {
         List<int> numbers = new List<int>();
        
        int userInput = -1;
        while (userInput != 0)
        {
            Console.Write("Enter any number and enter 0 to quit: ");
            
            string Response = Console.ReadLine();
            userInput = int.Parse(Response);
            
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

                float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}
    
