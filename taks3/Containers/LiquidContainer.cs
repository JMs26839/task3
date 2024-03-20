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
    

    // private double mass
    // {
    //     get { return mass; }
    //     set { mass = value; }
    // }
    //
    public string SerialNumber => _serialNumber;
    public void NotifyAboutHazardousSituation()
    {
        Console.WriteLine("Haazardous situation happening "+_serialNumber);
    }

    
    public override string ToString()
    {
        return $"Serial Number: {_serialNumber}, Mass: {mass}, Height: {height}, Tare Weight: {tareWeight}, Payload: {payload}, Depth:{depth}, ";
    }

    public override void loadwithMass(double newMass)
    {double maxCap =0.5*payload;
        if (isHazardous == true)
        {
            Console.WriteLine("Can be filled only up to 50 of capacity %");

            if (newMass > maxCap)
               
            {
                NotifyAboutHazardousSituation();
                
                this.mass= maxCap;
                Console.WriteLine("new mass set to "+mass);
                
            }
        }
        else
        {
            maxCap = 0.9 * payload;
            if (newMass>= maxCap)
            {
                this.mass = maxCap;
                NotifyAboutHazardousSituation();
                Console.WriteLine("new mass set to "+mass);
                
            }
        }
    }
}