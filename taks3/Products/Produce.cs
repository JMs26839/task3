namespace taks3;

public abstract class Produce
{
    // one contaainer can olny store one type of product
    
    private string type;
    
    private double minimalTemp;

    protected Produce(string type, double minimalTemp)
    {
        this.type = type;
        
        this.minimalTemp = minimalTemp;
    }
}