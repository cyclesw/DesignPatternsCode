namespace DesignPattern.chapter2;

public class WeatherStation
{
    public static void Start()
    {
        WeatherData wd = new WeatherData();
        
        CurrentConditionsDisplay ccd = new CurrentConditionsDisplay(wd);
        
        
        wd.SetMeasurements(80, 65, 30.4f);
        wd.SetMeasurements(82, 70, 29.2f);
        wd.SetMeasurements(78, 90, 29.2f);
    }
}