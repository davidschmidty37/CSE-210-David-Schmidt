public class SimpleGoal : ActiveGoal
{
    public SimpleGoal(string name, string description) : base(name, description) { }

    public override void RecordProgress()
    {
        if (!IsCompleted)
        {
            Points += 100;
            IsCompleted = true;
            Console.WriteLine($"Goal '{Name}' completed! You earned 100 points.");
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' is already completed.");
        }
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ {(IsCompleted ? "X" : " ")} ] {Name} (Simple Goal) - {Points} points");
    }
}