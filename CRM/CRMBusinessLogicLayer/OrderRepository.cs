using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBusinessLogicLayer
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);
            if (orderId == 1)
            {
                Order order = new Order();
                Products products = new Products();

                order.Customer = customer.Retrieve(1);
                order.OrderDate = new DateTime(DateTime.Now);
                order.ShippingAddr = "S.Zukausko g. 21, Vilnius";
                order.OrderItem.Add(new Products());
            }
            return order;
        }
    }
}
