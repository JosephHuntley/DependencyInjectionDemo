namespace DemoDependencyInjection
{
    public interface IDemoTransient
    {
        int Rand { get; }
        DateTime TimeStamp { get; }
    }
}