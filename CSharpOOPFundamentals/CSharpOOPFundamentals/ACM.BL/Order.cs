using Acme.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order() 
        {
            OrderItems = new List<OrderItem>();
        }
        public Order(int orderId) : this()
        {
            OrderId = orderId;
        }

        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public int OrderId { get; private set; }
        public Address ShippingAddress { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public DateTimeOffset? OrderDate { get; set; }

        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";

        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        public string Log() => $"{OrderId}: Dat: {OrderDate.Value.Date} Status: {EntityState}";
    }
}
