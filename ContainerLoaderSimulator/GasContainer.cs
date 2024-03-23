namespace ContainerLoaderSimulator;

public class GasContainer : Container
{
    private double pressure;

    public GasContainer(double maxLoad, double pressure) : base(maxLoad)
    {
        this.pressure = pressure;
        Console.WriteLine("Stworzono kontener " + GetContainerNumber() + " o maksymalnej ladownosci " + GetMaxLoad() + ", cisnienie " + pressure);
    }

    public override void Load(double cargoWeight)
    {
        if (cargoWeight > maxLoad)
        {
            throw new OverfillException("Waga ładunku nie może przekroczyć maksymalnej wagi: " + maxLoad);
        }

        currentLoad += cargoWeight;
    }

    public override void Unload()
    {
        double remainingLoad = currentLoad * 0.05;
        currentLoad -= currentLoad + remainingLoad;
    }
}