using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf_order_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class OrderServce : IOrderService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

       

        public Order GetOrderData(Order order)
        {
            if (order != null)
            {
                if (order.OrderID == "102")
                {
                    order.OrderAmount = order.OrderAmount;
                }
            }
            return order;
        }
    }
}
