using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : EntityBase
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

        public override string ToString() => ProductName;
        /// <summary>
        /// Validates the product data
        /// </summary>
        public override bool Validate()
        {
            if (CurrentPrice == null) return false;

            return true;
        }
    }
}
