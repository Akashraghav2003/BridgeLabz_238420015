using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAndTranspotSystem
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar) : base(maxSpeed, fuelType)
        {
            HasSidecar = hasSidecar;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Sidecar: {(HasSidecar ? "Yes" : "No")}");
        }
    }
}
