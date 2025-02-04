//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace VehicleRegistrationSystem
//{
//    internal class Vehicle
//    {

//        // Static variable shared by all vehicles
//        private static double RegistrationFee = 500.00; // Default fee

//        // Readonly variable for unique Registration Number
//        private readonly int RegistrationNumber;
//        private string OwnerName;
//        private string VehicleType;

//        // Constructor to initialize vehicle details
//        public Vehicle(string ownerName, string vehicleType)
//        {
//            this.RegistrationNumber = new Random().Next(10000, 99999); // Generate unique registration number
//            this.OwnerName = ownerName;
//            this.VehicleType = vehicleType;
//        }

//        // Private method to display vehicle details
//        private void DisplayVehicleDetails()
//        {
//            if (this is Vehicle) // Using is operator to check instance
//            {
//                Console.WriteLine($"Registration No: {RegistrationNumber}, Owner: {OwnerName}, Type: {VehicleType}");
//                Console.WriteLine($"Registration Fee: {RegistrationFee:C}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid vehicle instance.");
//            }
//        }

//        // Static method to update the registration fee
//        private static void UpdateRegistrationFee(double newFee)
//        {
//            if (newFee >= 0)
//            {
//                RegistrationFee = newFee;
//                Console.WriteLine($"Registration fee updated to {RegistrationFee:C}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid fee value. Fee must be non-negative.");
//            }
//        }

//        // Public method to control private methods
//        public void ShowVehicleDetails()
//        {
//            DisplayVehicleDetails();
//        }

//        // Public static method to allow modifying the registration fee
//        public static void ChangeRegistrationFee(double newFee)
//        {
//            UpdateRegistrationFee(newFee);
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // List to store vehicle objects
//            List<Vehicle> vehicles = new List<Vehicle>();

//            Console.Write("Enter the number of vehicles to register: ");
//            int numVehicles;
//            while (!int.TryParse(Console.ReadLine(), out numVehicles) || numVehicles <= 0)
//            {
//                Console.Write("Invalid input! Please enter a positive number: ");
//            }

//            // Loop to create vehicle objects and take input
//            for (int i = 0; i < numVehicles; i++)
//            {
//                Console.WriteLine($"\nEnter details for Vehicle {i + 1}:");

//                Console.Write("Enter Owner Name: ");
//                string ownerName = Console.ReadLine();

//                Console.Write("Enter Vehicle Type (Car/Bike/Truck/etc.): ");
//                string vehicleType = Console.ReadLine();

//                // Create new Vehicle object and add to list
//                Vehicle vehicle = new Vehicle(ownerName, vehicleType);
//                vehicles.Add(vehicle);
//            }

//            // Display all registered vehicle details
//            Console.WriteLine("\nRegistered Vehicle Details:");
//            foreach (var vehicle in vehicles)
//            {
//                vehicle.ShowVehicleDetails();
//            }

//            // Allow user to update registration fee
//            Console.Write("\nDo you want to update the registration fee? (yes/no): ");
//            string updateChoice = Console.ReadLine().ToLower();

//            if (updateChoice == "yes")
//            {
//                Console.Write("Enter new registration fee: ");
//                double newFee;
//                while (!double.TryParse(Console.ReadLine(), out newFee) || newFee < 0)
//                {
//                    Console.Write("Invalid fee! Enter a valid non-negative amount: ");
//                }

//                Vehicle.ChangeRegistrationFee(newFee);
//            }

//            // Display updated vehicle details
//            Console.WriteLine("\nUpdated Vehicle Details:");
//            foreach (var vehicle in vehicles)
//            {
//                vehicle.ShowVehicleDetails();
//            }
//        }
//    }
//}
  
