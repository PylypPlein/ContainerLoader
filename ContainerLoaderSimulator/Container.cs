namespace ContainerLoaderSimulator;

public abstract class Container : IHazardNotifier
{
    protected string containerNumber;
    protected double maxLoad;
    protected double currentLoad;
    protected string contentName;
    protected int height;
    protected int depth;

    public Container(double maxLoad)
    {
        this.maxLoad = maxLoad;
        this.containerNumber = GenerateContainerNumber();
    }

    private string GenerateContainerNumber()
    {
        return "KON-" + GetType().Name.Substring(0, 1) + "-" + Guid.NewGuid().ToString().Substring(0, 4);
    }

    public void NotifyDanger(string containerNumber)
    {
        Console.WriteLine("Niebezpieczenstwo zidentyfikowano w kontenerze "+ containerNumber);
    }

    public abstract void Load(double cargoWeight);
    public abstract void Unload();

    public string GetContainerNumber()
    {
        return containerNumber;
    }

    public double GetCurrentLoad()
    {
        return currentLoad;
    }

    public double GetMaxLoad()
    {
        return maxLoad;
    }
}