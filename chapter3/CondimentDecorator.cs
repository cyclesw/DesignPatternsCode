namespace DesignPattern.chapter3;

public abstract class CondimentDecorator : Beverage
{
    // java的new与C#的new ？？？？
    public abstract override string GetDescription();
}


public class Mocha : CondimentDecorator
{
    private Beverage _beverage;

    public Mocha(Beverage beverage)
    {
        _beverage = beverage;
    }
    
    public override string GetDescription()
    {
        return _beverage.GetDescription()  + ", Mocha";
    }

    public override double Cost()
    {
        return 0.20 + _beverage.Cost();
    }
}

public class Soy : CondimentDecorator
{
    private Beverage _beverage;

    public Soy(Beverage beverage)
    {
        this._beverage = beverage;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + ", Soy";
    }

    public override double Cost()
    {
        return _beverage.Cost() + 0.12;
    }
}

public class Whip : CondimentDecorator
{
    private Beverage _beverage;

    public Whip(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override string GetDescription()
    {
        return _beverage.GetDescription() + "Whip";
    }

    public override double Cost()
    {
        return _beverage.Cost() + 0.16;
    }
}