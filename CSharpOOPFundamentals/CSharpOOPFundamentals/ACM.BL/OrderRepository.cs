using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            return order;
        }

        public bool Save(Order order)
        {
            var success = true;
            if (order.HasChanges)
            {
                if (order.IsValid)
                {
                    // Call an Insert Stored Procedure
                }
                else
                {
                    // Call an Update Stored Procedure
                    success = false;
                }
            }
            else
            {
                success = false;
            }

            return success;
        }
    }
}
