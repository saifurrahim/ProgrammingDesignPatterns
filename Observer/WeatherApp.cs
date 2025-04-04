using System;

public class WeatherApp : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"Weather App: {message}");
    }
}
