using Composition.Contracts;
using Composition.DamageSources;
using Composition.Models;
using Composition.Utilities;

namespace Composition.Units;

public partial class PlayerGroup : INode, ICombatUnit
{
    private const int DefaultPlayerHealth = 100;
    private const int DefaultPlayerMana = 100;

    private readonly int _maxHealth;
    private readonly int _maxMana;
    public ICharacterResources Resources { get; set; }
    public IDamageSource DamageSource { get; set; }
    public IPosition Position { get; set; }

    public PlayerGroup() : this(DefaultPlayerHealth, DefaultPlayerMana)
    {
    }

    public PlayerGroup(int maxHealth, int maxMana)
    {
        _maxHealth = maxHealth;
        _maxMana = maxMana;
    }


    public DamageableUnitType UnitType => DamageableUnitType.Infantry;

    public void TakeDamage(int dmg)
    {
        Resources.Health.Decrement(dmg);
        if (!Resources.IsAlive)
        {
            GD.Print("NUUU THE PLAYER IS DED");
            // Handle player-specific death logic
        }
    }

    public bool IsAlive() =>
        Resources.IsAlive;

    public void _Ready()
    {
        Resources = new CharacterResources
        {
            Health = Resource.CreateFilled(_maxHealth),
            Mana = Resource.CreateFilled(_maxMana)
        };
        DamageSource = new Fireball();
        Position = new Position
        {
            X = 0,
            Y = 0
        };
    }


    public int GetTotalDamage(DamageTargetDetails targetDetails)
        => DamageSource.GetTotalDamage(Resources, targetDetails);
}