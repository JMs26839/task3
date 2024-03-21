using taks3;


     LiquidContainer liquidContainer1 = new LiquidContainer(100.0, 100.0, 20.0, 200.0,200,true);
   //  Console.WriteLine(liquidContainer1.ToString());
     LiquidContainer liquidContainer2 = new LiquidContainer(110.0, 100.0, 20.0, 200.0,200,false);
   //  Console.WriteLine(liquidContainer2.ToString());
   // liquidContainer2.loadwithMass(185);
   // Console.WriteLine(liquidContainer2.ToString());
   // liquidContainer1.loadwithMass(185);
   // Console.WriteLine(liquidContainer1.ToString());
   GasContainer gasContainer1= new GasContainer(100.0, 100.0, 20.0, 200.0,200,200.0);
    Console.WriteLine(gasContainer1);
    gasContainer1.loadwithMass(200.0);
    gasContainer1.emptyCargo(10.5,10.5);
    Ship ship= new Ship(40.0,500,40000.0);
    ship.loadContainer(liquidContainer1);
    ship.loadContainer(liquidContainer2);
    Console.WriteLine(ship.GetTotalMass());
	

    
     
   
    List<Container> containers2 = ContainerGenerator.GenerateContainers(20);
    ship.loadListOfContainers(containers2);



    ship.DisplayShipDetails();
    //ship.DisplayContainersInfo();
   // ship.UnloadContainer(liquidContainer2);
    //ship.DisplayContainersInfo();
    ship.DisplayContainersInfo();
    ship.loadContainer(liquidContainer1);
    ship.ReplaceContainer(liquidContainer1,liquidContainer2);
    ship.ReplaceContainer(liquidContainer1,liquidContainer2);
    ship.DisplayContainersInfo();
    Ship ship2 = new Ship(20.0, 100, 1000.0);
    ship.TransferContainer(ship, ship2, liquidContainer2);
    ship2.DisplayContainersInfo();

    public class ContainerGenerator
    {
        public static List<Container> GenerateContainers(int numberOfContainers)
        {
            List<Container> containers = new List<Container>();
            Random random = new Random();

            for (int i = 0; i < numberOfContainers; i++)
            {
                
                if (random.Next(2) == 0) 
                {
                    
                    containers.Add(new LiquidContainer(random.NextDouble() * 100, random.NextDouble() * 10, random.NextDouble() * 5, random.NextDouble() * 20, random.NextDouble() * 10, random.Next(2) == 0));
                }
                else
                {
                    
                    containers.Add(new GasContainer(random.NextDouble() * 100, random.NextDouble() * 10, random.NextDouble() * 5, random.NextDouble() * 20, random.NextDouble() * 10, random.NextDouble() * 100));
                }
            }

            return containers;
        }
    }
    