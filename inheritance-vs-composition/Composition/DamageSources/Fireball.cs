using Composition.Contracts;
using Composition.Models;
using Composition.Utilities;

namespace Composition.DamageSources;

public class Fireball : IDamageSource
{
    public const int ManaCost = 30;
    public const int Damage = 25;
    public const int ModifierAgainstInfantry = 2;

    public int GetTotalDamage(ICharacterResources characterResources, DamageTargetDetails targetDetails)
    {
        //No damage if insufficient mana
        var hasSufficientMana = characterResources.Mana.TrySpendResource(ManaCost);
        if (!hasSufficientMana)
        {
            return 0;
        }

        //Fireballs do bonus damage to infantry
        return targetDetails.TargetType == DamageableUnitType.Infantry ? Damage * ModifierAgainstInfantry : Damage;
    }
}