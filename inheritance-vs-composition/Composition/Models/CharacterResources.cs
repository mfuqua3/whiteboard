using Composition.Contracts;

namespace Composition.Models;

public class CharacterResources : ICharacterResources
{
    public IResource Health { get; init; }
    public IResource Mana { get; init; }
    public bool IsAlive => Health?.CurrentValue > 0;
}