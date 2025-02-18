using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWarehouese
{
    internal class Electronic: WarehouseItem
    {
        public string  Brand { get; set;}

        public Electronic(string name, double price, string brand) : base (name, price)
        {
            Brand = brand;
        }

        public override void Display()
        {
            Console.WriteLine($"Eelctronic Name: {Name}, price: {Price}, Brand: {Brand} ");
        }
    }
}
