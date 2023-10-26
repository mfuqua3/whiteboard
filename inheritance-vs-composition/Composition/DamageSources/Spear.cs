using Composition.Contracts;
using Composition.Models;

namespace Composition.DamageSources;

public class Spear : IDamageSource
{
    public const int Damage = 25;
    public const int ModifierAgainstCalvary = 2;

    public int GetTotalDamage(ICharacterResources characterResources, DamageTargetDetails targetDetails)
    {
        //Spears are melee only
        if (targetDetails.Distance > 1)
        {
            return 0;
        }

        return targetDetails.TargetType == DamageableUnitType.Calvary ? Damage * ModifierAgainstCalvary : Damage;
    }
}