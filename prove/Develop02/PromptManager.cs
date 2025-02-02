class PromptManager


{
    private List<string> prompts = new List<string>()
    {
        "What was your favorite part of the day today?",
        "What is something you are proud of today?",
        "What was your greatest accomplishment today?",
        "What was something you regret about today?",
        "What was a challenging part of the day?",
        "What came easy to you today?",
        "What was something new you learned today?",
        "What did you do to serve another person today?",
        "What was something that someone did for you today?",
        "What was your favorite meal of the day?"
    };

    private Random rnd = new Random();

    public string GetRandomPrompt()
    {
        int index = rnd.Next(prompts.Count);

        return prompts[index];
    }
}

