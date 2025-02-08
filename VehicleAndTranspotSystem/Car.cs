using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAndTranspotSystem
{
    internal class Car : Vehicle
    {
        public int SeatCapacity { get; set; }

        public Car(int maxSpeed, string fuelType, int seatCapacity)
            : base(maxSpeed, fuelType)
        {
            SeatCapacity = seatCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Seat Capacity: {SeatCapacity}");
        }
    }
}
