using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWarehouese
{
    public abstract class WarehouseItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        
        public WarehouseItem(string name, double price)
        {
            Name = name;    
            Price = price;
        }

        public abstract void Display();
    }
}
