class Weapon : GameObject
{
    public int DamageBoost { get; private set; }
    public int Durability { get; private set; }
    
    public Weapon(string name, string description, int damageBoost, int durability)
        : base(name, description)
    {
        DamageBoost = damageBoost;
        Durability = durability;
    }
}