namespace ContainerLoaderSimulator;

public class RefrigeratedContainer : Container, IHazardNotifier
{
    private Dictionary<string, double> allowedProducts = new Dictionary<string, double>
    {
        {"Bananas", 13.3 },
        {"Chocolate", 18 },
        {"Fish", 2 },
        {"Meat", -15 },
        {"Ice Cream", -18 },
        {"Frozen Pizza", -30 },
        {"Cheese", 7.2 },
        {"Sausages", 5 },
        {"Butter", 20.5 },
        {"Eggs", 19 }
    };
    private double currentTemperature;
    private string productsName;

    public RefrigeratedContainer(double maxLoad, string productsName) : base(maxLoad)
    {
        
        this.productsName = productsName;
    }

    public override void Load(double cargoWeight)
    {
        if (cargoWeight > maxLoad)
            throw new OverfillException("Waga ładunku nie może przekroczyć maksymalnej wagi: " + maxLoad);

        currentLoad += cargoWeight;
    }

    public override void Unload()
    {
        currentLoad -= currentLoad;
        
    }

    private void SetTemperature(double temperature)
    {
        currentTemperature = temperature;
    }

    public void SetProduct(string productName)
    {
        if (!allowedProducts.ContainsKey(productName))
            throw new ArgumentException("Produkt "+ productName+" nie może być przydzielony temu kontenerowi " + GetContainerNumber());

        double requiredTemperature = allowedProducts[productName];
        if (currentTemperature < requiredTemperature)
            throw new InvalidOperationException("Wskazana temperatura jest za niska dla produktu "+productName);
        
        productsName = productName;
    }
}