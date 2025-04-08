class Room : GameObject
{
    public List<Enemy> Enemies { get; private set; } = new List<Enemy>();
    public List<GameObject> Loot { get; private set; } = new List<GameObject>();

    public bool HasPuzzle { get; private set; } = false;
    public string PuzzleDescription { get; private set; }

    public Room(string name, string description) : base(name, description)
    {
        if (name == "Mysterious Cave")
        {
            HasPuzzle = true;
            PuzzleDescription = "Solve the riddle to unlock the secret passage.";
        }
    }

    public void SolvePuzzle()
    {
        if (HasPuzzle)
        {
            Console.WriteLine($"Puzzle: {PuzzleDescription}");
            Console.WriteLine("You solved the puzzle! A hidden passage opens.");
            HasPuzzle = false;
        }
    }
}
