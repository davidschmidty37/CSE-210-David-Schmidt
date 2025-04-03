class Dungeon
{
    public List<Room> Rooms { get; private set; } = new List<Room>();
    
    public Dungeon() 
    {
        Rooms.Add(new Room("Dark Chamber", "A damp and eerie chamber.") { Enemies = { new Enemy("Goblin", "A sneaky creature", 30, 5, 2) } });
        Rooms.Add(new Room("Treasure Room", "A glittering treasure trove.") { Loot = { new Weapon("Sword", "A sharp blade", 5, 10) } });
    }
}