using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBusinessLogicLayer
{
    public class Order
    {
        public int OrderId { get; private set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate{ get; set; }
        public string ShippingAddr { get; set; }
        public List<Products> OrderItem { get; set; }

        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public bool Validate()
        {
            bool isValid = true;


            if (string.IsNullOrWhiteSpace(Customer.FullName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Customer.EmailAddress)) isValid = false;
            if (string.IsNullOrWhiteSpace(Customer.HomeAddress)) isValid = false;
            if (string.IsNullOrWhiteSpace(Customer.WorkAddress)) isValid = false;
            if (string.IsNullOrWhiteSpace(ShippingAddr)) isValid = false;

            return isValid;
        }
      
    }
}
