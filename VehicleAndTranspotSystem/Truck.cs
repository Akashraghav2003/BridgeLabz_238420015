using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAndTranspotSystem
{
    internal class Truck :Vehicle
    {
        public int PayloadCapacity { get; set; }

        public Truck(int maxSpeed, string fuelType, int payloadCapacity): base(maxSpeed, fuelType)
        {
            PayloadCapacity = payloadCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Payload Capacity: {PayloadCapacity} kg");
        }
    }
}
