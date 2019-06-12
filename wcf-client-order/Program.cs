using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService1;

namespace wcf_client_order
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService order = new OrderService();
            string result= order.GetOrderData(123456);
            Console.WriteLine(result);

        }
    }
}
