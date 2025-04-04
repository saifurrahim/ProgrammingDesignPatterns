using System;

public class NewsApp : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"News App: {message}");
    }
}