namespace taks3;

public abstract class Container
{
    
    protected double mass;
    protected double height;
    protected double tareWeight;
    protected double payload;
    protected double depth;
    // protected string _serialNumber;
    // protected static int containerCounter;

    //public string SerialNumber => _serialNumber;
    public double Mass
    {
        get => mass; 
        set => mass = value;
    }
    
        
     
        

      
    

    public Container(
        double mass, double height, double tareWeight, double payload,double depth)
    {
        
        this.mass = mass;
        this.height = height;
        this.tareWeight = tareWeight;
        this.payload = payload;
        this.depth = depth;
        // containerCounter++;
        // _serialNumber = $"KON-{ExtractCapital(this.GetType().Name)}-{containerCounter}";
    }

    
    
       

    // public Container(string containerName)
    // {
    //     containerCounter++;
    //     string namig = ExtractCapital(this.GetType().Name);
    //     _serialNumber = $"KON-{namig}-{containerCounter}";
    // }
  
    // private string GenerateSerialNumber(string typeName)
    // {
    //     serialNumber = "Kon-" + extractCapital(containerName)+"-"+ containerCounter.ToString(); 
    // }


    protected string ExtractCapital(string input)
    {
        string result = "";
        foreach (char c in input )
        {
            if ((Char.IsUpper(c)))
            {
                result += c;
                if (result.Length==2)break;
                
            }
        }

        return result;
    }
    

    

    public virtual void emptyCargo()
    {
    }

    public  virtual void loadwithMass(double mass)
    {
        if (this.mass>= payload)
        {
            throw new OverfillException("your container is overloaded");
        }
    }
    
    
}


public class OverfillException : Exception
{
    public OverfillException()
    {
    }

    public OverfillException(string? message) : base(message)
    {
    }

    public OverfillException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}

