using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.Description = "Assorted Size set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }

            Object myObject = new Object();

            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");

            return product;
        }

        public bool Save()
        {
            return true;
        }
    }
}
