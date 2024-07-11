namespace DesignPattern.chapter4;

public abstract class PizzaStore
{
    public Pizza OrderPizza(string type)
    {
        Pizza pizza = CreatePizza(type);
        
        pizza.Prepare();
        
        pizza.Bake();
        
        pizza.Cut();
        
        pizza.Box();

        return pizza;
    }

    protected abstract Pizza CreatePizza(string type);
}


public class NyPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        if (type == "cheese")
            return new NyStyleCheesePizza();
        else
            return null;
    }
}
