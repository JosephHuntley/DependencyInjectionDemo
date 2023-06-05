namespace DemoDependencyInjection;

public class Demo : IDemoScoped, IDemoSingleton, IDemoTransient
{
    public int Rand { get; private set; }
    public DateTime TimeStamp { get; private set; }

    public Demo()
    {
        Rand = Random.Shared.Next(1, 1001);
        TimeStamp = DateTime.Now;
    }
}

