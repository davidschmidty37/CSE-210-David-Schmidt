class GameManager
{
    private Player player;
    private Dungeon dungeon;
    
    public GameManager()
    {
        player = new Player("Hero");
        dungeon = new Dungeon();
    }
    
    public void StartGame()
    {
        Console.WriteLine("Welcome to the Dungeon Adventure!");
        foreach (var room in dungeon.Rooms)
        {
            player.ExploreRoom(room);
        }
        Console.WriteLine("Game Over!");
    }
}