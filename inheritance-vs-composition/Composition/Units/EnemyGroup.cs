using Composition.Contracts;
using Composition.DamageSources;
using Composition.Models;
using Composition.Utilities;

namespace Composition.Units;

public partial class EnemyGroup : INode, ICombatUnit
{
    private readonly int _maxHealth;
    private const int DefaultEnemyHealth = 100;
    public ICharacterResources Resources { get; set; }
    public IDamageSource DamageSource { get; set; }
    public IPosition Position { get; set; }


    public DamageableUnitType UnitType => DamageableUnitType.Infantry;

    public EnemyGroup() : this(DefaultEnemyHealth)
    {
    }

    public EnemyGroup(int maxHealth)
    {
        _maxHealth = maxHealth;
    }

    public void TakeDamage(int dmg)
    {
        Resources.Health.Decrement(dmg);
        if (!IsAlive())
        {
            GD.Print("enemy is DED good job");
            // Handle enemy-specific death logic
        }
    }

    public bool IsAlive() => Resources.IsAlive;

    public void _Ready()
    {
        Resources = new CharacterResources
        {
            Health = Resource.CreateFilled(_maxHealth),
            Mana = Resource.Empty()
        };
        DamageSource = new Spear();
        Position = new Position
        {
            X = 2,
            Y = 0
        };
    }

    public int GetTotalDamage(DamageTargetDetails targetDetails)
        => DamageSource.GetTotalDamage(Resources, targetDetails);
}