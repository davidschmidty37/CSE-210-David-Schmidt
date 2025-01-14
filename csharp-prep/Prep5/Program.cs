using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int numberSquared = SquareNumber(num);
        DisplayResults(name, numberSquared);
        

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        Console.WriteLine($"Your name is {name}");
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        string userinput = Console.ReadLine();
        int number = int.Parse(userinput);
        Console.WriteLine($"Your favorite number is {number}");
        return number;
    }
    static int SquareNumber(int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    }
    static void DisplayResults(string name, int numberSquared)
    {
        Console.WriteLine($"Hello {name}, the square of your number is {numberSquared}.");
    }
    
}