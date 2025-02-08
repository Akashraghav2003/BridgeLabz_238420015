using VehicleAndTranspotSystem;

class Program
{
    static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car(100, "petrol", 5),
            new Truck(60, "Diesel", 5000),
            new Motorcycle(120, "CNG", false)
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayInfo();
        }
    }
}
