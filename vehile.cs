using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class Vehicle
    {
        public string ownerName { get; set; }
        public string vehicleType { get; set; }

        public static int registrationFee = 30000;

        public Vehicle()
        {
            ownerName = "Akash singh";
            vehicleType = "two-wheeler";
        }
        public Vehicle(string ownerName, string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;

        }
        public void DisplayVehicleDetails()
        {
            Console.WriteLine($"owner Name: {ownerName}, vehicle type : {vehicleType}, registration fee: {registrationFee} ");
        }

        public void UpdateRegistrationfee(int newRegstrationFee)
        {
            registrationFee = newRegstrationFee;
        }

        public static void Main(string[] args)
        {

            Vehicle vehicle1 = new Vehicle();
            vehicle1.DisplayVehicleDetails();



            Console.Write("Enter owner name: ");
            string ownerName = Console.ReadLine();

            Console.Write("Enter vechile type: ");
            string vehicleType = Console.ReadLine();

            Console.Write("enter the new registration fee: ");
            int newRegstrationFee = Convert.ToInt32(Console.ReadLine());

            Vehicle vehicle = new Vehicle(ownerName, vehicleType);
            vehicle.UpdateRegistrationfee(newRegstrationFee);
            vehicle.DisplayVehicleDetails();




        }
    }
}
