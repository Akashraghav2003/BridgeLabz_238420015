using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRetailOrderManagment
{
    internal class ShippedOrder : Order
    {
        public string TrackingNumber { get; set; }

        public ShippedOrder(int  orderId, DateTime orderDate, string trackingNumber) : base(orderId, orderDate)
        {
            TrackingNumber = trackingNumber;
        }

        public override string GetOrderStatus()
        {
            return "Order Shipped - Tracking Number: " + TrackingNumber;
        }
    }
}
