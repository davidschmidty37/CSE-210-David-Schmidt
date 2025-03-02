using System;

class Program
{
    static void Main()
    {
        Dictionary<string, Activity> activities = new Dictionary<string, Activity>
        {
            { "1", new BreathingActivity() },
            { "2", new ReflectionActivity() },
            { "3", new ListingActivity() }
        };

        while (true)
        {
            Console.WriteLine("\nMindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an activity: ");

            string choice = Console.ReadLine();
            if (activities.ContainsKey(choice))
            {
                activities[choice].Perform();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Try again.");
            }
        }
    }
}