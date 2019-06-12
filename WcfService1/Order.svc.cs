using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    public class OrderService : IOrderService
    {
        public string GetOrderData(int orderID)
        {
            return string.Format("You entered: {0}", orderID);
        }
    }
}
