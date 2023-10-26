namespace Composition.Contracts;

public interface IResource
{
    public int CurrentValue { get; set; }
    public int MaxValue { get; set; }
}