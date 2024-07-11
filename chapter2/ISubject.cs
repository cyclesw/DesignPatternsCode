namespace DesignPattern.chapter2;

public interface ISubject
{
    public void RegisterObserver(IObserver observer);
    public void RemoveObserver(IObserver observer);
    public void NotifyObservers();
}

public interface IObserver
{
    public void Update(float temperature, float humidity, float pressure);//FIXME 没有弹性
}

public interface IDisplayElement
{
    public void Display();
}