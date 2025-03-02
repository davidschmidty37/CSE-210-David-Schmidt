class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding your breathing.") { }

    public override void Perform()
    {
        StartMessage();
        for (int i = 0; i < Duration / 6; i++)
        {
            Console.WriteLine("Breathe in...");
            PauseWithAnimation(3);
            Console.WriteLine("Breathe out...");
            PauseWithAnimation(3);
        }
        EndMessage();
    }
}