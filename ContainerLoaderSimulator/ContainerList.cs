namespace ContainerLoaderSimulator;

public class ContainerList
{
    private List<Container> containers;

    public ContainerList()
    {
        containers = new List<Container>();
    }

    public void AddContainer(Container container)
    {
        containers.Add(container);
    }
    public void ShowContainersList()
    {
        if (containers.Count > 0)
        {   
            Console.WriteLine("Lista kontenerów:");
            for (int i = 0; i < containers.Count; i++)
            {
                Console.WriteLine(
                    $"{i + 1}. {containers[i].GetContainerNumber()} - Waga: {containers[i].GetCurrentLoad()} kg - Max Ładowność: {containers[i].GetMaxLoad()}");
            }
        }
        else
        {
            Console.WriteLine("* Brak kontenerów");
        }
    }

    public void Load(int containerIndex)
    {
        containerIndex = containerIndex - 1;
        if (containerIndex >= 0 && containerIndex < containers.Count)
        {
            try
            {
                Console.WriteLine("Podaj wagę ładunku dla " + containers[containerIndex].GetContainerNumber());
                double weight = Convert.ToDouble(Console.ReadLine());
                containers[containerIndex].Load(weight);
                Console.WriteLine($"Ładunek załadowany do kontenera {containers[containerIndex].GetContainerNumber()} pomyślnie.");
            }
            catch (OverfillException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
            catch (HazardousOperationException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Nieprawidłowy indeks kontenera.");
        }
    }
    public void Unload(int containerIndex)
    {
        containerIndex = containerIndex - 1;
        if (containerIndex >= 0 && containerIndex < containers.Count)
        {
            try
            {
                containers[containerIndex].Unload();
            }
            catch (OverfillException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
            catch (HazardousOperationException ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Nieprawidłowy indeks kontenera.");
        }
    }
}