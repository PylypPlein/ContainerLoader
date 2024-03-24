namespace ContainerLoaderSimulator;

public class ShipList
{
    private List<Ship> ships;

    public ShipList()
    {
        ships = new List<Ship>();
    }

    public void AddShip(Ship ship)
    {
        ships.Add(ship);
    }
    public void ShowShipsList()
    {
        if (ships.Count > 0)
        {   
            Console.WriteLine("Lista statków:");
            for (int i = 0; i < ships.Count; i++)
            {
                Console.WriteLine(
                    $"{i + 1}. {ships[i].GetName()} - Załadowano: {ships[i].GetWeight()} kg - Max Ładowność: {ships[i].GetMaxWeight()}");
            }
        }
        else
        {
            Console.WriteLine("* Brak statków");
        }
    }

    public Ship GetShipOnIndex(int shipIndex)
    {
        shipIndex -= 1;
        if (shipIndex >= 0 && shipIndex < ships.Count)
        {
            return ships[shipIndex];
        }
        else
        {

            Console.WriteLine("Nieprawidłowy indeks statku.");
            return null;
        }
    }

    public void UpdateShipData(Container container, int shipIndex)
    {
        shipIndex -= 1;
        ships[shipIndex].LoadContainerOnShip(container);
    }
    
}