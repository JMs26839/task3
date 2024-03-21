namespace taks3;

public class RefregiratedContainer: Container
{
    private double maintainedTemp;
    private string productType;
    protected string _serialNumber;
    protected static int containerCounter;

    public RefregiratedContainer(double mass, double height, double tareWeight, double payload, double depth, double maintainedTemp, string productType, string serialNumber) : base(mass, height, tareWeight, payload, depth)
    {
        this.maintainedTemp = maintainedTemp;
        this.productType = productType;
        containerCounter++;
        _serialNumber = $"KON-{ExtractCapital(this.GetType().Name)}-{containerCounter}";
    }

    public string SerialNumber => _serialNumber;
}