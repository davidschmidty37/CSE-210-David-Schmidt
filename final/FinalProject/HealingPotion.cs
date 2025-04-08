class HealingPotion : GameObject
{
    public int HealAmount { get; private set; }

    public HealingPotion(string name, string description, int healAmount)
        : base(name, description)
    {
        HealAmount = healAmount;
    }
}
