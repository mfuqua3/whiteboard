namespace Composition.Contracts;

public interface ICharacterResources
{
    IResource Health { get; init; }
    IResource Mana { get; init; }
    bool IsAlive { get; }
}