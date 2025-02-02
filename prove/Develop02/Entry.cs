class Entry
{
    public string prompt;
    public string date;
    public string answer;

    public void CreateEntry()
    {
        DateTime currentDate = DateTime.Now; 
        date = currentDate.ToString("yyyy-MM-dd");

        PromptManager promptManager = new PromptManager();

        prompt = promptManager.GetRandomPrompt();

        Console.WriteLine("Random prompt: " + prompt);
        answer = Console.ReadLine();
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {date} Prompt: {prompt}");
        Console.WriteLine($"Answer: {answer}");
    }
}