using System;

public class DeliveryFactory {
    public static Delivery createDelivery(string deliveryMethod)
    {
        switch(deliveryMethod)
        {
            case "courier" :
                return new CourierDelivery("JNE");
            case "post" :
                return new PostDelivery("Mailman");
            default:
                throw new ArgumentException("Delivery method not supported");
        }
    }
}