class Player : Character
{
    public List<GameObject> Inventory { get; private set; } = new List<GameObject>();

    public Weapon EquippedWeapon { get; private set; }

    public Player(string name) : base(name, "The brave hero", 100, 10, 5) { }

    public void EquipWeapon(Weapon weapon)
    {
        EquippedWeapon = weapon;
        Console.WriteLine($"{Name} equipped {weapon.Name}!");
    }

    public void UseItem(GameObject item)
    {
        if (item is Weapon weapon)
        {
            EquipWeapon(weapon);
            Console.WriteLine($"{Name} equipped {weapon.Name}!");
        }
        else if (item is HealingPotion potion)
        {
            Health += potion.HealAmount;
            Inventory.Remove(potion);
            Console.WriteLine($"{Name} used {potion.Name} and healed for {potion.HealAmount} HP.");
        }
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

        Console.WriteLine("Do you wish to: (E)xplore more, (F)ight enemies, (R)est?");
        string action = Console.ReadLine().ToLower();
        if (action == "e")
        {
            Console.WriteLine("You explore the room further and discover hidden treasures!");
        }
        else if (action == "f")
        {
            Console.WriteLine("You decide to fight the enemies in the room.");
        }
        else if (action == "r")
        {
            Console.WriteLine("You decide to rest and recover.");
            Health += 10;
            Console.WriteLine($"You rest and recover 10 health. Current health: {Health}");
        }
    }

    public void Battle(Enemy enemy)
    {
        while (Health > 0 && enemy.Health > 0)
        {
            Console.WriteLine("Choose an action: (A)ttack, (R)un, (D)efend, (U)se item");
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
            else if (action == "d")
            {
                Console.WriteLine("You defend and reduce incoming damage!");
                Defense += 2;
                Attack(enemy);
            }
            else if (action == "u")
            {
                Console.WriteLine("Choose an item to use:");
                foreach (var selectedItem in Inventory)
                {
                    Console.WriteLine($"{selectedItem.Name} - {selectedItem.Description}");
                }

                string itemChoice = Console.ReadLine();
                GameObject item = Inventory.Find(i => i.Name.ToLower() == itemChoice.ToLower());
                if (item != null)
                {
                    UseItem(item);
                }
                else
                {
                    Console.WriteLine("Invalid choice. You did nothing.");
                }
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
