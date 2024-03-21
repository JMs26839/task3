namespace taks3;

public class GasContainer: Container
{
    protected string _serialNumber;
    protected static int containerCounter;
    protected double pressure;
    public GasContainer(double mass, double height, double tareWeight, double payload, double depth,double pressure) : base(mass, height, tareWeight, payload, depth)
    {
        containerCounter++;
        _serialNumber = $"KON-{ExtractCapital(this.GetType().Name)}-{containerCounter}";
        this.pressure = pressure;
    }
    public string SerialNumber => _serialNumber;
    public override string ToString()
    {
        return $"Serial Number: {_serialNumber}, Mass: {mass}, Height: {height}, Tare Weight: {tareWeight}, Payload: {payload}, Depth:{depth}";
    }
    public void NotifyAboutHazardousSituation()
    {
        Console.WriteLine(" Cannot, empty container belowe 95% of its mass and pressure "+_serialNumber);
    }
    
    public  void emptyCargo(double press, double masa)
    { 
        double minPressure= pressure*0.05;
        Console.WriteLine("Remember Due to safety reasons we are obliged to leave 5% of gas in the container");
        if (press <= minPressure)
        {
            
            NotifyAboutHazardousSituation();
            pressure = minPressure;
        }
        double minMass= payload*0.05;

        if (masa<= minMass)
        {
            NotifyAboutHazardousSituation();
            mass = minMass;

        }
    }

    public override void loadwithMass(double mass)
    {
        if (mass > payload)
        {
            this.mass = payload;
            //Console.WriteLine("new maximal mass: "+ payload);
            throw new Exception("Error, maximal payload ");
            
        }
    }
}