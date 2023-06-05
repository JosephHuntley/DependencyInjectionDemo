namespace DemoDependencyInjection
{
    public interface IDemoScoped
    {
        int Rand { get; }
        DateTime TimeStamp { get; }
    }
}