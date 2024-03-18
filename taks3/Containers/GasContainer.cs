namespace taks3;

public class GasContainer: Container
{
    public GasContainer(double mass, double height, double tareWeight, double payload, double depth) : base(mass, height, tareWeight, payload, depth)
    {
    }

    public override string ToString()
    {
        return $"Serial Number: {_serialNumber}, Mass: {mass}, Height: {height}, Tare Weight: {tareWeight}, Payload: {payload}, Depth:{depth}";
    }
}