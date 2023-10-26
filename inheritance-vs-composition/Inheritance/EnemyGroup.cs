public class EnemyGroup : CombatUnit
{
    private const int EnemyBaseDamage = 25; // Using Spear as base damage
    private const int SpearModifierAgainstCalvary = 2;

    public override DamageableUnitType UnitType => DamageableUnitType.Calvary;

    public EnemyGroup()
    {
        Health = 100;
        BaseDamage = EnemyBaseDamage;
    }

    public override int GetTotalDamage(DamageTargetDetails targetDetails)
    {
        // Spears are melee only
        if (targetDetails.Distance > 1)
            return 0;

        if (targetDetails.TargetType == DamageableUnitType.Calvary)
            return BaseDamage * SpearModifierAgainstCalvary;

        return BaseDamage;
    }
}