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

    
}