using System;

public class CourierDelivery : Delivery {
    private string courierName;

    public CourierDelivery(string courierName)
    {
        this.courierName = courierName;
    }

    public override void calculateDeliveryCost()
    {
        Console.WriteLine("Calculating courier delivery cost");

        // Logic here...
    }

    public override void processDelivery()
    {
        Console.WriteLine("{courierName}'s courier delivering your package");

        // Logic here...
    }
}