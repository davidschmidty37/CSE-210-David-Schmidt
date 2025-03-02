abstract class Activity
{
    protected string Name;
    protected string Description;
    protected int Duration;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void StartMessage()
    {
        Console.WriteLine($"\nStarting {Name}...");
        Console.WriteLine(Description);
        Console.Write("Enter duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        PauseWithAnimation(3);
    }

    public void EndMessage()
    {
        Console.WriteLine("Great job! You have completed the activity.");
        Console.WriteLine($"You spent {Duration} seconds on {Name}.");
        PauseWithAnimation(3);
    }

    protected void PauseWithAnimation(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}...\r");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void Perform();
}