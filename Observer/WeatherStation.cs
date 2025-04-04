public class WeatherStation : ISubject
{
    private List<IObserver> observers;
    private string temperature;
    private string humidity;

    public WeatherStation()
    {
        observers = new List<IObserver>();
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers(string message)
    {
        foreach (var observer in observers)
        {
            observer.Update(message);
        }
    }

    public void SetMeasurements(string temperature, string humidity)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        NotifyObservers($"Temperature: {temperature}, Humidity: {humidity}");
    }
}
