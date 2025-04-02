
class Program {
    static void Main(string[] args) {
        Delivery delivery = DeliveryFactory.createDelivery("courier");
        delivery.calculateDeliveryCost();
        delivery.processDelivery();

        // Another example would be when the project require multiple type of database connection
        // So you create Connection abstract class, then MySQLConnection and PostgreSQLConnection concrete class,
        // and ConnectionFactory class with static function createConnection.
    }
}