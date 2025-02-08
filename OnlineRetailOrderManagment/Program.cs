using OnlineRetailOrderManagment;

class Program
{
    static void Main()
    {
        Console.Write("Enter Order ID: ");
        int orderId = int.Parse(Console.ReadLine());
        Console.Write("Enter Order Date (yyyy-mm-dd): ");
        DateTime orderDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Has the order been shipped? (yes/no): ");
        string shippedResponse = Console.ReadLine().ToLower();

        if (shippedResponse == "yes")
        {
            Console.Write("Enter Tracking Number: ");
            string trackingNumber = Console.ReadLine();

            Console.Write("Has the order been delivered? (yes/no): ");
            string deliveredResponse = Console.ReadLine().ToLower();

            if (deliveredResponse == "yes")
            {
                Console.Write("Enter Delivery Date (yyyy-mm-dd): ");
                DateTime deliveryDate = DateTime.Parse(Console.ReadLine());
                DeliveredOrder deliveredOrder = new DeliveredOrder(orderId, orderDate, trackingNumber, deliveryDate);
                Console.WriteLine(deliveredOrder.GetOrderStatus());
            }
            else
            {
                ShippedOrder shippedOrder = new ShippedOrder(orderId, orderDate, trackingNumber);
                Console.WriteLine(shippedOrder.GetOrderStatus());
            }
        }
        else
        {
            Order order = new Order(orderId, orderDate);
            Console.WriteLine(order.GetOrderStatus());
        }
    }
}
