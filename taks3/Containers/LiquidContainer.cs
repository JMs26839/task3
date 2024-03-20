namespace taks3;

public class LiquidContainer: Container,IHazardNotifier
{
    protected bool isHazardous;
    protected string _serialNumber;
    protected static int containerCounter;
    public LiquidContainer(double mass, double height, double tareWeight, double payload,double depth,bool isHazardous)
        : base(mass, height, tareWeight, payload,  depth)
    {
        this.isHazardous = isHazardous;
        containerCounter++;
        _serialNumber = $"KON-{ExtractCapital(this.GetType().Name)}-{containerCounter}";
    }
    protected bool isHazarodus { get; set; }
    public string SerialNumber => _serialNumber;
    public void NotifyAboutHazardousSituation()
    {
        Console.WriteLine("Haazardous situation happening"+_serialNumber);
    }

    
    public override string ToString()
    {
        return $"Serial Number: {_serialNumber}, Mass: {mass}, Height: {height}, Tare Weight: {tareWeight}, Payload: {payload}, Depth:{depth}, ";
    }

    public override void loadwithMass(double mass)
    {double maxCap =0.5*payload;
        if (isHazardous == true)
        {
            Console.WriteLine("Can be filled only up to 50 of capacity %");
            
            if (mass>maxCap)
            {
                NotifyAboutHazardousSituation();
            }
        }
        else
        {
            maxCap = 0.9 * payload;
        }
    }
}