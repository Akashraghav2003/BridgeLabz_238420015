using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWarehouese
{
    internal class Furniture : WarehouseItem
    {
        public string Material {  get; set; }

        public Furniture(string name, double price,string material): base(name, price)
        {
            Material = material;
        }

        public override void Display()
        {
            Console.WriteLine($"Furniture-Name: {Name}, Price: {Price}, Material {Material}");
        }
    }
}
