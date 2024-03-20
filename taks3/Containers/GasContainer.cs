namespace taks3;

public class GasContainer: Container
{
    protected string _serialNumber;
    protected static int containerCounter;
    public GasContainer(double mass, double height, double tareWeight, double payload, double depth) : base(mass, height, tareWeight, payload, depth)
    {
        containerCounter++;
        _serialNumber = $"KON-{ExtractCapital(this.GetType().Name)}-{containerCounter}";
    }
    public string SerialNumber => _serialNumber;
    public override string ToString()
    {
        return $"Serial Number: {_serialNumber}, Mass: {mass}, Height: {height}, Tare Weight: {tareWeight}, Payload: {payload}, Depth:{depth}";
    }
}