public abstract class CombatUnit
{
    protected int Health;
    protected int Mana;
    protected int BaseDamage;
    public abstract DamageableUnitType UnitType { get; }
    public Position Position { get; set; }

    public void TakeDamage(int dmg)
    {
        Health -= dmg;
        if (Health <= 0)
        {
            GD.Print($"{GetType().Name} is defeated!");
        }
    }

    public bool IsAlive() => Health > 0;

    public virtual int GetTotalDamage(DamageTargetDetails targetDetails)
    {
        if (targetDetails.Distance > 1) // For simplicity, assuming only melee can attack.
            return 0;

        // Apply damage modifiers based on the target type.
        return BaseDamage;
    }

    protected CombatUnit()
    {
        Position = new Position();
    }
}