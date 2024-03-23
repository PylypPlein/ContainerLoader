namespace ContainerLoaderSimulator;

public class Ship
{
    private string name;
    private int maxSpeed;
    private double maxWeight;
    private double weight;
    private List<Container> containers;

    public Ship(string name, int maxSpeed, int maxWeight)
    {
        this.name = name;
        this.maxSpeed = maxSpeed;
        this.maxWeight = this.maxWeight;
    }

    public void LoadContainerOnShip(Container container)
    {
        if (weight + container.GetCurrentLoad() <= maxWeight)
        {
            containers.Add(container);
            weight += container.GetCurrentLoad();
            Console.WriteLine("Kontener " + container.GetContainerNumber() + " pomyślnie zaladowano na statek " + name);
        }
        else
        {
            Console.WriteLine("Nie można załadować więcej , maksymalna ładownośc statka : "+ maxWeight);
        }
    }

    public double GetWeight()
    {
        return weight;
    }

    public string GetName()
    {
        return name;
    }

    public double GetMaxWeight()
    {
        return maxWeight;
    }

    public int GetMaxSpeed()
    {
        return maxSpeed;
    }
}