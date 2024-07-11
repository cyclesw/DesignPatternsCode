namespace DesignPattern.chapter3;

public abstract class Beverage
{
    protected string Description = "Unknown Beverage" ;

    public virtual string GetDescription()
    {
        return Description;
    }

    public abstract double Cost();
}

public class Espresso : Beverage
{
    public Espresso()
    {
        Description = "Espresso";
    }
    
    public override double Cost()
    {
        return 1.99;
    }
}

public class HouseBlend : Beverage
{
    public HouseBlend()
    {
        Description = "House Blend Coffee";
    }

    public override double Cost()
    {
        return 0.89;
    }
}

public class DarkRoast : Beverage
{
    public DarkRoast()
    {
        Description = "Dark Roast Coffee";
    }

    public override double Cost()
    {
        return 0.99;
    }
}