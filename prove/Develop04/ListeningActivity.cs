class ListingActivity : Activity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?"
    };

    public ListingActivity() : base("Listing Activity", "List as many things as you can in a given category.") { }

    public override void Perform()
    {
        StartMessage();
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
        PauseWithAnimation(3);
        Console.WriteLine("Start listing! Press Enter after each item. Type 'done' to finish.");
        int count = 0;
        while (Console.ReadLine()?.ToLower() != "done")
        {
            count++;
        }
        Console.WriteLine($"You listed {count} items.");
        EndMessage();
    }
}