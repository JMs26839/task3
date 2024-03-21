



using taks3;


public class Ship
{
    private List<Container> Containers = new List<Container>();
    private double maxSpeed;
    private int amountOfContainers;
    private double maxWeightOfAllContainers;


    public Ship(double maxSpeed, int amountOfContainers, double maxWeightOfAllContainers)
    {
        this.maxSpeed = maxSpeed;
        this.amountOfContainers = amountOfContainers;
        this.maxWeightOfAllContainers = maxWeightOfAllContainers;

    }

    public double GetTotalMass()
    {
        return Containers.Sum(container => container.Mass);
    }

    public bool loadContainer(Container container)
    {
        if (Containers.Count >= amountOfContainers)
        {
            Console.WriteLine("Maximal amount of containers kept");
            return false;
        }

        double totalMass = Containers.Sum(c => c.Mass) + container.Mass;

        if (totalMass > maxWeightOfAllContainers)
        {
            Console.WriteLine("cant load more weight exceeded");
            return false;
        }



        Containers.Add(container);
        return true;
    }

    public void loadListOfContainers(List<Container> listToLoad)
    {
        foreach (var container in listToLoad)
            if (!loadContainer(container))
            {
                break;
            }
            
        {
            
        }
    }

    public void DisplayShipDetails()
    {
        Console.WriteLine($"Ship Details:");
        Console.WriteLine($"- Max Speed: {maxSpeed} knots");
        Console.WriteLine($"- Max Number of Containers: {amountOfContainers}");
        Console.WriteLine($"- Max Weight of All Containers: {maxWeightOfAllContainers} tons");
        Console.WriteLine($"- Current Number of Containers: {Containers.Count}");
        Console.WriteLine($"- Current Total Mass of Containers: {GetTotalMass()} tons");
    }

    public void DisplayContainersInfo()
    {
        Console.WriteLine($"Containers on Ship:");
        foreach (var container in Containers)
        {
            Console.WriteLine(container.ToString());
        }
    }

    public bool UnloadContainer(Container containerToUnload)
    {
        
        if (Containers.Contains(containerToUnload))
        {
            Containers.Remove(containerToUnload);
            return true; 
        }
        return false; 
    }
    public bool ReplaceContainer(Container oldContainer, Container newContainer)
    {
        int index = Containers.IndexOf(oldContainer);
        if (index != -1)
        {
            if (UnloadContainer(oldContainer) && loadContainer(newContainer))
            {
                return true;
            }
            else
            {
                // Handling the case where unloading was successful but loading the new one failed,
                Console.WriteLine("Failed to replace container due to restrictions. Rolling back.");
                loadContainer(oldContainer); 
            }
        }
        return false;
    }

    
    public  bool TransferContainer(Ship fromShip, Ship toShip, Container container)
    {
        if (fromShip.Containers.Contains(container))
        {
            if (toShip.Containers.Count < toShip.amountOfContainers 
                && toShip.GetTotalMass() + container.Mass <= toShip.maxWeightOfAllContainers)
            {
                fromShip.UnloadContainer(container);
                toShip.loadContainer(container);
                return true;
            }
        }
        return false;
    }

    
}