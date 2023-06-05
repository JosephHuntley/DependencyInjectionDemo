namespace DemoDependencyInjection
{
    public interface IDemoSingleton
    {
        int Rand { get; }
        DateTime TimeStamp { get; }
    }
}