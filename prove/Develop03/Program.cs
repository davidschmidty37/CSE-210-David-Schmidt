using System;

public class Program
{
    public static void Main(string[] args)
    {
        var scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Mosiah", 2, 17), "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture(new Reference("Moroni", 10, 4), "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.")
        };

        var random = new Random();
        foreach (var scripture in scriptures)
        {
            while (true)
            {
                
                Console.WriteLine(scripture);

                if (scripture.AllWordsHidden())
                {
                    Console.WriteLine("All words are hidden. Moving to the next scripture.");
                    break;
                }

                Console.WriteLine("\nPress Enter to hide random words or type 'quit' to exit.");
                var input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    return;
                }

                scripture.HideRandomWords(3);
            }
        }

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}
