using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product
    {
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        public Product() {}

        public Product(int productId)
        {
            ProductId = productId;
        }

        /// <summary>
        /// Validates the product data
        /// </summary>
        public bool Validate()
        {
            if (CurrentPrice == 0) return false;

            return true;
        }

        /// <summary>
        /// Save a product
        /// </summary>
        public void Save()
        {

        }

        /// <summary>
        /// Retrieve a product
        /// </summary>
        public Product Retrieve(int productId)
        {
            return new Product();
        }

        /// <summary>
        /// Retrieve all products
        /// </summary>
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }
    }
}
