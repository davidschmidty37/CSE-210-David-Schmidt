using System;


class Program
{
    
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int choice = 0; 
       
       do
       {
        Console.WriteLine("Welcome to the Journal!");
        Menu menu = new Menu();
        menu.DisplayMenu(); 
        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            journal.AddEntry();
            Console.WriteLine("Goodjob on submitting an entry! Keep up the good habits.");
    
        }
        if (choice == 2)
        {
            Console.WriteLine("Here are your journal entries:");
            journal.DisplayEntries();
        }
        if (choice == 3)
        {
            journal.Load();
        }
        if (choice == 4)
        {
            journal.Save();
        }
       } while (choice != 5);

        Console.WriteLine("Goodbye");

    }
}