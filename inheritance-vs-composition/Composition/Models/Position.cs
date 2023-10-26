using Composition.Contracts;

namespace Composition.Models;

public struct Position : IPosition
{
    public int X { get; set; }
    public int Y { get; set; }
}