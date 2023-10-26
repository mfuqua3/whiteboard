using Composition.Models;

namespace Composition.Contracts;

public interface IDamageDealer
{
    int GetTotalDamage(DamageTargetDetails targetDetails);
}