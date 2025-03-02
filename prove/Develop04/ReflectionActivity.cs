class ReflectionActivity : Activity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };

    private static readonly List<string> Questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you feel when it was complete?"
    };

    public ReflectionActivity() : base("Reflection Activity", "Reflect on times in your life when you showed strength.") { }

    public override void Perform()
    {
        StartMessage();
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
        PauseWithAnimation(3);
        for (int i = 0; i < Duration / 5; i++)
        {
            Console.WriteLine(Questions[random.Next(Questions.Count)]);
            PauseWithAnimation(5);
        }
        EndMessage();
    }
}