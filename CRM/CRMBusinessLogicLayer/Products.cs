using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBusinessLogicLayer
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Discription { get; set; }
        public double CurrentPrice { get; set; }

        public Products()
        {

        }

        public Products(int productId)
        {
            ProductId = productId;
        }

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Discription)) isValid = false;

            return isValid;
         
        }
    }
}
