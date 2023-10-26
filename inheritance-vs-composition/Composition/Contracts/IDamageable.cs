using Composition.Models;

namespace Composition.Contracts;

public interface IDamageable
{
    DamageableUnitType UnitType { get; }
    void TakeDamage(int dmg);
    bool IsAlive();
}