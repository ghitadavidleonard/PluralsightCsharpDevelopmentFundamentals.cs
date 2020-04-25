using Acme.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public int ProductId { get; private set; }
        private string _productName;
        public string ProductName 
        {
            get 
            {
                return _productName.InsertSpaces();
            }
            set 
            {
                _productName = value;
            } 
        }

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

        public string Log() => $"{ProductId}: {ProductName} Detail: {Description} Staus: {EntityState.ToString()}";
    }
}
