public class ChecklistGoal : ActiveGoal
{
    public int RequiredTimes { get; set; }
    public int CurrentCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, string description, int requiredTimes, int bonusPoints)
        : base(name, description)
    {
        RequiredTimes = requiredTimes;
        BonusPoints = bonusPoints;
        CurrentCount = 0;
    }

    public override void RecordProgress()
    {
        if (CurrentCount < RequiredTimes)
        {
            CurrentCount++;
            Points += 10;
            Console.WriteLine($"Progress recorded for '{Name}'. Progress: {CurrentCount}/{RequiredTimes}.");

            if (CurrentCount == RequiredTimes)
            {
                Points += BonusPoints;
                IsCompleted = true;
                Console.WriteLine($"You completed '{Name}' and earned a bonus of {BonusPoints} points.");
            }
        }
        else
        {
            Console.WriteLine($"Goal '{Name}' is already completed.");
        }
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ {(IsCompleted ? "X" : " ")} ] {Name} (Checklist Goal) - {Points} points, Progress: {CurrentCount}/{RequiredTimes}");
    }
}

