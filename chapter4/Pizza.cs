using System.Collections;

namespace DesignPattern.chapter4;

public abstract class Pizza
{
    protected string _name;
    protected string _dough;
    protected string _sauce;
    protected ArrayList _toppings = new ArrayList();  //FIXME List

    public void Prepare()
    {
        Console.WriteLine($"Preparing {_name}");
        Console.WriteLine($"Tossing dough: {_dough}");
        Console.WriteLine($"Adding sauce: {_sauce}");
        Console.Write("Adding topping");

        foreach (var topping in _toppings)
        {
            Console.Write($": {topping}");
        }
    }

    public void Bake()
    {
        Console.WriteLine($"Bake for 25 minutes at 350");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }

    public void Box()
    {
        Console.WriteLine("Putting pizza in official PizzaStore box");
    }

    public string GetName()
    {
        return _name;
    }
}

public class NyStyleCheesePizza : Pizza
{
    public NyStyleCheesePizza()
    {
        _name = "NY Style Pizza";
        _dough = "Thin Crust Dough";
        _sauce = "Marinara Sauce";
        _toppings.Add("Grated Reggiano Cheese");
    }
}

public class ChicagoStyleCheesePizza : Pizza
{
    public ChicagoStyleCheesePizza()
    {
        _name = "ChicagoStyleCheesePizza";
        _dough = "Extra Thick Crust Dough";
        _sauce = "Plum Tomato Sauce";

        _toppings.Add("Shredded Mozzarella Cheese");
    }

    public new void Cut()
    {
        Console.WriteLine("cutting pizza into square slices");
    }
}