class Room : GameObject
{
    public List<Enemy> Enemies { get; private set; } = new List<Enemy>();
    public List<Weapon> Loot { get; private set; } = new List<Weapon>();
    
    public Room(string name, string description) : base(name, description) { }
}