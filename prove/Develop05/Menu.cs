using System;

public class Menu
{
    public int DisplayMenu()
    {
        Console.WriteLine("\nGoal Helper 3000 Menu");
        Console.WriteLine("1. Create a Goal");
        Console.WriteLine("2. Record Progress");
        Console.WriteLine("3. Show Goals");
        Console.WriteLine("4. Show Total Score");
        Console.WriteLine("5. Exit");
        Console.Write("Enter your choice: ");
        
        
        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            return choice;
        }
        
        Console.WriteLine("Invalid input. Please select a valid option.");
        return 0;
    }

    public int ChooseGoalType()
    {
        Console.WriteLine("\nSelect Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        
        
        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            return choice;
        }
        
        Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
        return 0;
    }
}
