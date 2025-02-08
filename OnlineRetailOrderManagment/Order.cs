using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRetailOrderManagment
{
    internal class Order
    {
        public int   OrderId {  get; set; }
        public DateTime OrderDate { get; set; }

        public Order(int  orderId, DateTime orderDate)
        {
            OrderId = orderId;
            OrderDate = orderDate;
        }
        public virtual string GetOrderStatus()
        {
            return "Order Placed";
        }
    }
}
