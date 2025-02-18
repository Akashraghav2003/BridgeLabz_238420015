using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWarehouese
{
    internal class Groceries : WarehouseItem
    {
        public DateOnly ExpiryDate {  get; set; }

        public Groceries(string name, double price, DateOnly expiryDate): base(name, price)
        {
            ExpiryDate = expiryDate;
        }

        public override void Display()
        {
            Console.WriteLine($"Groceries-Name: {Name}, Price: {Price}, ExpiryDate: {ExpiryDate}");
        }
    }
}
