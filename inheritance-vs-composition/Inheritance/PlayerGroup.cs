public class PlayerGroup : CombatUnit
{
    private const int PlayerBaseDamage = 20; // Using Fireball as base damage
    private const int FireballManaCost = 30;
    private const int FireballModifierAgainstInfantry = 2;

    public override DamageableUnitType UnitType => DamageableUnitType.Infantry;

    public PlayerGroup() 
    {
        Health = 100;
        Mana = 100;
        BaseDamage = PlayerBaseDamage;
    }
    
    public override int GetTotalDamage(DamageTargetDetails targetDetails)
    {
        if (Mana < FireballManaCost)
            return 0;  // No damage if insufficient mana

        Mana -= FireballManaCost;

        if (targetDetails.TargetType == DamageableUnitType.Infantry)
            return BaseDamage * FireballModifierAgainstInfantry;

        return BaseDamage;
    }
}