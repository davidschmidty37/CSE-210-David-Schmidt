class Dungeon
{
    public List<Room> Rooms { get; private set; } = new List<Room>();

    public Dungeon() 
    {
        Rooms.Add(new Room("Dark Chamber", "A damp and eerie chamber.") 
        {
            Enemies = { new Enemy("Goblin", "A sneaky creature", 30, 5, 2) }
        });

        Rooms.Add(new Room("Treasure Room", "A glittering treasure trove.") 
        {
            Loot = { new Weapon("Sword", "A sharp blade", 5, 10), new HealingPotion("Potion of Health", "Restores 20 health", 20) }
        });

        Rooms.Add(new Room("Mysterious Cave", "A hidden cave that smells of ancient magic.") 
        {
            Enemies = { new Enemy("Skeleton", "An ancient warrior risen from the grave", 50, 8, 3) },
            Loot = { new Weapon("Axe", "A heavy weapon", 10, 5) }
        });
    }
}
