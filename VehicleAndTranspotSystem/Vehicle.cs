using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAndTranspotSystem
{
    internal class Vehicle
    {
        public int MaxSpeed { get; set; }
        public string FuelType { get; set; }

        public Vehicle(int maxSpeed, string fuleType)
        {
            MaxSpeed = maxSpeed;
            FuelType = fuleType;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}");
        }
    }
}
