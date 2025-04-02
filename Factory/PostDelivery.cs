using System;

public class PostDelivery : Delivery {
    private string postName;

    public PostDelivery(string postName)
    {
        this.postName = postName;
    }

    public override void calculateDeliveryCost()
    {
        Console.WriteLine("Calculating post delivery cost");

        // Logic here...
    }

    public override void processDelivery()
    {
        Console.WriteLine("{postName}'s post delivering your package");

        // Logic here...
    }
}