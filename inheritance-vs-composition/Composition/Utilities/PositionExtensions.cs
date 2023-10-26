using Composition.Contracts;

namespace Composition.Utilities;

public static class PositionExtensions
{
    public static double DistanceTo(this IPosition position1, IPosition position2)
        => Math.Sqrt(Math.Pow(position2.X - position1.X, 2) + Math.Pow(position2.Y - position1.Y, 2));
}