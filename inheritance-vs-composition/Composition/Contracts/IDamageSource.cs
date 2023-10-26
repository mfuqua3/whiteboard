using Composition.Models;

namespace Composition.Contracts;

public interface IDamageSource
{
    int GetTotalDamage(ICharacterResources characterResources, DamageTargetDetails targetDetails);
}