class Player : Character
{
    public List<Weapon> Inventory { get; private set; } = new List<Weapon>();
    public Weapon EquippedWeapon { get; private set; }
    
    public Player(string name) : base(name, "The brave hero", 100, 10, 5) { }

    public void EquipWeapon(Weapon weapon)
    {
        EquippedWeapon = weapon;
        Console.WriteLine($"{Name} equipped {weapon.Name}!");
    }
    
    public void ExploreRoom(Room room)
    {
        Console.WriteLine($"You entered {room.Name}: {room.Description}");
        if (room.Enemies.Count > 0)
        {
            Console.WriteLine("Enemies appear! Prepare for battle.");
            foreach (var enemy in room.Enemies)
            {
                Battle(enemy);
            }
        }
        else if (room.Loot.Count > 0)
        {
            Console.WriteLine("You found some loot!");
            foreach (var item in room.Loot)
            {
                Inventory.Add(item);
                Console.WriteLine($"You picked up {item.Name}!");
            }
        }
    }
    
    public void Battle(Enemy enemy)
    {
        while (Health > 0 && enemy.Health > 0)
        {
            Console.WriteLine("Choose an action: (A)ttack, (R)un");
            string action = Console.ReadLine().ToLower();
            if (action == "a")
            {
                Attack(enemy);
                if (enemy.Health > 0)
                    enemy.Attack(this);
            }
            else if (action == "r")
            {
                Console.WriteLine("You ran away!");
                return;
            }
        }
        if (Health > 0)
        {
            GainExperience(10);
        }
    }
    
    public void GainExperience(int xp)
    {
        Experience += xp;
        Console.WriteLine($"{Name} gained {xp} XP!");
        if (Experience >= Level * 10)
        {
            LevelUp();
        }
    }
}