using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }

            return customer;
        }

        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
