using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem() { }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// Retrieve one order item
        /// </summary>
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        /// <summary>
        /// Saves an order item
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Validates the order item data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            if (Quantity <= 0) return false;
            if (ProductId <= 0) return false;
            if (PurchasePrice == null) return false;

            return true;
        }
    }
}
