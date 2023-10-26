namespace Inheritance;

public static class PositionExtensions
{
    public static double DistanceTo(this Position position1, Position position2)
        => Math.Sqrt(Math.Pow(position2.X - position1.X, 2) + Math.Pow(position2.Y - position1.Y, 2));
}