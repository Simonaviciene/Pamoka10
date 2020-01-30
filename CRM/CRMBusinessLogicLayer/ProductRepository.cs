using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBusinessLogicLayer
{
    class ProductRepository
    {
        public Products Retrieve(int productId)
        {
            Products product = new Products(productId);

            if (productId == 1)
            {
                product.ProductName = "Pienas";
                product.Discription = "Rokiskio Naminis";
                product.CurrentPrice = 1.85m;

            }
            return product;
        }
    }
}
