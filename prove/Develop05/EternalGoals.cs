public class EternalGoal : ActiveGoal
{
    public EternalGoal(string name, string description) : base(name, description) { }

    public override void RecordProgress()
    {
        Points += 50; 
        Console.WriteLine($"Goal '{Name}' recorded. Total points: {Points}");
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {Name} (Eternal Goal) - {Points} points");
    }
}
