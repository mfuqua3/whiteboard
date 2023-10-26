using Composition.Contracts;

namespace Composition.Utilities;

public static class ResourceExtensions
{
    public static void Decrement(this IResource resource, int decrement)
    {
        var modifiedValue = resource.CurrentValue - decrement;
        modifiedValue = Math.Max(modifiedValue, 0);
        modifiedValue = Math.Min(modifiedValue, resource.MaxValue);
        resource.CurrentValue = modifiedValue;
    }

    public static bool TrySpendResource(this IResource resource, int cost)
    {
        if (resource.CurrentValue - cost < 0)
        {
            return false;
        }

        resource.CurrentValue -= cost;
        return true;
    }
}