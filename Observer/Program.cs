class Program
{
    static void Main(string[] args)
    {
        WeatherStation weatherStation = new WeatherStation();
        WeatherApp weatherApp = new WeatherApp();
        NewsApp newsApp = new NewsApp();

        weatherStation.RegisterObserver(weatherApp);
        weatherStation.RegisterObserver(newsApp);

        weatherStation.SetMeasurements("25°C", "60%");
        weatherStation.SetMeasurements("26°C", "65%");

        weatherStation.RemoveObserver(newsApp);
        weatherStation.SetMeasurements("27°C", "70%");
    }
}