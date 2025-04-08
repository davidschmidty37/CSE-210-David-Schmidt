class Enemy : Character
{
    public Enemy(string name, string description, int health, int attackPower, int defense)
        : base(name, description, health, attackPower, defense) { }

    public void SpecialAttack(Player player)
    {
        player.Defense -= 2;
        Console.WriteLine($"{Name} uses a special attack, lowering your defense!");
    }
}
