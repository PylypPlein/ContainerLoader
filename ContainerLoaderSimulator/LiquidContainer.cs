namespace ContainerLoaderSimulator;

public class LiquidContainer : Container
{
    private bool isHazardous;
    public LiquidContainer(double maxLoad, bool isHazardous) : base(maxLoad)
    {
        this.isHazardous = isHazardous;
        string type = isHazardous ? "niebezpieczna" : "nie niebezpieczna";
        Console.WriteLine("Stworzono kontener " + GetContainerNumber() + " o maksymalnej ladownosci " + GetMaxLoad() + ", przewidywana zawartość " + type);
    }

    public override void Load(double cargoWeight)
    {
        Console.WriteLine("Podaj nazwe zawartosci");
        if (contentName == null)
        {
            contentName = Convert.ToString(Console.ReadLine());
        }

        if (cargoWeight > maxLoad)
            throw new OverfillException("Waga ładunku nie może przekroczyć maksymalnej wagi: " + maxLoad);

        if (isHazardous)
        {
            if (cargoWeight > maxLoad * 0.5)
                throw new HazardousOperationException("Niebezpieczny ladunek może zająć tylko 50% miejsca.");
        }
        else
        {
            if (cargoWeight > maxLoad * 0.9)
                throw new HazardousOperationException("Zwyklyu ladunek może zająć tylko 90% miejsca.");
        }

        currentLoad += cargoWeight;
        Console.WriteLine("Zaladowano " + cargoWeight +"l "+ contentName + " do kontenera "+ GetContainerNumber());
    }
    public override void Unload()
    {   
        currentLoad -= currentLoad;
        Console.WriteLine("Rozladowano kontener " + GetContainerNumber());
    }
    
}