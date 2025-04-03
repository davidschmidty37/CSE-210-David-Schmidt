abstract class Character : GameObject
{
    public int Health { get; protected set; }
    public int AttackPower { get; protected set; }
    public int Defense { get; protected set; }
    public int Level { get; protected set; } = 1;
    public int Experience { get; protected set; } = 0;
    
    public Character(string name, string description, int health, int attackPower, int defense)
        : base(name, description)
    {
        Health = health;
        AttackPower = attackPower;
        Defense = defense;
    }

    public virtual void Attack(Character target)
    {
        int damage = Math.Max(0, AttackPower - target.Defense);
        target.TakeDamage(damage);
        Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage!");
    }
    
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Console.WriteLine($"{Name} takes {damage} damage. Remaining Health: {Health}");
        if (Health <= 0)
        {
            Console.WriteLine($"{Name} has been defeated!");
        }
    }
    
    public virtual void LevelUp()
    {
        Level++;
        Health += 10;
        AttackPower += 2;
        Defense += 1;
        Console.WriteLine($"{Name} leveled up to Level {Level}!");
    }
}