using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartWarehouese
{
    internal class Storage<T> where T : WarehouseItem
    {
        public  List<T> items = new List <T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void Display()
        {
            Console.WriteLine("Storage item is : ");
            foreach (var item in items)
            {
                item.Display();
            }
        }
    }
}
