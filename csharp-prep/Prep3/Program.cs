using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        Console.WriteLine("Welcome to the guessing game!");
        Console.WriteLine("Guess the magic number in as few guesses as possible.");
        Console.WriteLine("A random number has been chosen!");

        int y = 0;
        int x = 0;

        
        do
        {
            Console.Write("What is your guess? ");
            string userInput = Console.ReadLine();
            
            if (int.TryParse(userInput, out x))
            {
                y++;
                if (x > number)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                else if (x < number)
                {
                    Console.WriteLine("Your guess is too low.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
        while (x != number);

        Console.WriteLine($"You guessed it! It took you {y} tries.");
    }
}
