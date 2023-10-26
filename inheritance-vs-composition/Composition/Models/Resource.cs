using Composition.Contracts;

namespace Composition.Models;

public struct Resource : IResource
{
    public int CurrentValue { get; set; }
    public int MaxValue { get; set; }

    public static Resource CreateFilled(int maxValue)
    {
        if (maxValue <= 0)
            throw new ArgumentOutOfRangeException(nameof(maxValue), maxValue, "Must be greater then zero");
        return new Resource
        {
            CurrentValue = maxValue,
            MaxValue = maxValue
        };
    }

    public static Resource Empty() => new();
}