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

    public override void emptyCargo()
    {
        Console.WriteLine("Due to safety reasons we are obliged to leave 5% of gas in the container");
        
    }
}